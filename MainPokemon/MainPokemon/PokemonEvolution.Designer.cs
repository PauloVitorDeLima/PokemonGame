namespace MainPokemon
{
    partial class PokemonEvolution
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
            this.components = new System.ComponentModel.Container();
            this.TxtBxLogin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbTime = new System.Windows.Forms.Label();
            this.TimerEvolution = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TxtBxLogin
            // 
            this.TxtBxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxLogin.Location = new System.Drawing.Point(370, 12);
            this.TxtBxLogin.Name = "TxtBxLogin";
            this.TxtBxLogin.Size = new System.Drawing.Size(253, 29);
            this.TxtBxLogin.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(242, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 29);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "EVOLUINDO:";
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.BackColor = System.Drawing.SystemColors.Control;
            this.LbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.Location = new System.Drawing.Point(686, 55);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(103, 37);
            this.LbTime.TabIndex = 16;
            this.LbTime.Text = "00:00";
            // 
            // TimerEvolution
            // 
            this.TimerEvolution.Interval = 1000;
            this.TimerEvolution.Tick += new System.EventHandler(this.TimerEvolution_Tick);
            // 
            // PokemonEvolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainPokemon.Properties.Resources.Pokémons;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 319);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.TxtBxLogin);
            this.Controls.Add(this.textBox1);
            this.Name = "PokemonEvolution";
            this.Text = "PokemonEvolution";
            this.Load += new System.EventHandler(this.PokemonEvolution_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Timer TimerEvolution;
    }
}