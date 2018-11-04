namespace MainPokemon
{
    partial class LoginTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTrainer));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtLogin = new System.Windows.Forms.Button();
            this.BtRegister = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtBxLogin = new System.Windows.Forms.TextBox();
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "LOGIN:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtLogin
            // 
            this.BtLogin.BackColor = System.Drawing.SystemColors.Info;
            this.BtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.Location = new System.Drawing.Point(37, 251);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(172, 52);
            this.BtLogin.TabIndex = 4;
            this.BtLogin.Text = "LOGIN";
            this.BtLogin.UseVisualStyleBackColor = false;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // BtRegister
            // 
            this.BtRegister.BackColor = System.Drawing.SystemColors.Info;
            this.BtRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegister.Location = new System.Drawing.Point(237, 251);
            this.BtRegister.Name = "BtRegister";
            this.BtRegister.Size = new System.Drawing.Size(172, 52);
            this.BtRegister.TabIndex = 5;
            this.BtRegister.Text = "CADASTRAR";
            this.BtRegister.UseVisualStyleBackColor = false;
            this.BtRegister.Click += new System.EventHandler(this.BtRegister_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(37, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 29);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "SENHA:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtBxLogin
            // 
            this.TxtBxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxLogin.Location = new System.Drawing.Point(116, 90);
            this.TxtBxLogin.Name = "TxtBxLogin";
            this.TxtBxLogin.Size = new System.Drawing.Size(293, 29);
            this.TxtBxLogin.TabIndex = 7;
            this.TxtBxLogin.TextChanged += new System.EventHandler(this.TxtBxLogin_TextChanged);
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPassword.Location = new System.Drawing.Point(116, 157);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.PasswordChar = '*';
            this.TxtBxPassword.Size = new System.Drawing.Size(293, 29);
            this.TxtBxPassword.TabIndex = 8;
            this.TxtBxPassword.TextChanged += new System.EventHandler(this.TxtBxPassword_TextChanged);
            // 
            // LoginTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(441, 327);
            this.Controls.Add(this.TxtBxPassword);
            this.Controls.Add(this.TxtBxLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtRegister);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.textBox1);
            this.Name = "LoginTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Button BtRegister;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtBxLogin;
        private System.Windows.Forms.TextBox TxtBxPassword;
    }
}

