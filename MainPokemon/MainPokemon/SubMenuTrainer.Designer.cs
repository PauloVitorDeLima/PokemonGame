namespace MainPokemon
{
    partial class SubMenuTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuTrainer));
            this.BtRegisterTrainer = new System.Windows.Forms.Button();
            this.BtListTrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtRegisterTrainer
            // 
            this.BtRegisterTrainer.BackColor = System.Drawing.SystemColors.Info;
            this.BtRegisterTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegisterTrainer.Location = new System.Drawing.Point(12, 12);
            this.BtRegisterTrainer.Name = "BtRegisterTrainer";
            this.BtRegisterTrainer.Size = new System.Drawing.Size(172, 52);
            this.BtRegisterTrainer.TabIndex = 4;
            this.BtRegisterTrainer.Text = "CADASTRAR TREINADORES";
            this.BtRegisterTrainer.UseVisualStyleBackColor = false;
            // 
            // BtListTrainer
            // 
            this.BtListTrainer.BackColor = System.Drawing.SystemColors.Info;
            this.BtListTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListTrainer.Location = new System.Drawing.Point(12, 364);
            this.BtListTrainer.Name = "BtListTrainer";
            this.BtListTrainer.Size = new System.Drawing.Size(172, 52);
            this.BtListTrainer.TabIndex = 5;
            this.BtListTrainer.Text = "LISTAR TREINADORES";
            this.BtListTrainer.UseVisualStyleBackColor = false;
            // 
            // SubMenuTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 428);
            this.Controls.Add(this.BtListTrainer);
            this.Controls.Add(this.BtRegisterTrainer);
            this.Name = "SubMenuTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuTrainer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtRegisterTrainer;
        private System.Windows.Forms.Button BtListTrainer;
    }
}