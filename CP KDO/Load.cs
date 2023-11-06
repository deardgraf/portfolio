using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_KDO
{
    public partial class Load : Form
    {
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dima\Desktop\КУРСАЧ\CricketDB.accdb";
        bool clicked = false;
        bool canceled = false;
        int row = 0;

        int gID;
        string name1;
        string name2;
        string gSc;
        int pl1Sc;
        int pl2Sc;
        List<string> fields1 = new List<string>();
        List<string> fields2 = new List<string>();
        string f1tmp;
        string f2tmp;

        public Load()
        {
            InitializeComponent();
            new Task(() =>
            {
                using (var connection = new OleDbConnection(conStr))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM game;";
                        using (var data = command.ExecuteReader())
                        {
                            while (data.Read())
                            {
                                dataGridView1.Rows.Add(1);
                                dataGridView1.Rows[row].Cells[0].Value = data["ID"];
                                dataGridView1.Rows[row].Cells[1].Value = data["gameScore"];
                                dataGridView1.Rows[row].Cells[2].Value = data["player1Name"];
                                dataGridView1.Rows[row].Cells[3].Value = data["player1Score"];
                                dataGridView1.Rows[row].Cells[4].Value = data["player2Name"];
                                dataGridView1.Rows[row].Cells[5].Value = data["player2Score"];
                                fields1.Add($"{data["f20"]} {data["f19"]} {data["f18"]} {data["f17"]} {data["f16"]} {data["f15"]} {data["fBull"]}");
                                fields2.Add($"{data["s20"]} {data["s19"]} {data["s18"]} {data["s17"]} {data["s16"]} {data["s15"]} {data["sBull"]}");
                                row++;
                            }
                        }
                    }
                }
            }).RunSynchronously();
            
        }
        public int GID
        {
            get { return gID; }
            set { gID = value; }
        }
        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }
        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }
        public string GSc
        {
            get { return gSc; }
            set { gSc = value; }
        }
        public int Pl1Sc
        {
            get { return pl1Sc; }
            set { pl1Sc = value; }
        }
        public int Pl2Sc
        {
            get { return pl2Sc; }
            set { pl2Sc = value; }
        }
        public bool Clicked
        {
            get { return clicked; }
            set { clicked = value; }
        }
        public bool Canceled
        {
            get { return canceled; }
            set { canceled = value; }
        }

        private void loading_Click(object sender, EventArgs e)
        {
            Clicked = true;
            Hide();
        }

        private void canc_Click(object sender, EventArgs e)
        {
            Canceled = true;
            Hide();
        }
        public string F1tmp
        {
            get { return f1tmp; }
            set { f1tmp = value; }
        }
        public string F2tmp
        {
            get { return f2tmp; }
            set { f2tmp = value; }
        }

        private void Load_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int lg = e.RowIndex;

            GID = Convert.ToInt32(dataGridView1.Rows[lg].Cells[0].Value);
            Name1 = Convert.ToString(dataGridView1.Rows[lg].Cells[2].Value);
            Name2 = Convert.ToString(dataGridView1.Rows[lg].Cells[4].Value);
            GSc = Convert.ToString(dataGridView1.Rows[lg].Cells[1].Value);
            Pl1Sc = Convert.ToInt32(dataGridView1.Rows[lg].Cells[3].Value);
            Pl2Sc = Convert.ToInt32(dataGridView1.Rows[lg].Cells[5].Value);
            F1tmp = fields1[lg];
            F2tmp = fields2[lg];
        }
    }
}