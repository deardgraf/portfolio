using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_KDO
{
    public partial class Darts : Form
    {
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dima\Desktop\КУРСАЧ\CricketDB.accdb";

        string pl1;
        string pl2;
        int loadID;
        string loadedSc;
        int loadSc1;
        int loadSc2;
        string[] fields1;
        string[] fields2;
        GameStats play;
        int sh;
        int plScore;
        bool winRound1 = false;
        bool winRound2 = false;
        bool gameOver;
        public Darts()
        {
            InitializeComponent();
            MaximizeBox = false;
            TableHat();
        }
        private void TableHat()
        {
            new Task(() =>
            {
                dataGridView1.Rows.Add(9);
                dataGridView1.Rows[0].Cells[1].Value = 20;
                dataGridView1.Rows[1].Cells[1].Value = 19;
                dataGridView1.Rows[2].Cells[1].Value = 18;
                dataGridView1.Rows[3].Cells[1].Value = 17;
                dataGridView1.Rows[4].Cells[1].Value = 16;
                dataGridView1.Rows[5].Cells[1].Value = 15;
                dataGridView1.Rows[6].Cells[1].Value = "Bull";

                dataGridView1.Rows[7].Cells[0].Value = "Очки:";
                dataGridView1.Rows[7].Cells[2].Value = "Очки:";
                dataGridView1.Rows[8].Cells[0].Value = 0;
                dataGridView1.Rows[8].Cells[2].Value = 0;
            }).RunSynchronously();
        }
        private void TableProgress()
        {
            new Task(() =>
            {
                dataGridView1.Rows[0].Cells[0].Value = fields1[0];
                dataGridView1.Rows[1].Cells[0].Value = fields1[1];
                dataGridView1.Rows[2].Cells[0].Value = fields1[2];
                dataGridView1.Rows[3].Cells[0].Value = fields1[3];
                dataGridView1.Rows[4].Cells[0].Value = fields1[4];
                dataGridView1.Rows[5].Cells[0].Value = fields1[5];
                dataGridView1.Rows[6].Cells[0].Value = fields1[6];

                dataGridView1.Rows[0].Cells[2].Value = fields2[0];
                dataGridView1.Rows[1].Cells[2].Value = fields2[1];
                dataGridView1.Rows[2].Cells[2].Value = fields2[2];
                dataGridView1.Rows[3].Cells[2].Value = fields2[3];
                dataGridView1.Rows[4].Cells[2].Value = fields2[4];
                dataGridView1.Rows[5].Cells[2].Value = fields2[5];
                dataGridView1.Rows[6].Cells[2].Value = fields2[6];

                dataGridView1.Rows[8].Cells[0].Value = play.Score1;
                dataGridView1.Rows[8].Cells[2].Value = play.Score2;
                label6.Text = play.GameScore;
            }).RunSynchronously();
        }
        #region Properties
        public string Pl1
        {
            get { return pl1; }
            set { pl1 = value; }
        }
        public string Pl2
        {
            get { return pl2; }
            set { pl2 = value; }
        }
        public string QueryPl
        {
            get { return queryPl.Text; }
            set { queryPl.Text = value; }
        }
        public string Hits
        {
            get { return hits.Text; }
            set { hits.Text = value; }
        }
        public int LoadID
        {
            get { return loadID; }
            set { loadID = value; }
        }
        public string LoadedSc
        {
            get { return loadedSc; }
            set { loadedSc = value; }
        }
        public int LoadSc1
        {
            get { return loadSc1; }
            set { loadSc1 = value; }
        }
        public int LoadSc2
        {
            get { return loadSc2; }
            set { loadSc2 = value; }
        }
        #endregion
        #region Menu
        private void початиНовуГруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNew ng = new StartNew();
            ng.ShowDialog();
            while (true)
            {
                if (ng.Clicked == true)
                {
                    sh = 3;
                    gameOver = false;
                    Pl1 = ng.Name1;
                    Pl2 = ng.Name2;
                    curPl1.Text = Pl1;
                    curPl2.Text = Pl2;
                    fields1 = new string[] { "-", "-", "-", "-", "-", "-", "-" };
                    fields2 = new string[] { "-", "-", "-", "-", "-", "-", "-" };

                    greetings.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    curPl1.Visible = true;
                    curPl2.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label9.Visible = true;

                    play = new GameStats(Pl1, Pl2, "0 : 0", 0, 0);
                    QueryPl = play.Player1;
                    Hits = Convert.ToString(sh);
                    TableProgress();
                    break;
                }
                if (ng.Canceled == true)
                    break;
            }
        }
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string o20 = fields1[0];
                string o19 = fields1[1];
                string o18 = fields1[2];
                string o17 = fields1[3];
                string o16 = fields1[4];
                string o15 = fields1[5];
                string oBull = fields1[6];
                string t20 = fields1[0];
                string t19 = fields1[1];
                string t18 = fields1[2];
                string t17 = fields1[3];
                string t16 = fields1[4];
                string t15 = fields1[5];
                string tBull = fields1[6];
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Гру не було почато, немає чого зберігати", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (LoadedSc != null) //перевірка було почато нову гру чи гра була завантажена з бази даних
            {
                new Task(() =>
                {
                    using (var connection = new OleDbConnection(conStr))
                    {
                        connection.Open();
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "UPDATE game SET gameScore = play.GameScore, player1Score = play.Score1, player2Score = play.Score2, f20 = o20, f19 = o19, f18 = o18, f17 = o17, f16 = o16, f15 = o15, fBull = oBull, s20 = t20, s19 = t19, s18 = t18, s17 = t17, s16 = t16, s15 = t15, sBull = tBull WHERE ID = LoadID;";
                            using (var data = command.ExecuteReader())
                            {
                                data.Read();
                            }
                        }
                    }
            }).RunSynchronously();
            }
            else
            {
                new Task(() =>
                {
                    using (var connection = new OleDbConnection(conStr))
                    {
                        connection.Open();
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "INSERT INTO game (player1Name, player2Name, gameScore, player1Score, player2Score, f20, f19, f18, f17, f16, f15, fBull, s20, s19, s18, s17, s16, s15, sBull) VALUES (play.Player1, play.Player2, play.GameScore, play.Score1, play.Score2, o20, o19, o18, o17, o16, o15, oBull, t20, t19, t18, t17, t16, t15, tBull);"
;
                            using (var data = command.ExecuteReader())
                            {
                                data.Read();
                            }
                        }
                    }
                }).RunSynchronously();
            }

        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load l = new Load();
            l.ShowDialog();
            while (true)
            {
                if (l.Clicked == true)
                {
                    sh = 3;
                    gameOver = false;
                    LoadID = l.GID;
                    Pl1 = l.Name1;
                    Pl2 = l.Name2;
                    LoadedSc = l.GSc;
                    LoadSc1 = l.Pl1Sc;
                    LoadSc2 = l.Pl2Sc;
                    fields1 = l.F1tmp.Split(' ');
                    fields2 = l.F2tmp.Split(' ');

                    greetings.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    curPl1.Visible = true;
                    curPl2.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label9.Visible = true;
                    
                    play = new GameStats(Pl1, Pl2, LoadedSc, LoadSc1, LoadSc2);
                    QueryPl = play.Player1;
                    Hits = Convert.ToString(sh);
                    TableProgress();
                    break;
                }
                if (l.Canceled == true)
                    break;
            }
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show($"       Ви впевнені, що бажаєте вийти з гри? \r\nВсі незбережені дані безповоротно зникнуть", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Крикет - це гра, яка вимагає особливих навичок та стратегії. Ціль гри полягає в тому, щоб першим закрити всі розташовані ігрові номери (від 15 до 20 і яблучко мішені) і набрати найбільшу кількість очок. \r\nКожен гравець за один свій хід повинен кинути 3 дротики, намагаючись закрити свої ігрові номери.Номер буде вважатися повністю закритий після того, як гравець влучить у нього тричі. \r\nОчки в крикеті будуть нараховані тільки в тому випадку, коли гравець закриє свій ігровий номер, а ігровий номер його противника ще не закритий.\r\nОчки можуть бути зараховані на кожному відкритому ігровому номері і оцінюються виключно за номінальною вартістю. Яблучко мішені дає 25 очок за кожне помітне потрапляння в одиничне кільце, а також 50 очок - при попаданні в подвійне кільце.", "Правила");
        }
        private void розробникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробив Кіцілінський Д.О.\n\rt.me/deard_graf", "Дані про розробника", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quit = MessageBox.Show($"       Ви впевнені, що бажаєте вийти з гри? \r\nВсі незбережені дані безповоротно зникнуть", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quit == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
        #endregion
        #region Sector
        int sector(int x, int y) //визначення сектора
        {

            if (
                ((256 - x) * (282 - 70) - (288 - 256) * (70 - y) <= 0)
                &&
                ((324 - x) * (282 - 70) - (288 - 324) * (70 - y) > 0)

                )
                return 20;
            else if (
                             ((254 - x) * (282 - 496) - (288 - 254) * (496 - y) <= 0)
                             &&
                             ((188 - x) * (282 - 472) - (288 - 188) * (472 - y) > 0)

                             )
                return 19;
            else if (
                             ((380 - x) * (282 - 104) - (288 - 380) * (104 - y) <= 0)
                             &&
                             ((442 - x) * (282 - 130) - (288 - 442) * (130 - y) > 0)

                             )
                return 18;
            else if (
                             ((388 - x) * (282 - 470) - (288 - 388) * (470 - y) <= 0)
                             &&
                             ((322 - x) * (282 - 498) - (288 - 322) * (498 - y) > 0)

                             )
                return 17;
            else if (
                             ((136 - x) * (282 - 434) - (288 - 136) * (434 - y) <= 0)
                             &&
                             ((92 - x) * (282 - 380) - (288 - 92) * (380 - y) > 0)

                             )
                return 16;
            else if (
                             ((482 - x) * (282 - 378) - (288 - 482) * (378 - y) <= 0)
                             &&
                             ((444 - x) * (282 - 432) - (288 - 444) * (432 - y) > 0)

                             )
                return 15;

            else return 0;
        }
        int multiplier(int x, int y) //множитель попадання
        {
            int tmp = (x - 288) * (x - 288) + (y - 288) * (y - 288);
            if (tmp > 47500) return 0;
            else if (tmp >= 42000) return 2;
            else if (tmp >= 19000) return 1;
            else if (tmp >= 15500) return 3;
            else if (tmp >= 500) return 1;
            else if (tmp >= 70) return 25;
            else return 50;
        }
        #endregion
        private void Shoot(int sect, int mult, string[] f1, string[] f2)
        {
            if (sect == 20 && mult == 1) //попадання в 20
            {
                if (f1[0] == "III" && f2[0] == "III") ;
                else if (f1[0] == "III" && f2[0] != "III")
                    plScore += 20;
                else if (f1[0] == "-")
                    f1[0] = "I";
                else if (f1[0] == "I" || f1[0] == "II")
                    f1[0] += "I";
            }
            else if (sect == 20 && mult == 2) //попадання в подвійне 20
            {
                if (f1[0] == "III" && f2[0] == "III") ;
                else if (f1[0] == "III" && f2[0] != "III")
                    plScore += 40;
                else if (f1[0] == "II" && f2[0] == "III")
                    f1[0] += "I";
                else if (f1[0] == "II" && f2[0] != "III")
                {
                    f1[0] += "I";
                    plScore += 20;
                }
                else if (f1[0] == "I")
                    f1[0] += "II";
                else if (f1[0] == "-")
                    f1[0] = "II";
            }
            else if (sect == 20 && mult == 3) //попадання в потрійне 20
            {
                if (f1[0] == "III" && f2[0] == "III") ;
                else if (f1[0] == "III" && f2[0] != "III")
                    plScore += 60;
                else if (f1[0] == "II" && f2[0] == "III")
                    f1[0] += "I";
                else if (f1[0] == "II" && f2[0] != "III")
                {
                    f1[0] += "I";
                    plScore += 40;
                }
                else if (f1[0] == "I" && f2[0] == "III")
                    f1[0] += "II";
                else if (f1[0] == "I" && f2[0] != "III")
                {
                    f1[0] += "II";
                    plScore += 20;
                }
                else if (f1[0] == "-")
                    f1[0] = "III";
            }
            if (sect == 19 && mult == 1) //попадання в 19
            {
                if (f1[1] == "III" && f2[1] == "III") ;
                else if (f1[1] == "III" && f2[1] != "III")
                    plScore += 19;
                else if (f1[1] == "-")
                    f1[1] = "I";
                else if (f1[1] == "I" || f1[1] == "II")
                    f1[1] += "I";
            }
            else if (sect == 19 && mult == 2) //попадання в подвійне 19
            {
                if (f1[1] == "III" && f2[1] == "III") ;
                else if (f1[1] == "III" && f2[1] != "III")
                    plScore += 38;
                else if (f1[1] == "II" && f2[1] == "III")
                    f1[1] += "I";
                else if (f1[1] == "II" && f2[1] != "III")
                {
                    f1[1] += "I";
                    plScore += 19;
                }
                else if (f1[1] == "I")
                    f1[1] += "II";
                else if (f1[0] == "-")
                    f1[1] = "II";
            }
            else if (sect == 19 && mult == 3) //попадання в потрійне 19
            {
                if (f1[1] == "III" && f2[1] == "III") ;
                else if (f1[1] == "III" && f2[1] != "III")
                    plScore += 57;
                else if (f1[1] == "II" && f2[1] == "III")
                    f1[1] += "I";
                else if (f1[1] == "II" && f2[1] != "III")
                {
                    f1[1] += "I";
                    plScore += 38;
                }
                else if (f1[1] == "I" && f2[1] == "III")
                    f1[1] += "II";
                else if (f1[1] == "I" && f2[1] != "III")
                {
                    f1[1] += "II";
                    plScore += 19;
                }
                else if (f1[1] == "-")
                    f1[1] = "III";
            }
            if (sect == 18 && mult == 1) //попадання в 18
            {
                if (f1[2] == "III" && f2[2] == "III") ;
                else if (f1[2] == "III" && f2[2] != "III")
                    plScore += 18;
                else if (f1[2] == "-")
                    f1[2] = "I";
                else if (f1[2] == "I" || f1[2] == "II")
                    f1[2] += "I";
            }
            else if (sect == 18 && mult == 2) //попадання в подвійне 18
            {
                if (f1[2] == "III" && f2[2] == "III") ;
                else if (f1[2] == "III" && f2[2] != "III")
                    plScore += 36;
                else if (f1[2] == "II" && f2[2] == "III")
                    f1[2] += "I";
                else if (f1[2] == "II" && f2[2] != "III")
                {
                    f1[2] += "I";
                    plScore += 18;
                }
                else if (f1[2] == "I")
                    f1[2] += "II";
                else if (f1[2] == "-")
                    f1[2] = "II";
            }
            else if (sect == 18 && mult == 3) //попадання в потрійне 18
            {
                if (f1[2] == "III" && f2[2] == "III") ;
                else if (f1[2] == "III" && f2[2] != "III")
                    plScore += 54;
                else if (f1[2] == "II" && f2[2] == "III")
                    f1[2] += "I";
                else if (f1[2] == "II" && f2[2] != "III")
                {
                    f1[2] += "I";
                    plScore += 36;
                }
                else if (f1[2] == "I" && f2[2] == "III")
                    f1[2] += "II";
                else if (f1[2] == "I" && f2[2] != "III")
                {
                    f1[2] += "II";
                    plScore += 18;
                }
                else if (f1[2] == "-")
                    f1[2] = "III";
            }
            if (sect == 17 && mult == 1) //попадання в 17
            {
                if (f1[3] == "III" && f2[3] == "III") ;
                else if (f1[3] == "III" && f2[3] != "III")
                    plScore += 17;
                else if (f1[3] == "-")
                    f1[3] = "I";
                else if (f1[3] == "I" || f1[3] == "II")
                    f1[3] += "I";
            }
            else if (sect == 17 && mult == 2) //попадання в подвійне 17
            {
                if (f1[3] == "III" && f2[3] == "III") ;
                else if (f1[3] == "III" && f2[3] != "III")
                    plScore += 34;
                else if (f1[3] == "II" && f2[3] == "III")
                    f1[3] += "I";
                else if (f1[3] == "II" && f2[3] != "III")
                {
                    f1[3] += "I";
                    plScore += 17;
                }
                else if (f1[3] == "I")
                    f1[3] += "II";
                else if (f1[3] == "-")
                    f1[3] = "II";
            }
            else if (sect == 17 && mult == 3) //попадання в потрійне 17
            {
                if (f1[3] == "III" && f2[3] == "III") ;
                else if (f1[3] == "III" && f2[3] != "III")
                    plScore += 51;
                else if (f1[3] == "II" && f2[3] == "III")
                    f1[3] += "I";
                else if (f1[3] == "II" && f2[3] != "III")
                {
                    f1[3] += "I";
                    plScore += 34;
                }
                else if (f1[3] == "I" && f2[3] == "III")
                    f1[3] += "II";
                else if (f1[3] == "I" && f2[3] != "III")
                {
                    f1[3] += "II";
                    plScore += 17;
                }
                else if (f1[3] == "-")
                    f1[3] = "III";
            }
            if (sect == 16 && mult == 1) //попадання в 16
            {
                if (f1[4] == "III" && f2[4] == "III") ;
                else if (f1[4] == "III" && f2[4] != "III")
                    plScore += 16;
                else if (f1[4] == "-")
                    f1[4] = "I";
                else if (f1[4] == "I" || f1[4] == "II")
                    f1[4] += "I";
            }
            else if (sect == 16 && mult == 2) //попадання в подвійне 16
            {
                if (f1[4] == "III" && f2[4] == "III") ;
                else if (f1[4] == "III" && f2[4] != "III")
                    plScore += 32;
                else if (f1[4] == "II" && f2[4] == "III")
                    f1[4] += "I";
                else if (f1[4] == "II" && f2[4] != "III")
                {
                    f1[4] += "I";
                    plScore += 16;
                }
                else if (f1[4] == "I")
                    f1[4] += "II";
                else if (f1[4] == "-")
                    f1[4] = "II";
            }
            else if (sect == 16 && mult == 3) //попадання в потрійне 16
            {
                if (f1[4] == "III" && f2[4] == "III") ;
                else if (f1[4] == "III" && f2[4] != "III")
                    plScore += 48;
                else if (f1[4] == "II" && f2[4] == "III")
                    f1[4] += "I";
                else if (f1[4] == "II" && f2[4] != "III")
                {
                    f1[4] += "I";
                    plScore += 32;
                }
                else if (f1[4] == "I" && f2[4] == "III")
                    f1[4] += "II";
                else if (f1[4] == "I" && f2[4] != "III")
                {
                    f1[4] += "II";
                    plScore += 16;
                }
                else if (f1[4] == "-")
                    f1[4] = "III";
            }
            if (sect == 15 && mult == 1) //попадання в 15
            {
                if (f1[5] == "III" && f2[5] == "III") ;
                else if (f1[5] == "III" && f2[5] != "III")
                    plScore += 15;
                else if (f1[5] == "-")
                    f1[5] = "I";
                else if (f1[5] == "I" || f1[5] == "II")
                    f1[5] += "I";
            }
            else if (sect == 15 && mult == 2) //попадання в подвійне 15
            {
                if (f1[5] == "III" && f2[5] == "III") ;
                else if (f1[5] == "III" && f2[5] != "III")
                    plScore += 30;
                else if (f1[5] == "II" && f2[5] == "III")
                    f1[5] += "I";
                else if (f1[5] == "II" && f2[5] != "III")
                {
                    f1[5] += "I";
                    plScore += 15;
                }
                else if (f1[5] == "I")
                    f1[5] += "II";
                else if (f1[5] == "-")
                    f1[5] = "II";
            }
            else if (sect == 15 && mult == 3) //попадання в потрійне 15
            {
                if (f1[5] == "III" && f2[5] == "III") ;
                else if (f1[5] == "III" && f2[5] != "III")
                    plScore += 45;
                else if (f1[5] == "II" && f2[5] == "III")
                    f1[5] += "I";
                else if (f1[5] == "II" && f2[5] != "III")
                {
                    f1[5] += "I";
                    plScore += 30;
                }
                else if (f1[5] == "I" && f2[5] == "III")
                    f1[5] += "II";
                else if (f1[5] == "I" && f2[5] != "III")
                {
                    f1[5] += "II";
                    plScore += 15;
                }
                else if (f1[5] == "-")
                    f1[5] = "III";
            }
            if (mult == 25)  //попадання в зелений bull
            {
                if (f1[6] == "III" && f2[6] == "III") ;
                else if (f1[6] == "III" && f2[6] != "III")
                    plScore += 25;
                else if (f1[6] == "-")
                    f1[6] = "I";
                else if (f1[6] == "I" || f1[6] == "II")
                    f1[6] += "I";
            }
            else if (mult == 50) //попадання в червоний bull
            {
                if (f1[6] == "III" && f2[6] == "III") ;
                else if (f1[6] == "III" && f2[6] != "III")
                    plScore += 50;
                else if (f1[6] == "II" && f2[6] == "III")
                    f1[6] += "I";
                else if (f1[6] == "II" && f2[6] != "III")
                {
                    f1[6] += "I";
                    plScore += 25;
                }
                else if (f1[6] == "I")
                    f1[6] += "II";
                else if (f1[6] == "-")
                    f1[6] = "II";

            }
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        { 
            if (play != null) //умова для передбачення запису даних в таблицю до початку гри
            {
                if(gameOver)
                    MessageBox.Show("Гра завершена \r\nЯкщо бажаєте, Ви можете розпочати нову гру", "Кінець гри", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (gameOver != true) //виведення повыдомлення про те, що гра завершилась
                    {
                    sh--;
                    if (sh != 0)
                        Hits = Convert.ToString(sh);

                    int sect = sector(e.X, e.Y);
                    int mult = multiplier(e.X, e.Y);

                    if (QueryPl == play.Player1)
                    {
                        Shoot(sect, mult, fields1, fields2);
                        play.Score1 += plScore;
                        plScore = 0;
                    }
                    else if (QueryPl == play.Player2)
                    {
                        Shoot(sect, mult, fields2, fields1);
                        play.Score2 += plScore;
                        plScore = 0;
                    }
                    TableProgress();

                    if (sh == 0)
                    {
                        sh = 3;
                        Hits = Convert.ToString(sh);
                        if (QueryPl == play.Player1)
                            QueryPl = play.Player2;
                        else QueryPl = play.Player1;
                    }

                    if (fields1[0] == "III" && fields1[1] == "III" && fields1[2] == "III" && fields1[3] == "III"
                       && fields1[4] == "III" && fields1[5] == "III" && fields1[6] == "III" && play.Score1 > play.Score2)
                        winRound1 = true;
                    if (fields2[0] == "III" && fields2[1] == "III" && fields2[2] == "III" && fields2[3] == "III"
                       && fields2[4] == "III" && fields2[5] == "III" && fields2[6] == "III" && play.Score2 > play.Score1)
                        winRound2 = true;

                    if (winRound1)
                    {
                        if (play.GameScore == "0 : 0")
                            play.GameScore = "1 : 0";
                        else if (play.GameScore == "1 : 1")
                            play.GameScore = "2 : 1";
                        else if (play.GameScore == "2 : 2")
                            play.GameScore = "3 : 2";
                        else if (play.GameScore == "1 : 0")
                            play.GameScore = "2 : 0";
                        else if (play.GameScore == "0 : 1")
                            play.GameScore = "1 : 1";
                        else if (play.GameScore == "2 : 1")
                            play.GameScore = "3 : 1";
                        else if (play.GameScore == "1 : 2")
                            play.GameScore = "2 : 2";

                        winRound1 = false;
                        play.Score1 = 0;
                        play.Score2 = 0;
                        fields1 = new string[] { "-", "-", "-", "-", "-", "-", "-" };
                        fields2 = new string[] { "-", "-", "-", "-", "-", "-", "-" };
                        QueryPl = play.Player1;
                        sh = 3;
                        TableProgress();
                    }
                    if (winRound2)
                    {
                        if (play.GameScore == "0 : 0")
                            play.GameScore = "0 : 1";
                        else if (play.GameScore == "1 : 1")
                            play.GameScore = "1 : 2";
                        else if (play.GameScore == "2 : 2")
                            play.GameScore = "2 : 3";
                        else if (play.GameScore == "1 : 0")
                            play.GameScore = "1 : 1";
                        else if (play.GameScore == "0 : 1")
                            play.GameScore = "0 : 2";
                        else if (play.GameScore == "2 : 1")
                            play.GameScore = "2 : 2";
                        else if (play.GameScore == "1 : 2")
                            play.GameScore = "1 : 3";

                        winRound2 = false;
                        play.Score1 = 0;
                        play.Score2 = 0;
                        fields1 = new string[] { "-", "-", "-", "-", "-", "-", "-" };
                        fields2 = new string[] { "-", "-", "-", "-", "-", "-", "-" };
                        QueryPl = play.Player1;
                        sh = 3;
                        TableProgress();
                    }

                    if (play.GameScore == "2 : 0" || play.GameScore == "3 : 1" || play.GameScore == "3 : 2")
                    {
                        gameOver = true;
                        MessageBox.Show("Переміг перший гравець", "Кінець гри", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (play.GameScore == "0 : 2" || play.GameScore == "1 : 3" || play.GameScore == "2 : 3")
                    {
                        gameOver = true;
                        MessageBox.Show("Переміг другий гравець", "Кінець гри", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}