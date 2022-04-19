
namespace ADBHelper
{
    partial class ConnectionForm
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
            this.InstructionsTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionsTextBox
            // 
            this.InstructionsTextBox.Location = new System.Drawing.Point(12, 12);
            this.InstructionsTextBox.Multiline = true;
            this.InstructionsTextBox.Name = "InstructionsTextBox";
            this.InstructionsTextBox.ReadOnly = true;
            this.InstructionsTextBox.Size = new System.Drawing.Size(310, 60);
            this.InstructionsTextBox.TabIndex = 1;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(247, 78);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 0;
            this.NextButton.Tag = "";
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 116);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.InstructionsTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 155);
            this.MinimumSize = new System.Drawing.Size(350, 155);
            this.Name = "ConnectionForm";
            this.Text = "Initialize Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InstructionsTextBox;
        private System.Windows.Forms.Button NextButton;
    }
}

