namespace CP_KDO
{
    partial class Load
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.canc = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameSc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl1sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl2sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.gameSc,
            this.pl1,
            this.pl1sc,
            this.pl2,
            this.pl2sc});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // canc
            // 
            this.canc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.canc.Location = new System.Drawing.Point(520, 343);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(188, 34);
            this.canc.TabIndex = 7;
            this.canc.Text = "Скасувати";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(142, 343);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(188, 34);
            this.loading.TabIndex = 6;
            this.loading.Text = "Завантажити";
            this.loading.UseVisualStyleBackColor = true;
            this.loading.Click += new System.EventHandler(this.loading_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть рядок з бажаною грою та натисніть \'Завантажити\'";
            // 
            // num
            // 
            this.num.HeaderText = "№";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 30;
            // 
            // gameSc
            // 
            this.gameSc.HeaderText = "Game Score";
            this.gameSc.Name = "gameSc";
            this.gameSc.ReadOnly = true;
            this.gameSc.Width = 60;
            // 
            // pl1
            // 
            this.pl1.HeaderText = "Player 1";
            this.pl1.Name = "pl1";
            this.pl1.ReadOnly = true;
            this.pl1.Width = 200;
            // 
            // pl1sc
            // 
            this.pl1sc.HeaderText = "Player 1 Score";
            this.pl1sc.Name = "pl1sc";
            this.pl1sc.ReadOnly = true;
            this.pl1sc.Width = 50;
            // 
            // pl2
            // 
            this.pl2.HeaderText = "Player 2";
            this.pl2.Name = "pl2";
            this.pl2.ReadOnly = true;
            this.pl2.Width = 200;
            // 
            // pl2sc
            // 
            this.pl2sc.HeaderText = "Player 2 Score";
            this.pl2sc.Name = "pl2sc";
            this.pl2sc.ReadOnly = true;
            this.pl2sc.Width = 50;
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(869, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canc);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Load";
            this.Text = "Load Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Load_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button canc;
        private System.Windows.Forms.Button loading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameSc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pl1sc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pl2sc;
    }
}