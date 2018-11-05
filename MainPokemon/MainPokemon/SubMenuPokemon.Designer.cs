namespace MainPokemon
{
    partial class SubMenuPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuPokemon));
            this.BtRegisterPokemon = new System.Windows.Forms.Button();
            this.BtListPokemon = new System.Windows.Forms.Button();
            this.BtReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtRegisterPokemon
            // 
            this.BtRegisterPokemon.BackColor = System.Drawing.SystemColors.Info;
            this.BtRegisterPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegisterPokemon.Location = new System.Drawing.Point(12, 12);
            this.BtRegisterPokemon.Name = "BtRegisterPokemon";
            this.BtRegisterPokemon.Size = new System.Drawing.Size(172, 52);
            this.BtRegisterPokemon.TabIndex = 3;
            this.BtRegisterPokemon.Text = "CADASTRAR POKÉMON";
            this.BtRegisterPokemon.UseVisualStyleBackColor = false;
            this.BtRegisterPokemon.Click += new System.EventHandler(this.BtRegisterPokemon_Click);
            // 
            // BtListPokemon
            // 
            this.BtListPokemon.BackColor = System.Drawing.SystemColors.Info;
            this.BtListPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListPokemon.Location = new System.Drawing.Point(12, 125);
            this.BtListPokemon.Name = "BtListPokemon";
            this.BtListPokemon.Size = new System.Drawing.Size(172, 52);
            this.BtListPokemon.TabIndex = 4;
            this.BtListPokemon.Text = "LISTAR POKÉMONS";
            this.BtListPokemon.UseVisualStyleBackColor = false;
            // 
            // BtReturn
            // 
            this.BtReturn.BackColor = System.Drawing.SystemColors.Info;
            this.BtReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReturn.Location = new System.Drawing.Point(12, 242);
            this.BtReturn.Name = "BtReturn";
            this.BtReturn.Size = new System.Drawing.Size(172, 52);
            this.BtReturn.TabIndex = 5;
            this.BtReturn.Text = "VOLTAR";
            this.BtReturn.UseVisualStyleBackColor = false;
            this.BtReturn.Click += new System.EventHandler(this.BtReturn_Click);
            // 
            // SubMenuPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 516);
            this.Controls.Add(this.BtReturn);
            this.Controls.Add(this.BtListPokemon);
            this.Controls.Add(this.BtRegisterPokemon);
            this.Name = "SubMenuPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuPokemon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtRegisterPokemon;
        private System.Windows.Forms.Button BtListPokemon;
        private System.Windows.Forms.Button BtReturn;
    }
}