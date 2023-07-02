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

namespace ADBHelper
{
    public partial class HelperForm : Form
    {
        ConnectionForm parent;
        List<string> ApplicationList = new List<string>();

        public HelperForm(ConnectionForm p)
        {
            InitializeComponent();
            parent = p;
            RefetchApplicationList();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (TabControl.SelectedIndex == 0)      // if application tab is selected
            {
                string command = button.Tag.ToString();        // tags: ResetButton == clear, UninstallButton == uninstall, EnableButton == enable

                if (MessageBox.Show($"Are you sure you want to perform '{command}' on these apps?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    foreach (string i in ApplicationsCheckedListBox.CheckedItems)
                        Console.WriteLine(ADBCommand($"shell pm {command} --user 0 {i}", false));

                RefetchApplicationList();
            }
            else if (TabControl.SelectedIndex == 1)     // if console tab is selected
            {
                //settings put secure sysui_qs_tiles "$(settings get secure sysui_qs_tiles),MobileData,Hotspot"

            }
        }

        // filter ApplicationsCheckedListBox when text is changed
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string term = SearchTextBox.Text;
            ApplicationsCheckedListBox.Items.Clear();
            foreach (string app in ApplicationList)
                if (app.Contains(term))
                    ApplicationsCheckedListBox.Items.Add(app);
        }

        // if a radiobutton gets changed, update ApplicationsCheckedListBox
        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Name.Contains("Apps"))
                RefetchApplicationList();
        }

        public static string ADBCommand(string command, bool wait = true, bool hidden = true)
        {
            ProcessStartInfo info = new ProcessStartInfo("adb.exe", command);
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            if (hidden)
                info.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = info;
            process.Start();
            if (wait)
                process.WaitForExit();
            //process.Dispose(); ??
            return process.StandardOutput.ReadToEnd();
        }

        // updates checkedlistbox and applicationlist
        private void RefetchApplicationList()
        {
            ApplicationsCheckedListBox.Items.Clear();
            ApplicationList.Clear();
            // gets list of packages and populates ApplicationsCheckedListBox
            foreach (string name in ADBCommand($"shell pm list packages{(SystemAppsRadioButton.Checked ? " -s" : "")}{(ThirdPartyAppsRadioButton.Checked ? " -3" : "")}{(EnabledAppsRadioButton.Checked ? " -e" : "")}{(DisabledAppsRadioButton.Checked ? " -d" : "")} --user 0", false).Replace("package", "").Replace(Environment.NewLine, "").Substring(1).Split(':'))
            {
                if (name.Contains(SearchTextBox.Text))
                    ApplicationsCheckedListBox.Items.Add(name);
                ApplicationList.Add(name);
            }
        }

        // close parent form when this form closes, therefore causing ConnectionForm_FormClosing to be called which kills the adb connection/server
        private void HelperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Close();
        }

        // function for rudimentary adb shell
        private void ConsoleInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13)  // if keychar != enter, return
                return;
            string c = ConsoleInputTextBox.Text;
            ConsoleInputTextBox.Text = "";
            string result = ADBCommand($"shell {c}");
            result = result == "" ? "Invalid command or command had no output." : result;
            ConsoleOutputTextBox.AppendText($"{c}{Environment.NewLine}{result}{Environment.NewLine}adb shell> ");
        }
    }
}