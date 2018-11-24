namespace MainPokemon
{
    partial class RegisterTrainer
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
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.TxtBxLogin = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtRegister = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPassword.Location = new System.Drawing.Point(159, 120);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.PasswordChar = '*';
            this.TxtBxPassword.Size = new System.Drawing.Size(293, 29);
            this.TxtBxPassword.TabIndex = 14;
            // 
            // TxtBxLogin
            // 
            this.TxtBxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxLogin.Location = new System.Drawing.Point(159, 53);
            this.TxtBxLogin.Name = "TxtBxLogin";
            this.TxtBxLogin.Size = new System.Drawing.Size(293, 29);
            this.TxtBxLogin.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(80, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 29);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "SENHA:";
            // 
            // BtRegister
            // 
            this.BtRegister.BackColor = System.Drawing.SystemColors.Info;
            this.BtRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegister.Location = new System.Drawing.Point(80, 219);
            this.BtRegister.Name = "BtRegister";
            this.BtRegister.Size = new System.Drawing.Size(172, 52);
            this.BtRegister.TabIndex = 11;
            this.BtRegister.Text = "CADASTRAR";
            this.BtRegister.UseVisualStyleBackColor = false;
            this.BtRegister.Click += new System.EventHandler(this.BtRegister_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.BackColor = System.Drawing.SystemColors.Info;
            this.BtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancel.Location = new System.Drawing.Point(280, 219);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(172, 52);
            this.BtCancel.TabIndex = 10;
            this.BtCancel.Text = "CANCELAR";
            this.BtCancel.UseVisualStyleBackColor = false;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 29);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "LOGIN:";
            // 
            // RegisterTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainPokemon.Properties.Resources.Pokémons2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 319);
            this.Controls.Add(this.TxtBxPassword);
            this.Controls.Add(this.TxtBxLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtRegister);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.textBox1);
            this.Name = "RegisterTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterTrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.TextBox TxtBxLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtRegister;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.TextBox textBox1;
    }
}