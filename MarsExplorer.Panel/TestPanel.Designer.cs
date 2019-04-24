namespace MarsExplorer.Panel
{
    partial class TestPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.txtCommadPanel = new System.Windows.Forms.RichTextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rovers Positions :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Message To Mars :";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(253, 43);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(197, 169);
            this.txtResults.TabIndex = 8;
            this.txtResults.Text = "";
            // 
            // txtCommadPanel
            // 
            this.txtCommadPanel.Location = new System.Drawing.Point(24, 43);
            this.txtCommadPanel.Name = "txtCommadPanel";
            this.txtCommadPanel.Size = new System.Drawing.Size(197, 169);
            this.txtCommadPanel.TabIndex = 7;
            this.txtCommadPanel.Text = "";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(24, 218);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(197, 23);
            this.btnSendCommand.TabIndex = 6;
            this.btnSendCommand.Text = "Send Command";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // TestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtCommadPanel);
            this.Controls.Add(this.btnSendCommand);
            this.Name = "TestPanel";
            this.Text = "Test Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.RichTextBox txtCommadPanel;
        private System.Windows.Forms.Button btnSendCommand;
    }
}