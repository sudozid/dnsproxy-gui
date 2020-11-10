using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace dnsproxygui{
    public partial class mainForm : Form
    {

        public static class tls
        {
            public static String tlscertloc;
            public static String privkeyloc;
        }
        public static class dnscrypt
        {
            public static String dnscryptfileloc;
        }
        public static class cacheprop
        {
            public static int cachesize;
            public static int minttl;
            public static int maxttl;
        }
        public static class logs
        {
            public static String logfilepath;
        }
        public static class dnsresolvers
        {
            public static string[] upstreamarr;
            public static string[] bootstrap;
            public static string[] fallback;
            public static string[] bogusnx;
        }


        private void addparams(String option, String param)
        {
            finalcommand.command += option;
            finalcommand.command += param;
        }
        private void disablebox(CheckBox checkbox,Control anycontrol)
        {
            if (checkbox.Checked == true)
            {
                anycontrol.Enabled = true;
                anycontrol.Text = "";
            }
            else
            {
                anycontrol.Enabled = false;
                anycontrol.Text = "";
            }
            
        }
        private int portstext(TextBox listenbox, int defvalue)
        {
            if (listenbox.Enabled==true){
                try{
                    return int.Parse(listenbox.Text);
                }
                catch(FormatException e){
                    //-2 means port is enabled but empty, cant be parsed.
                    return -2;
                }
            }
            else
            {
                return defvalue;
            }

        }
        private void checkvalidport(TextBox listenport)
        {
            try
            {
                int port = int.Parse(listenport.Text);
                if (port < 0 || port > 65535)
                {
                    MessageBox.Show("Invalid Port at "+listenport.Name);
                    listenport.Text = "";
                }
            }
            catch (FormatException o)
            {

            }
        }
       
        private void arraytocommand(String[] ipurl, String option)
        {
            foreach (String each in ipurl)
            {
                if (String.IsNullOrWhiteSpace(each) == false)
                    addparams(option, each);
            }
        }
        private String filedialogcreator(String title)
        {
            string AppPath = Path.GetDirectoryName(Application.ExecutablePath);
            OpenFileDialog boxname = new OpenFileDialog
            {
                InitialDirectory = AppPath,
                Title = title,
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                ShowReadOnly = true
            };

            if (boxname.ShowDialog() == DialogResult.OK)
            {
                return boxname.FileName;
            }
            else
            {
                return "Error";
            }
        }

        private bool isip(TextBox listenip)
        {
            String ip = listenip.Text;
            IPAddress IP;
            if (ip.Split('.').Length != 4)
                return false;
            bool flag = IPAddress.TryParse(ip, out IP);
            return flag;

        }
        private bool emptystring(dynamic listenip)
        {
            String ip = listenip.Text;
            if (String.IsNullOrEmpty(ip) || String.IsNullOrWhiteSpace(ip))
                return true;
            else
                return false;     
        }


        public mainForm()
        {
            InitializeComponent();
        }
        private String listenipcheck()
        {
            if (emptystring(listenIPTB) == false)
            {
                if (isip(listenIPTB) == true)
                    addparams(" --listen=", listenIPTB.Text);
                else
                {
                    return "Invalid IP";
                }
            }
            else
                MessageBox.Show("Using default Listen IP 0.0.0.0");
            return "Good";
        }
        private void textareatoarray()
        {
            dnsresolvers.upstreamarr = upstreamTA.Text.Split('\n');
            dnsresolvers.bootstrap = bootstrapTA.Text.Split('\n');
            dnsresolvers.fallback = fallbackTA.Text.Split('\n');
            dnsresolvers.bogusnx = bogusTA.Text.Split('\n');
        }
        private dynamic portstodict(dynamic ports)
        {
            ports.Add("reg", portstext(dnslistenTB, 0)); //0 in DNS Listen means disabled
            ports.Add("quic", portstext(quiclistenTB, -1)); //-1 keys will be removed as it means its disabled
            ports.Add("dot", portstext(dotlistenTB, -1));
            ports.Add("doh", portstext(dohlistenTB, -1));
            ports.Add("dnscrypt", portstext(dnscryptlistenTB, -1));

            return ports;
        }
        private void portparamaddhelper(String key, String paramarg,dynamic ports)
        {
            if (ports.ContainsKey(key))
                addparams(paramarg, (ports[key]).ToString());
        }

        private void portparamadd(dynamic ports)
        {
            portparamaddhelper("reg", " --port=", ports);
            portparamaddhelper("doh", " --https-port=", ports);
            portparamaddhelper("dot", " --tls-port=", ports);
            portparamaddhelper("quic", " --quic-port=", ports);
            portparamaddhelper("dnscrypt", " --dnscrypt-port=", ports);
        }
        private String portvalidate(dynamic ports)
        {
            //ashSet<int> uniquePorts = new HashSet<int>();

            foreach (KeyValuePair<string, int> entry in new Dictionary<string, int>(ports))
            {
                if (entry.Value == -1)
                {
                    ports.Remove(entry.Key);
                }
                if (entry.Value == -2)
                {
                    ports.Remove(entry.Key);
                    return "Port empty";
                }
            }
            return "Good";
        }
        private String tlscheckadd()
        {
            if (tlsconfigGB.Enabled == true)
            {
                if (String.IsNullOrEmpty(tls.tlscertloc) == false && String.IsNullOrEmpty(tls.privkeyloc) == false)
                {
                    addparams(" --tls-crt=", '"' + tls.tlscertloc + '"');
                    addparams(" --tls-key=", '"' + tls.privkeyloc + '"');
                }
                else
                    return "TLS Key or Cert not specified";
            }
            return "Good";
        }
        private String dnscryptcheck()
        {
            if (dnscryptGB.Enabled == true)
            {
                if (String.IsNullOrEmpty(dnscrypt.dnscryptfileloc) == false ||dnscrypt.dnscryptfileloc.Trim()!="Error")
                    addparams(" --dnscrypt-config=", dnscrypt.dnscryptfileloc);
                else
                    return("DNSCrypt is enabled but no config is given");
            }
            return "Good";
        }
        private String ednscheck()
        {
            if (ednsGB.Enabled)
            {
                if (emptystring(ednsipTB) == true)
                    return "Empty EDNS IP";
                else if (isip(ednsipTB))
                    addparams(" --edns --edns-addr=", ednsipTB.Text);
                else
                    return "Invalid EDNS IP";
            }
            return "Good";
        }
        private void searchmethod()
        {
            if (parralelRB.Checked)
                addparams(" --all-servers ", "");
            if (fastestRB.Checked)
                addparams(" --fastest-addr ", "");
        }

        private void cachecheck()
        {
            if (cacheGB.Enabled == true)
            {
                addparams(" --cache ", "");
                try
                {
                    cacheprop.cachesize = int.Parse(cachesizeTB.Text);
                    cacheprop.minttl = int.Parse(minttlTB.Text);
                    cacheprop.maxttl = int.Parse(maxttlTB.Text);
                }
                catch (FormatException c)
                {
                    MessageBox.Show("One of cache parameters is empty or invalid, cache may not work.");
                }
            }
        }
        private void cacheparamsadd()
        {
            if (cacheprop.cachesize != 0)
                addparams(" --cache-size=", cacheprop.cachesize.ToString());
            if (cacheprop.minttl != 0)
                addparams(" --cache-min-ttl=", cacheprop.minttl.ToString());
            if (cacheprop.maxttl != 0)
                addparams(" --cache-max-ttl=", cacheprop.maxttl.ToString());
        }
        private void logsparams()
        {
            if (String.IsNullOrEmpty(logs.logfilepath) == false)
            {
                addparams(" -o=", '"' + logs.logfilepath + '"');
            }
            if (verboseCB.Checked == true)
                addparams(" -v ", "");
        }
        private void miscparams()
        {
            if (noip6CB.Checked == true)
                addparams(" --ipv6-disabled ", "");
            if (refuseanyCB.Checked == true)
                addparams(" --refuse-any ", "");
            if (emptystring(ratelimTB) == false)
                addparams(" --ratelimit=", ratelimTB.Text);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            finalcommand.command = "dnsproxy ";
            String temp = "";
            textareatoarray();//convert all resolvers Strings to array

            String listenip = listenIPTB.Text;
            if (listenipcheck() != "Good") { MessageBox.Show("Invalid Listen IP"); return; }

            arraytocommand(dnsresolvers.upstreamarr, " -u=");
            arraytocommand(dnsresolvers.bootstrap, " -b=");
            arraytocommand(dnsresolvers.fallback, " -f=");
            arraytocommand(dnsresolvers.bogusnx, " --bogus-nxdomain=");


            //PORTS
            Dictionary<string, int> ports = new Dictionary<string, int>();

            
           
            portstodict(ports);//add ports to dictonary
            if (portvalidate(ports) != "Good") { MessageBox.Show("Port may be enabled but empty"); return; }//validate ports
            portparamadd(ports);//add ports from dictonary to command

            temp = tlscheckadd();
            if (temp != "Good") { MessageBox.Show(temp); return; }//check if tls specified and add as parameter

            temp=dnscryptcheck();//dnscrypt validate and add as parameter
            if (temp != "Good") { MessageBox.Show(temp); return; }

            temp=ednscheck();
            if (temp != "Good") { MessageBox.Show(temp); return; }

            searchmethod();

            cachecheck();
            cacheparamsadd();

            logsparams();

            miscparams();


            var myform=new outputform();
            myform.ShowDialog();
            
        }

        private void versionBT_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            string output = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "dnsproxy.exe";
            p.StartInfo.Arguments = "--version";
            try
            {
                p.Start();
            }
            catch (SystemException x) { MessageBox.Show("Dnsproxy not found?"); }
            try {
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
            }
            catch (InvalidOperationException f) { }
            if(String.IsNullOrEmpty(output)==false)
            MessageBox.Show(output);
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void tlscertBT_Click(object sender, EventArgs e)
        {
            tls.tlscertloc=filedialogcreator("Browse TLS Certificate");
            MessageBox.Show(tls.tlscertloc);
        }

        private void tlskeyBT_Click(object sender, EventArgs e)
        {
            tls.privkeyloc = filedialogcreator("Browse TLS Key");
            MessageBox.Show(tls.privkeyloc);
        }
        private void dnscryptBT_Click(object sender, EventArgs e)
        {
            dnscrypt.dnscryptfileloc = filedialogcreator("Browse DNSCrypt Config File");
            MessageBox.Show(dnscrypt.dnscryptfileloc);
        }
        private void dnslistenenableCB_CheckedChanged(object sender, EventArgs e)
        {
            disablebox(dnslistenenableCB, dnslistenTB);
        }

        private void quiclistenenableCB_CheckedChanged(object sender, EventArgs e)
        {
            disablebox(quiclistenenableCB, quiclistenTB);
        }

        private void tlslistenenableCB_CheckedChanged(object sender, EventArgs e)
        {
            disablebox(tlslistenenableCB, dotlistenTB);
            disablebox(tlslistenenableCB, tlsconfigGB);
        }
        private void dohlistenenableCB_CheckedChanged(object sender, EventArgs e)
        {
            disablebox(dohlistenenableCB, dohlistenTB);
            disablebox(dohlistenenableCB, tlsconfigGB);
        }
        private void dnscryptlistenenableCB_CheckedChanged(object sender, EventArgs e)
        {
            disablebox(dnscryptlistenenableCB, dnscryptlistenTB);
            disablebox(dnscryptlistenenableCB, dnscryptGB);
        }

        private void ednsenableCB_CheckedChanged(object sender, EventArgs e)
        {
            string externalip="";
            try
            {
                 externalip = new WebClient().DownloadString("http://ifconfig.co/ip").Trim();
            }
            catch (WebException x) { ednsipTB.Text = ""; }
            ednsipTB.Text = externalip;
            if (ednsenableCB.Checked == false)
            {
                ednsipTB.Text = "";
                ednsGB.Enabled = false;
            }
            else
                ednsGB.Enabled = true;
        }

        private void listenTB_Leave(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            checkvalidport(tb);
        }

        private void upstreamTA_Leave(object sender, EventArgs e)
        {/*
            var rtb = sender as RichTextBox;
            if (emptystring(rtb)) { 
                MessageBox.Show("No upstream provided, using default upstreams.");
                rtb.Text = "tls://1.1.1.1\n\ntls://9.9.9.9\n\ntls://8.8.8.8\n\nhttps://doh.opendns.com/dns-query";
            }*/
        }

        private void cacheenableCB_CheckedChanged(object sender, EventArgs e)
        {
            if (cacheenableCB.Checked)
            {
                cacheGB.Enabled =true;
            }
            else
            {
                cachesizeTB.Text = "";
                minttlTB.Text = "";
                maxttlTB.Text = "";
                cacheGB.Enabled = false;
            }
        }

        //used by all three cache textboxes and ratelimit box not just cachesize
        private void cachesizeTB_Leave(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            String input = tb.Text;
            if (emptystring(tb) == false)
            {
                if (Regex.IsMatch(input, @"\d"))
                {
                    int num = int.Parse(input);
                    if (num < 0){
                        MessageBox.Show("Number can't be -ve");
                        tb.Text="";
                        }
                }
            }
        }

        private void logfileBT_Click(object sender, EventArgs e)
        {
            logs.logfilepath = filedialogcreator("Browse Log File Path");
            MessageBox.Show(logs.logfilepath);
        }
        public void wc_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            
            downloadProgressBar.Value = e.ProgressPercentage;
            if (downloadProgressBar.Value > 0)
            {
                downloadProgressBar.Visible = true;
                completedLbl.Visible = false;
            }
            if (downloadProgressBar.Value == 100) { 
                downloadProgressBar.Visible = false;
                completedLbl.Visible = true;
                MessageBox.Show("Download has been completed,unzip the file downloaded and place executable in same directory as dnsproxygui.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = "https://api.github.com/repos/AdguardTeam/dnsproxy/releases/latest";
            var ping = new System.Net.NetworkInformation.Ping();
            try
            {
                var result = ping.Send("api.github.com");
            }
            catch(System.Net.NetworkInformation.PingException j)
            {
                MessageBox.Show("GitHub can't be pinged, Internet may be down");
                return;
            }
            
            //catch (PingException x) {}
            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "Only a test!");
                client.Headers.Add("content-type", "application/json");
            
                var details = JObject.Parse(client.DownloadString(url));
                List<string> terms = new List<string>();
                int x=0;
                try
                {
                    while (true){
                        terms.Add((details["assets"][x]["browser_download_url"]).ToString());
                        x++;}
                }
                catch (ArgumentOutOfRangeException l) { }
                List<string> termstemp = new List<string>(terms);
                foreach (String i in terms)
                {
                    if (i.Contains("dnsproxy-windows")==false)
                    {
                        termstemp.Remove(i);
                    }
                }
                String dllink="";
                foreach (String i in termstemp)
                {
                    if (Environment.Is64BitOperatingSystem)
                    {
                        if (i.Contains("amd64")) dllink = i;
                    }
                    else { if (i.Contains("386")) dllink = i; }
                }

                var uri = new Uri(dllink);
                client.DownloadFileAsync(uri, "dnsproxy.zip");
                MessageBox.Show("Download has started, make sure internet doesn't go down, as I haven't coded in network check");
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                
            }
        }
        }
    //namespace scope so other forms can access it
    public static class finalcommand
    {
        public static String command;
    } 
    }
