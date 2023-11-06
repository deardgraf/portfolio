namespace CP_KDO
{
    partial class StartNew
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
            this.start = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.greetings = new System.Windows.Forms.Label();
            this.canc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(23, 184);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(149, 34);
            this.start.TabIndex = 4;
            this.start.Text = "Розпочати";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "ВВЕДIТЬ IМ\'Я ДРУГОГО ГРАВЦЯ";
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ВВЕДIТЬ IМ\'Я ПЕРШОГО ГРАВЦЯ";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.greetings.Location = new System.Drawing.Point(31, 15);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(297, 58);
            this.greetings.TabIndex = 1;
            this.greetings.Text = "  Введіть імена гравців \r\nта натисніть \'Розпочати\'";
            // 
            // canc
            // 
            this.canc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.canc.Location = new System.Drawing.Point(191, 184);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(149, 34);
            this.canc.TabIndex = 5;
            this.canc.Text = "Скасувати";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // StartNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(364, 237);
            this.Controls.Add(this.canc);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.greetings);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "StartNew";
            this.Text = "New Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartNew_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Button canc;
    }
}