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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.DataGridViewPokemons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPokemons)).BeginInit();
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
            this.BtListPokemon.Click += new System.EventHandler(this.BtListPokemon_Click);
            // 
            // BtReturn
            // 
            this.BtReturn.BackColor = System.Drawing.SystemColors.Info;
            this.BtReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReturn.Location = new System.Drawing.Point(12, 452);
            this.BtReturn.Name = "BtReturn";
            this.BtReturn.Size = new System.Drawing.Size(172, 52);
            this.BtReturn.TabIndex = 5;
            this.BtReturn.Text = "VOLTAR";
            this.BtReturn.UseVisualStyleBackColor = false;
            this.BtReturn.Click += new System.EventHandler(this.BtReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBoxPokemon
            // 
            this.PictureBoxPokemon.Location = new System.Drawing.Point(12, 208);
            this.PictureBoxPokemon.Name = "PictureBoxPokemon";
            this.PictureBoxPokemon.Size = new System.Drawing.Size(172, 212);
            this.PictureBoxPokemon.TabIndex = 7;
            this.PictureBoxPokemon.TabStop = false;
            this.PictureBoxPokemon.Visible = false;
            // 
            // DataGridViewPokemons
            // 
            this.DataGridViewPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPokemons.Location = new System.Drawing.Point(205, 61);
            this.DataGridViewPokemons.Name = "DataGridViewPokemons";
            this.DataGridViewPokemons.Size = new System.Drawing.Size(617, 443);
            this.DataGridViewPokemons.TabIndex = 8;
            this.DataGridViewPokemons.Visible = false;
            // 
            // SubMenuPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 516);
            this.Controls.Add(this.DataGridViewPokemons);
            this.Controls.Add(this.PictureBoxPokemon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtReturn);
            this.Controls.Add(this.BtListPokemon);
            this.Controls.Add(this.BtRegisterPokemon);
            this.Name = "SubMenuPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPokemons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtRegisterPokemon;
        private System.Windows.Forms.Button BtListPokemon;
        private System.Windows.Forms.Button BtReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureBoxPokemon;
        private System.Windows.Forms.DataGridView DataGridViewPokemons;
    }
}