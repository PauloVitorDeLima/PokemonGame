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
            this.components = new System.ComponentModel.Container();
            this.BtListTrainer = new System.Windows.Forms.Button();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.TxtBxSearch = new System.Windows.Forms.TextBox();
            this.TxtBx = new System.Windows.Forms.TextBox();
            this.DataGridViewPokemons = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.evoluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.TimerEvolution = new System.Windows.Forms.Timer(this.components);
            this.LbTime = new System.Windows.Forms.Label();
            this.TxtBxEvolution = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPokemons)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // BtListTrainer
            // 
            this.BtListTrainer.BackColor = System.Drawing.SystemColors.Info;
            this.BtListTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListTrainer.Location = new System.Drawing.Point(12, 12);
            this.BtListTrainer.Name = "BtListTrainer";
            this.BtListTrainer.Size = new System.Drawing.Size(172, 52);
            this.BtListTrainer.TabIndex = 5;
            this.BtListTrainer.Text = "LISTAR POKEMÓNS";
            this.BtListTrainer.UseVisualStyleBackColor = false;
            this.BtListTrainer.Click += new System.EventHandler(this.BtListTrainer_Click);
            // 
            // BtVoltar
            // 
            this.BtVoltar.BackColor = System.Drawing.SystemColors.Info;
            this.BtVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVoltar.Location = new System.Drawing.Point(12, 415);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(172, 52);
            this.BtVoltar.TabIndex = 6;
            this.BtVoltar.Text = "VOLTAR";
            this.BtVoltar.UseVisualStyleBackColor = false;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // TxtBxSearch
            // 
            this.TxtBxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSearch.Location = new System.Drawing.Point(338, 12);
            this.TxtBxSearch.Name = "TxtBxSearch";
            this.TxtBxSearch.Size = new System.Drawing.Size(513, 29);
            this.TxtBxSearch.TabIndex = 29;
            this.TxtBxSearch.Visible = false;
            this.TxtBxSearch.TextChanged += new System.EventHandler(this.TxtBxSearch_TextChanged);
            // 
            // TxtBx
            // 
            this.TxtBx.Enabled = false;
            this.TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx.Location = new System.Drawing.Point(211, 12);
            this.TxtBx.Name = "TxtBx";
            this.TxtBx.ReadOnly = true;
            this.TxtBx.Size = new System.Drawing.Size(462, 29);
            this.TxtBx.TabIndex = 28;
            this.TxtBx.Text = "PESQUISAR:";
            this.TxtBx.Visible = false;
            // 
            // DataGridViewPokemons
            // 
            this.DataGridViewPokemons.AllowUserToAddRows = false;
            this.DataGridViewPokemons.AllowUserToDeleteRows = false;
            this.DataGridViewPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPokemons.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridViewPokemons.Location = new System.Drawing.Point(211, 57);
            this.DataGridViewPokemons.Name = "DataGridViewPokemons";
            this.DataGridViewPokemons.ReadOnly = true;
            this.DataGridViewPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPokemons.Size = new System.Drawing.Size(646, 410);
            this.DataGridViewPokemons.TabIndex = 26;
            this.DataGridViewPokemons.Visible = false;
            this.DataGridViewPokemons.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPokemons_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evoluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // evoluirToolStripMenuItem
            // 
            this.evoluirToolStripMenuItem.Name = "evoluirToolStripMenuItem";
            this.evoluirToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.evoluirToolStripMenuItem.Text = "Evoluir";
            this.evoluirToolStripMenuItem.Click += new System.EventHandler(this.evoluirToolStripMenuItem_Click);
            // 
            // PictureBoxPokemon
            // 
            this.PictureBoxPokemon.Location = new System.Drawing.Point(12, 136);
            this.PictureBoxPokemon.Name = "PictureBoxPokemon";
            this.PictureBoxPokemon.Size = new System.Drawing.Size(172, 212);
            this.PictureBoxPokemon.TabIndex = 25;
            this.PictureBoxPokemon.TabStop = false;
            this.PictureBoxPokemon.Visible = false;
            // 
            // TimerEvolution
            // 
            this.TimerEvolution.Interval = 1000;
            this.TimerEvolution.Tick += new System.EventHandler(this.TimerEvolution_Tick);
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.BackColor = System.Drawing.SystemColors.Control;
            this.LbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.Location = new System.Drawing.Point(748, 493);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(103, 37);
            this.LbTime.TabIndex = 30;
            this.LbTime.Text = "00:00";
            this.LbTime.Visible = false;
            this.LbTime.Click += new System.EventHandler(this.LbTime_Click);
            // 
            // TxtBxEvolution
            // 
            this.TxtBxEvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEvolution.Location = new System.Drawing.Point(181, 501);
            this.TxtBxEvolution.Name = "TxtBxEvolution";
            this.TxtBxEvolution.ReadOnly = true;
            this.TxtBxEvolution.Size = new System.Drawing.Size(513, 29);
            this.TxtBxEvolution.TabIndex = 32;
            this.TxtBxEvolution.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(61, 501);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 29);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "EVOLUINDO:";
            this.textBox2.Visible = false;
            // 
            // SubMenuTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainPokemon.Properties.Resources.Pókemons3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 554);
            this.Controls.Add(this.TxtBxEvolution);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.TxtBxSearch);
            this.Controls.Add(this.TxtBx);
            this.Controls.Add(this.DataGridViewPokemons);
            this.Controls.Add(this.PictureBoxPokemon);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.BtListTrainer);
            this.Name = "SubMenuTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuTrainer";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPokemons)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtListTrainer;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.TextBox TxtBxSearch;
        private System.Windows.Forms.TextBox TxtBx;
        private System.Windows.Forms.DataGridView DataGridViewPokemons;
        private System.Windows.Forms.PictureBox PictureBoxPokemon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evoluirToolStripMenuItem;
        private System.Windows.Forms.Timer TimerEvolution;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.TextBox TxtBxEvolution;
        private System.Windows.Forms.TextBox textBox2;
    }
}