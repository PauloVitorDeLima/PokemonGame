namespace MainPokemon
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BtTrainer = new System.Windows.Forms.Button();
            this.BtPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtTrainer
            // 
            this.BtTrainer.BackColor = System.Drawing.SystemColors.Info;
            this.BtTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTrainer.Location = new System.Drawing.Point(453, 125);
            this.BtTrainer.Name = "BtTrainer";
            this.BtTrainer.Size = new System.Drawing.Size(172, 52);
            this.BtTrainer.TabIndex = 4;
            this.BtTrainer.Text = "ÁREA DO TREINADOR";
            this.BtTrainer.UseVisualStyleBackColor = false;
            this.BtTrainer.Click += new System.EventHandler(this.BtTrainer_Click);
            // 
            // BtPokemon
            // 
            this.BtPokemon.BackColor = System.Drawing.SystemColors.Info;
            this.BtPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPokemon.Location = new System.Drawing.Point(70, 125);
            this.BtPokemon.Name = "BtPokemon";
            this.BtPokemon.Size = new System.Drawing.Size(172, 52);
            this.BtPokemon.TabIndex = 3;
            this.BtPokemon.Text = "ÁREA DO POKÉMON";
            this.BtPokemon.UseVisualStyleBackColor = false;
            this.BtPokemon.Click += new System.EventHandler(this.BtPokemon_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 263);
            this.Controls.Add(this.BtTrainer);
            this.Controls.Add(this.BtPokemon);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtTrainer;
        private System.Windows.Forms.Button BtPokemon;
    }
}