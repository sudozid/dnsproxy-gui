# DNS Proxy GUI

A Windows Forms GUI Frontend for [AdguardTeam/dnsproxy](https://github.com/AdguardTeam/dnsproxy).

## About

This application provides a user-friendly graphical interface for configuring and managing DNS proxy settings. It allows users to easily set up DNS filtering, encryption, and other advanced DNS features provided by the dnsproxy tool.

## Prerequisites

- .NET Framework 4.5 or higher
- Newtonsoft.Json package (automatically restored via NuGet)

## Building

1. Open `dnsproxygui/dnsproxygui.sln` in Visual Studio
2. Restore NuGet packages
3. Build the solution

## Project Structure

- `dnsproxygui/WindowsFormsApplication2/` - Main application source code
- `main.cs` - Main form and application logic  
- `output.cs` - Output/logging form
- `Program.cs` - Application entry point

## Dependencies

- **Newtonsoft.Json** - JSON serialization and parsing
