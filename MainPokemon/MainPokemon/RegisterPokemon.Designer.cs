﻿namespace MainPokemon
{
    partial class RegisterPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPokemon));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MskTxtBxHeight = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtBxWeight = new System.Windows.Forms.MaskedTextBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.BtRegisterPokemon = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.MskTxtBxForce = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtBxEffect = new System.Windows.Forms.MaskedTextBox();
            this.PictureBxImage = new System.Windows.Forms.PictureBox();
            this.BtImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(68, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(326, 29);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "PESO:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(68, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(326, 29);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "ALTURA:";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(68, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(326, 29);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "FORÇA:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(68, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 29);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "NOME:";
            // 
            // MskTxtBxHeight
            // 
            this.MskTxtBxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtBxHeight.Location = new System.Drawing.Point(160, 56);
            this.MskTxtBxHeight.Name = "MskTxtBxHeight";
            this.MskTxtBxHeight.Size = new System.Drawing.Size(234, 29);
            this.MskTxtBxHeight.TabIndex = 17;
            this.MskTxtBxHeight.ValidatingType = typeof(int);
            this.MskTxtBxHeight.TextChanged += new System.EventHandler(this.MskTxtBxHeight_TextChanged);
            // 
            // MskTxtBxWeight
            // 
            this.MskTxtBxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtBxWeight.Location = new System.Drawing.Point(160, 91);
            this.MskTxtBxWeight.Name = "MskTxtBxWeight";
            this.MskTxtBxWeight.Size = new System.Drawing.Size(234, 29);
            this.MskTxtBxWeight.TabIndex = 18;
            this.MskTxtBxWeight.TextChanged += new System.EventHandler(this.MskTxtBxWeight_TextChanged);
            // 
            // TxtBxName
            // 
            this.TxtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(160, 21);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(234, 29);
            this.TxtBxName.TabIndex = 19;
            // 
            // BtRegisterPokemon
            // 
            this.BtRegisterPokemon.BackColor = System.Drawing.SystemColors.Info;
            this.BtRegisterPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegisterPokemon.Location = new System.Drawing.Point(12, 432);
            this.BtRegisterPokemon.Name = "BtRegisterPokemon";
            this.BtRegisterPokemon.Size = new System.Drawing.Size(172, 52);
            this.BtRegisterPokemon.TabIndex = 21;
            this.BtRegisterPokemon.Text = "CADASTRAR POKÉMON";
            this.BtRegisterPokemon.UseVisualStyleBackColor = false;
            this.BtRegisterPokemon.Click += new System.EventHandler(this.BtRegisterPokemon_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.BackColor = System.Drawing.SystemColors.Info;
            this.BtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancel.Location = new System.Drawing.Point(222, 432);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(172, 52);
            this.BtCancel.TabIndex = 22;
            this.BtCancel.Text = "CANCELAR";
            this.BtCancel.UseVisualStyleBackColor = false;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(68, 161);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(326, 29);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "EFEITO:";
            // 
            // MskTxtBxForce
            // 
            this.MskTxtBxForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtBxForce.Location = new System.Drawing.Point(160, 126);
            this.MskTxtBxForce.Name = "MskTxtBxForce";
            this.MskTxtBxForce.ReadOnly = true;
            this.MskTxtBxForce.Size = new System.Drawing.Size(234, 29);
            this.MskTxtBxForce.TabIndex = 24;
            // 
            // MskTxtBxEffect
            // 
            this.MskTxtBxEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtBxEffect.Location = new System.Drawing.Point(160, 161);
            this.MskTxtBxEffect.Name = "MskTxtBxEffect";
            this.MskTxtBxEffect.ReadOnly = true;
            this.MskTxtBxEffect.Size = new System.Drawing.Size(234, 29);
            this.MskTxtBxEffect.TabIndex = 25;
            // 
            // PictureBxImage
            // 
            this.PictureBxImage.Location = new System.Drawing.Point(190, 223);
            this.PictureBxImage.Name = "PictureBxImage";
            this.PictureBxImage.Size = new System.Drawing.Size(204, 175);
            this.PictureBxImage.TabIndex = 26;
            this.PictureBxImage.TabStop = false;
            // 
            // BtImage
            // 
            this.BtImage.BackColor = System.Drawing.SystemColors.Info;
            this.BtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtImage.Location = new System.Drawing.Point(12, 274);
            this.BtImage.Name = "BtImage";
            this.BtImage.Size = new System.Drawing.Size(172, 52);
            this.BtImage.TabIndex = 27;
            this.BtImage.Text = "BUSCAR IMAGEM";
            this.BtImage.UseVisualStyleBackColor = false;
            this.BtImage.Click += new System.EventHandler(this.BtImage_Click);
            // 
            // RegisterPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 496);
            this.Controls.Add(this.BtImage);
            this.Controls.Add(this.PictureBxImage);
            this.Controls.Add(this.MskTxtBxEffect);
            this.Controls.Add(this.MskTxtBxForce);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtRegisterPokemon);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.MskTxtBxWeight);
            this.Controls.Add(this.MskTxtBxHeight);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "RegisterPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPokemon";
            this.Load += new System.EventHandler(this.RegisterPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox MskTxtBxHeight;
        private System.Windows.Forms.MaskedTextBox MskTxtBxWeight;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Button BtRegisterPokemon;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.MaskedTextBox MskTxtBxForce;
        private System.Windows.Forms.MaskedTextBox MskTxtBxEffect;
        private System.Windows.Forms.PictureBox PictureBxImage;
        private System.Windows.Forms.Button BtImage;
    }
}