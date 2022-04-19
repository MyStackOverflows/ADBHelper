
namespace ADBHelper
{
    partial class HelperForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ApplicationsTabPage = new System.Windows.Forms.TabPage();
            this.EnableButton = new System.Windows.Forms.Button();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.AppFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.SystemAppsRadioButton = new System.Windows.Forms.RadioButton();
            this.AllAppsRadioButton = new System.Windows.Forms.RadioButton();
            this.DisabledAppsRadioButton = new System.Windows.Forms.RadioButton();
            this.ThirdPartyAppsRadioButton = new System.Windows.Forms.RadioButton();
            this.EnabledAppsRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ConsoleTabPage = new System.Windows.Forms.TabPage();
            this.ConsoleOutputTextBox = new System.Windows.Forms.TextBox();
            this.ConsoleInputTextBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.ApplicationsTabPage.SuspendLayout();
            this.AppFilterGroupBox.SuspendLayout();
            this.ConsoleTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ApplicationsTabPage);
            this.TabControl.Controls.Add(this.ConsoleTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(360, 368);
            this.TabControl.TabIndex = 0;
            // 
            // ApplicationsTabPage
            // 
            this.ApplicationsTabPage.Controls.Add(this.EnableButton);
            this.ApplicationsTabPage.Controls.Add(this.UninstallButton);
            this.ApplicationsTabPage.Controls.Add(this.AppFilterGroupBox);
            this.ApplicationsTabPage.Controls.Add(this.label1);
            this.ApplicationsTabPage.Controls.Add(this.SearchTextBox);
            this.ApplicationsTabPage.Controls.Add(this.ApplicationsCheckedListBox);
            this.ApplicationsTabPage.Controls.Add(this.ResetButton);
            this.ApplicationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ApplicationsTabPage.Name = "ApplicationsTabPage";
            this.ApplicationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationsTabPage.Size = new System.Drawing.Size(352, 342);
            this.ApplicationsTabPage.TabIndex = 0;
            this.ApplicationsTabPage.Text = "Applications";
            this.ApplicationsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnableButton
            // 
            this.EnableButton.Location = new System.Drawing.Point(271, 284);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(75, 23);
            this.EnableButton.TabIndex = 12;
            this.EnableButton.Tag = "enable";
            this.EnableButton.Text = "Enable";
            this.EnableButton.UseVisualStyleBackColor = true;
            this.EnableButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // UninstallButton
            // 
            this.UninstallButton.Location = new System.Drawing.Point(271, 313);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(75, 23);
            this.UninstallButton.TabIndex = 11;
            this.UninstallButton.Tag = "uninstall";
            this.UninstallButton.Text = "Uninstall";
            this.UninstallButton.UseVisualStyleBackColor = true;
            this.UninstallButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // AppFilterGroupBox
            // 
            this.AppFilterGroupBox.Controls.Add(this.SystemAppsRadioButton);
            this.AppFilterGroupBox.Controls.Add(this.AllAppsRadioButton);
            this.AppFilterGroupBox.Controls.Add(this.DisabledAppsRadioButton);
            this.AppFilterGroupBox.Controls.Add(this.ThirdPartyAppsRadioButton);
            this.AppFilterGroupBox.Controls.Add(this.EnabledAppsRadioButton);
            this.AppFilterGroupBox.Location = new System.Drawing.Point(6, 237);
            this.AppFilterGroupBox.Name = "AppFilterGroupBox";
            this.AppFilterGroupBox.Size = new System.Drawing.Size(211, 100);
            this.AppFilterGroupBox.TabIndex = 10;
            this.AppFilterGroupBox.TabStop = false;
            this.AppFilterGroupBox.Text = "Filter";
            // 
            // SystemAppsRadioButton
            // 
            this.SystemAppsRadioButton.AutoSize = true;
            this.SystemAppsRadioButton.Location = new System.Drawing.Point(6, 47);
            this.SystemAppsRadioButton.Name = "SystemAppsRadioButton";
            this.SystemAppsRadioButton.Size = new System.Drawing.Size(86, 17);
            this.SystemAppsRadioButton.TabIndex = 5;
            this.SystemAppsRadioButton.Text = "System Apps";
            this.SystemAppsRadioButton.UseVisualStyleBackColor = true;
            this.SystemAppsRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // AllAppsRadioButton
            // 
            this.AllAppsRadioButton.AutoSize = true;
            this.AllAppsRadioButton.Checked = true;
            this.AllAppsRadioButton.Location = new System.Drawing.Point(6, 24);
            this.AllAppsRadioButton.Name = "AllAppsRadioButton";
            this.AllAppsRadioButton.Size = new System.Drawing.Size(63, 17);
            this.AllAppsRadioButton.TabIndex = 9;
            this.AllAppsRadioButton.TabStop = true;
            this.AllAppsRadioButton.Text = "All Apps";
            this.AllAppsRadioButton.UseVisualStyleBackColor = true;
            this.AllAppsRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // DisabledAppsRadioButton
            // 
            this.DisabledAppsRadioButton.AutoSize = true;
            this.DisabledAppsRadioButton.Location = new System.Drawing.Point(115, 72);
            this.DisabledAppsRadioButton.Name = "DisabledAppsRadioButton";
            this.DisabledAppsRadioButton.Size = new System.Drawing.Size(93, 17);
            this.DisabledAppsRadioButton.TabIndex = 6;
            this.DisabledAppsRadioButton.Text = "Disabled Apps";
            this.DisabledAppsRadioButton.UseVisualStyleBackColor = true;
            this.DisabledAppsRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // ThirdPartyAppsRadioButton
            // 
            this.ThirdPartyAppsRadioButton.AutoSize = true;
            this.ThirdPartyAppsRadioButton.Location = new System.Drawing.Point(6, 70);
            this.ThirdPartyAppsRadioButton.Name = "ThirdPartyAppsRadioButton";
            this.ThirdPartyAppsRadioButton.Size = new System.Drawing.Size(103, 17);
            this.ThirdPartyAppsRadioButton.TabIndex = 8;
            this.ThirdPartyAppsRadioButton.Text = "Third Party Apps";
            this.ThirdPartyAppsRadioButton.UseVisualStyleBackColor = true;
            this.ThirdPartyAppsRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // EnabledAppsRadioButton
            // 
            this.EnabledAppsRadioButton.AutoSize = true;
            this.EnabledAppsRadioButton.Location = new System.Drawing.Point(115, 49);
            this.EnabledAppsRadioButton.Name = "EnabledAppsRadioButton";
            this.EnabledAppsRadioButton.Size = new System.Drawing.Size(91, 17);
            this.EnabledAppsRadioButton.TabIndex = 7;
            this.EnabledAppsRadioButton.Text = "Enabled Apps";
            this.EnabledAppsRadioButton.UseVisualStyleBackColor = true;
            this.EnabledAppsRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(56, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(290, 20);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ApplicationsCheckedListBox
            // 
            this.ApplicationsCheckedListBox.FormattingEnabled = true;
            this.ApplicationsCheckedListBox.Location = new System.Drawing.Point(6, 32);
            this.ApplicationsCheckedListBox.Name = "ApplicationsCheckedListBox";
            this.ApplicationsCheckedListBox.Size = new System.Drawing.Size(340, 199);
            this.ApplicationsCheckedListBox.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(271, 255);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Tag = "clear";
            this.ResetButton.Text = "Reset App";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ConsoleTabPage
            // 
            this.ConsoleTabPage.Controls.Add(this.ConsoleOutputTextBox);
            this.ConsoleTabPage.Controls.Add(this.ConsoleInputTextBox);
            this.ConsoleTabPage.Location = new System.Drawing.Point(4, 22);
            this.ConsoleTabPage.Name = "ConsoleTabPage";
            this.ConsoleTabPage.Size = new System.Drawing.Size(352, 342);
            this.ConsoleTabPage.TabIndex = 1;
            this.ConsoleTabPage.Text = "Console";
            this.ConsoleTabPage.UseVisualStyleBackColor = true;
            // 
            // ConsoleOutputTextBox
            // 
            this.ConsoleOutputTextBox.Location = new System.Drawing.Point(3, 29);
            this.ConsoleOutputTextBox.Multiline = true;
            this.ConsoleOutputTextBox.Name = "ConsoleOutputTextBox";
            this.ConsoleOutputTextBox.ReadOnly = true;
            this.ConsoleOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleOutputTextBox.Size = new System.Drawing.Size(346, 310);
            this.ConsoleOutputTextBox.TabIndex = 2;
            this.ConsoleOutputTextBox.Text = "adb shell> ";
            // 
            // ConsoleInputTextBox
            // 
            this.ConsoleInputTextBox.Location = new System.Drawing.Point(3, 3);
            this.ConsoleInputTextBox.Name = "ConsoleInputTextBox";
            this.ConsoleInputTextBox.Size = new System.Drawing.Size(346, 20);
            this.ConsoleInputTextBox.TabIndex = 1;
            this.ConsoleInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsoleInputTextBox_KeyPress);
            // 
            // HelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 392);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 431);
            this.MinimumSize = new System.Drawing.Size(400, 431);
            this.Name = "HelperForm";
            this.ShowInTaskbar = false;
            this.Text = "ADBHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelperForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.ApplicationsTabPage.ResumeLayout(false);
            this.ApplicationsTabPage.PerformLayout();
            this.AppFilterGroupBox.ResumeLayout(false);
            this.AppFilterGroupBox.PerformLayout();
            this.ConsoleTabPage.ResumeLayout(false);
            this.ConsoleTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ApplicationsTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.CheckedListBox ApplicationsCheckedListBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RadioButton SystemAppsRadioButton;
        private System.Windows.Forms.RadioButton ThirdPartyAppsRadioButton;
        private System.Windows.Forms.RadioButton EnabledAppsRadioButton;
        private System.Windows.Forms.RadioButton DisabledAppsRadioButton;
        private System.Windows.Forms.RadioButton AllAppsRadioButton;
        private System.Windows.Forms.GroupBox AppFilterGroupBox;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.Button EnableButton;
        private System.Windows.Forms.TabPage ConsoleTabPage;
        private System.Windows.Forms.TextBox ConsoleInputTextBox;
        private System.Windows.Forms.TextBox ConsoleOutputTextBox;
    }
}