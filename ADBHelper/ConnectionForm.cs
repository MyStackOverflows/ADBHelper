using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace ADBHelper
{
    public partial class ConnectionForm : Form
    {
        string appData = "";
        int state = -1;
        string[] instructions = new string[] { "Ensure that USB debugging is enabled in developer options on your device, then click the 'Next' button.",
                                               "Turn on your device, unlock it, and plug it into the computer, then click the 'Next' button.",
                                               "Allow USB debugging from this PC on the device, then click the 'Next' button." };
        public ConnectionForm()
        {
            InitializeComponent();
            appData = $@"C:\Users\{Environment.UserName}\AppData\Roaming\ADBHelper";
            UnpackADB();
            UpdateInstructions();
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Equals("NextButton"))
            {
                if (state == 1) // if device is connected to computer, run "adb devices"
                {
                    HelperForm.ADBCommand("devices", true, true, false);
                }
                if (state == 2) // if user says they've allowed usb debugging
                {
                    // if we don't get a response from the phone through the adb shell, we're not connected. back to stage 1.
                    if (HelperForm.ADBCommand("shell pm list packages", false).Equals(""))
                    {
                        MessageBox.Show("Your device is not connected; perhaps you didn't follow the instructions correctly? Read the instructions and follow every step.");
                        state = -1;
                        UpdateInstructions();
                    }
                    else
                        new HelperForm(this).ShowDialog();
                }
                UpdateInstructions();
            }
        }

        // method which extracts and unzips the adb.zip file in Properties.Resources to %appdata%\ADBHelper\adb
        public void UnpackADB()
        {
            //bool repair = !Directory.Exists(appData + @"\adb");
            if (!Directory.Exists(appData + @"\adb") || new DirectoryInfo(appData + @"\adb").EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length) != 33047274)
            {
                // clear the appdata folder and set working directory to appdata
                if (Directory.Exists(appData))
                    Directory.Delete(appData, true);
                Directory.CreateDirectory(appData);
                Directory.SetCurrentDirectory(appData);

                File.WriteAllBytes("adb.zip", Properties.Resources.adb);    // copy the zip to appdata from exe resources
                ZipFile.ExtractToDirectory("adb.zip", appData);             // extract the zip in the appdata folder
            }
            Directory.SetCurrentDirectory(appData + @"\adb");               // set working directory to inside the extracted adb folder
        }

        public void UpdateInstructions()
        {
            state++;
            if (state < instructions.Length)
                InstructionsTextBox.Text = instructions[state];
        }

        // kills adb when form is closed
        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProcessStartInfo killInfo = new ProcessStartInfo("adb.exe", "kill-server");
            killInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process kill = new Process();
            kill.StartInfo = killInfo;
            kill.Start();
        }

        // gets amount of seconds since start of program
        private double ElapsedTime()
        {
            return (DateTime.UtcNow - Process.GetCurrentProcess().StartTime).TotalSeconds;
        }
    }
}