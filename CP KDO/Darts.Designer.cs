namespace CP_KDO
{
    partial class Darts
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Darts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.player1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.граToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.початиНовуГруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розробникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.розробникToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.curPl1 = new System.Windows.Forms.Label();
            this.curPl2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.queryPl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hits = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.greetings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.player1,
            this.field,
            this.player2});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(11, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // player1
            // 
            this.player1.HeaderText = "Player_1";
            this.player1.Name = "player1";
            this.player1.ReadOnly = true;
            // 
            // field
            // 
            this.field.HeaderText = "Поле";
            this.field.Name = "field";
            this.field.ReadOnly = true;
            // 
            // player2
            // 
            this.player2.HeaderText = "Player_2";
            this.player2.Name = "player2";
            this.player2.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.граToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.проПрограмуToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // граToolStripMenuItem
            // 
            this.граToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.початиНовуГруToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.завантажитиToolStripMenuItem,
            this.toolStripSeparator1,
            this.вихідToolStripMenuItem});
            this.граToolStripMenuItem.Name = "граToolStripMenuItem";
            this.граToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.граToolStripMenuItem.Text = "Game";
            // 
            // початиНовуГруToolStripMenuItem
            // 
            this.початиНовуГруToolStripMenuItem.Name = "початиНовуГруToolStripMenuItem";
            this.початиНовуГруToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.початиНовуГруToolStripMenuItem.Text = "New Game";
            this.початиНовуГруToolStripMenuItem.Click += new System.EventHandler(this.початиНовуГруToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.зберегтиToolStripMenuItem.Text = "Save";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.завантажитиToolStripMenuItem.Text = "Load";
            this.завантажитиToolStripMenuItem.Click += new System.EventHandler(this.завантажитиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.вихідToolStripMenuItem.Text = "Quit";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розробникToolStripMenuItem});
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.проПрограмуToolStripMenuItem.Text = "Rules";
            // 
            // розробникToolStripMenuItem
            // 
            this.розробникToolStripMenuItem.Name = "розробникToolStripMenuItem";
            this.розробникToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.розробникToolStripMenuItem.Text = "Show Rules";
            this.розробникToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem1
            // 
            this.проПрограмуToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розробникToolStripMenuItem1});
            this.проПрограмуToolStripMenuItem1.Name = "проПрограмуToolStripMenuItem1";
            this.проПрограмуToolStripMenuItem1.Size = new System.Drawing.Size(105, 24);
            this.проПрограмуToolStripMenuItem1.Text = "About Game";
            // 
            // розробникToolStripMenuItem1
            // 
            this.розробникToolStripMenuItem1.Name = "розробникToolStripMenuItem1";
            this.розробникToolStripMenuItem1.Size = new System.Drawing.Size(153, 26);
            this.розробникToolStripMenuItem1.Text = "Developer";
            this.розробникToolStripMenuItem1.Click += new System.EventHandler(this.розробникToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Перший гравець:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(301, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Другий гравець:";
            this.label2.Visible = false;
            // 
            // curPl1
            // 
            this.curPl1.AutoSize = true;
            this.curPl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.curPl1.Location = new System.Drawing.Point(32, 256);
            this.curPl1.Name = "curPl1";
            this.curPl1.Size = new System.Drawing.Size(107, 29);
            this.curPl1.TabIndex = 3;
            this.curPl1.Text = "Player_1";
            this.curPl1.Visible = false;
            // 
            // curPl2
            // 
            this.curPl2.AutoSize = true;
            this.curPl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.curPl2.Location = new System.Drawing.Point(301, 256);
            this.curPl2.Name = "curPl2";
            this.curPl2.Size = new System.Drawing.Size(107, 29);
            this.curPl2.TabIndex = 3;
            this.curPl2.Text = "Player_2";
            this.curPl2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Черга гравця:";
            this.label7.Visible = false;
            // 
            // queryPl
            // 
            this.queryPl.AutoSize = true;
            this.queryPl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.queryPl.Location = new System.Drawing.Point(301, 76);
            this.queryPl.Name = "queryPl";
            this.queryPl.Size = new System.Drawing.Size(0, 29);
            this.queryPl.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(33, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Залишилося кидкiв:";
            this.label9.Visible = false;
            // 
            // hits
            // 
            this.hits.AutoSize = true;
            this.hits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hits.Location = new System.Drawing.Point(301, 108);
            this.hits.Name = "hits";
            this.hits.Size = new System.Drawing.Size(0, 29);
            this.hits.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(172, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Рахунок:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(187, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "0 : 0";
            this.label6.Visible = false;
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.greetings.Location = new System.Drawing.Point(7, 137);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(465, 60);
            this.greetings.TabIndex = 11;
            this.greetings.Text = "                 Вітаю Вас у грі Darts Cricket\r\nОберіть в меню \'New Game\', щоб по" +
    "чати нову гру\r\n       або \'Load\', щоб завантажити попередню";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CP_KDO.Properties.Resources.Grapes;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(485, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 703);
            this.panel1.TabIndex = 6;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // Darts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1263, 706);
            this.Controls.Add(this.greetings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.curPl2);
            this.Controls.Add(this.hits);
            this.Controls.Add(this.queryPl);
            this.Controls.Add(this.curPl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Darts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Darts Cricket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem граToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem початиНовуГруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розробникToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label curPl1;
        private System.Windows.Forms.Label curPl2;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem розробникToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label queryPl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label hits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn player1;
        private System.Windows.Forms.DataGridViewTextBoxColumn field;
        private System.Windows.Forms.DataGridViewTextBoxColumn player2;
        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

