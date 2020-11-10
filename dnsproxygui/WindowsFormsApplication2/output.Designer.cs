namespace dnsproxygui
{
    partial class outputform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.outputTA = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.windowsServiceCreate = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your DNSProxy command looks like this:";
            // 
            // outputTA
            // 
            this.outputTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTA.Location = new System.Drawing.Point(16, 46);
            this.outputTA.Name = "outputTA";
            this.outputTA.ReadOnly = true;
            this.outputTA.Size = new System.Drawing.Size(646, 340);
            this.outputTA.TabIndex = 1;
            this.outputTA.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "(BUGGY) Run the command";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputTA);
            this.Controls.Add(this.label1);
            this.Name = "outputform";
            this.Text = "Output Command";
            this.Shown += new System.EventHandler(this.outputform_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox outputTA;
        private System.Windows.Forms.Button button1;
        private System.ServiceProcess.ServiceController windowsServiceCreate;
    }
}