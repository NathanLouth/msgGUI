
namespace msgGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ComputerNameTxT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTxT = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsersTxT = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Name";
            // 
            // ComputerNameTxT
            // 
            this.ComputerNameTxT.Location = new System.Drawing.Point(12, 27);
            this.ComputerNameTxT.Name = "ComputerNameTxT";
            this.ComputerNameTxT.Size = new System.Drawing.Size(300, 23);
            this.ComputerNameTxT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // MessageTxT
            // 
            this.MessageTxT.Location = new System.Drawing.Point(12, 140);
            this.MessageTxT.Name = "MessageTxT";
            this.MessageTxT.Size = new System.Drawing.Size(300, 96);
            this.MessageTxT.TabIndex = 4;
            this.MessageTxT.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Users";
            // 
            // UsersTxT
            // 
            this.UsersTxT.Location = new System.Drawing.Point(12, 84);
            this.UsersTxT.Name = "UsersTxT";
            this.UsersTxT.Size = new System.Drawing.Size(301, 23);
            this.UsersTxT.TabIndex = 6;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(231, 297);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(81, 28);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(13, 297);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(81, 28);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 337);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.UsersTxT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MessageTxT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComputerNameTxT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ComputerNameTxT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MessageTxT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsersTxT;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

