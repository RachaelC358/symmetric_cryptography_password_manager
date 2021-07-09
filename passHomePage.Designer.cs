
namespace CarpenterPass
{
    partial class passHomePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.storePasswordOptionButton = new System.Windows.Forms.Button();
            this.retreivePasswordsOptionButton = new System.Windows.Forms.Button();
            this.quitProgramOptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your home page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do today?";
            // 
            // storePasswordOptionButton
            // 
            this.storePasswordOptionButton.Location = new System.Drawing.Point(83, 209);
            this.storePasswordOptionButton.Name = "storePasswordOptionButton";
            this.storePasswordOptionButton.Size = new System.Drawing.Size(129, 23);
            this.storePasswordOptionButton.TabIndex = 2;
            this.storePasswordOptionButton.Text = "Store a new password";
            this.storePasswordOptionButton.UseVisualStyleBackColor = true;
            this.storePasswordOptionButton.Click += new System.EventHandler(this.storePasswordOptionButton_Click);
            // 
            // retreivePasswordsOptionButton
            // 
            this.retreivePasswordsOptionButton.Location = new System.Drawing.Point(233, 209);
            this.retreivePasswordsOptionButton.Name = "retreivePasswordsOptionButton";
            this.retreivePasswordsOptionButton.Size = new System.Drawing.Size(120, 23);
            this.retreivePasswordsOptionButton.TabIndex = 3;
            this.retreivePasswordsOptionButton.Text = "Retreive passwords";
            this.retreivePasswordsOptionButton.UseVisualStyleBackColor = true;
            // 
            // quitProgramOptionButton
            // 
            this.quitProgramOptionButton.Location = new System.Drawing.Point(182, 331);
            this.quitProgramOptionButton.Name = "quitProgramOptionButton";
            this.quitProgramOptionButton.Size = new System.Drawing.Size(75, 23);
            this.quitProgramOptionButton.TabIndex = 4;
            this.quitProgramOptionButton.Text = "Quit program";
            this.quitProgramOptionButton.UseVisualStyleBackColor = true;
            // 
            // passHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.quitProgramOptionButton);
            this.Controls.Add(this.retreivePasswordsOptionButton);
            this.Controls.Add(this.storePasswordOptionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "passHomePage";
            this.Text = "passHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button storePasswordOptionButton;
        private System.Windows.Forms.Button retreivePasswordsOptionButton;
        private System.Windows.Forms.Button quitProgramOptionButton;
    }
}