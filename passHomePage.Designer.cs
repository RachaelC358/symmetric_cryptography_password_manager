
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputComPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.Label();
            this.inputService = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your home page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do today?";
            // 
            // storePasswordOptionButton
            // 
            this.storePasswordOptionButton.Location = new System.Drawing.Point(34, 202);
            this.storePasswordOptionButton.Name = "storePasswordOptionButton";
            this.storePasswordOptionButton.Size = new System.Drawing.Size(129, 23);
            this.storePasswordOptionButton.TabIndex = 2;
            this.storePasswordOptionButton.Text = "Store a new password";
            this.storePasswordOptionButton.UseVisualStyleBackColor = true;
            this.storePasswordOptionButton.Click += new System.EventHandler(this.storePasswordOptionButton_Click);
            // 
            // retreivePasswordsOptionButton
            // 
            this.retreivePasswordsOptionButton.Location = new System.Drawing.Point(39, 202);
            this.retreivePasswordsOptionButton.Name = "retreivePasswordsOptionButton";
            this.retreivePasswordsOptionButton.Size = new System.Drawing.Size(120, 23);
            this.retreivePasswordsOptionButton.TabIndex = 3;
            this.retreivePasswordsOptionButton.Text = "Retreive password";
            this.retreivePasswordsOptionButton.UseVisualStyleBackColor = true;
            // 
            // quitProgramOptionButton
            // 
            this.quitProgramOptionButton.Location = new System.Drawing.Point(247, 352);
            this.quitProgramOptionButton.Name = "quitProgramOptionButton";
            this.quitProgramOptionButton.Size = new System.Drawing.Size(75, 23);
            this.quitProgramOptionButton.TabIndex = 4;
            this.quitProgramOptionButton.Text = "Quit program";
            this.quitProgramOptionButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.inputComPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputPass);
            this.panel1.Controls.Add(this.inputPassword);
            this.panel1.Controls.Add(this.inputService);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.storePasswordOptionButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 239);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.retreivePasswordsOptionButton);
            this.panel2.Location = new System.Drawing.Point(247, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 239);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add new passwords here.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Retreive passwords here.";
            // 
            // inputComPass
            // 
            this.inputComPass.Location = new System.Drawing.Point(47, 163);
            this.inputComPass.Name = "inputComPass";
            this.inputComPass.PasswordChar = '•';
            this.inputComPass.Size = new System.Drawing.Size(100, 20);
            this.inputComPass.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirm Password";
            // 
            // inputPass
            // 
            this.inputPass.Location = new System.Drawing.Point(47, 106);
            this.inputPass.Name = "inputPass";
            this.inputPass.PasswordChar = '•';
            this.inputPass.Size = new System.Drawing.Size(100, 20);
            this.inputPass.TabIndex = 12;
            // 
            // inputPassword
            // 
            this.inputPassword.AutoSize = true;
            this.inputPassword.Location = new System.Drawing.Point(47, 90);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(53, 13);
            this.inputPassword.TabIndex = 11;
            this.inputPassword.Text = "Password";
            // 
            // inputService
            // 
            this.inputService.Location = new System.Drawing.Point(47, 48);
            this.inputService.Name = "inputService";
            this.inputService.Size = new System.Drawing.Size(100, 20);
            this.inputService.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name of Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Select a service to retreive it\'s password.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(42, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(42, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Reveal password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // passHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quitProgramOptionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "passHomePage";
            this.Text = "passHomePage";
            this.Load += new System.EventHandler(this.passHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button storePasswordOptionButton;
        private System.Windows.Forms.Button retreivePasswordsOptionButton;
        private System.Windows.Forms.Button quitProgramOptionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputComPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.Label inputPassword;
        private System.Windows.Forms.TextBox inputService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}