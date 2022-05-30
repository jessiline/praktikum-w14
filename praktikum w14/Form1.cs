using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikum_w14
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery ;
        DataTable dtPemain = new DataTable();
        DataTable dtgridMatch = new DataTable();
        DataTable dtTopWorst = new DataTable();
        DataTable dtTopScore = new DataTable();
        int PosisiSekarang = 0;
        string simpan;
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            PosisiSekarang--;
            DataTeam(PosisiSekarang);
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            PosisiSekarang = 0;
            DataTeam(PosisiSekarang);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            PosisiSekarang++;
            DataTeam(PosisiSekarang);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            PosisiSekarang = dtPemain.Rows.Count - 1;
            DataTeam(PosisiSekarang);
        }
        public void DataTeam(int Posisi)
        {
            dtTopScore = new DataTable();
            dtTopWorst = new DataTable();
            try
            {
                labelTeamName.Text = dtPemain.Rows[Posisi][0].ToString();
                labelManager.Text = dtPemain.Rows[Posisi][1].ToString();
                labelStadium.Text = dtPemain.Rows[Posisi][2].ToString();
                simpan = dtPemain.Rows[Posisi][3].ToString();

                dtgridMatch = new DataTable();


                sqlQuery = "SELECT p.player_name, SUM(if(d.`type`='GO',1 , if(d.`type` = 'GP', 1, 0 ))) , SUM(if(d.`type` = 'GP', 1, 0))    from player p, dmatch d, team t where p.player_id = d.player_id and t.team_id = p.team_id and t.team_id='" + simpan + "' group by p.player_id order by 2 desc";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTopScore);

                sqlQuery = "SELECT p.player_name, SUM(if(d.`type`='CR',1,0)) , SUM(if(d.`type` = 'CY', 1, 0)) ,  sum(if(d.type = 'CY',1,0)) + sum(if(d.type = 'CR',3,0)) as 'poin'  from player p, dmatch d, team t where p.player_id = d.player_id and t.team_id = p.team_id and t.team_id='" + simpan + "' group by p.player_id order by poin desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTopWorst);

                labelWorstDisc.Text = dtTopWorst.Rows[0][0].ToString() + " ," + dtTopWorst.Rows[0][2].ToString() + " Yellow Card and " + dtTopWorst.Rows[0][1].ToString() + " Red Card";
                labelTopScorer.Text = dtTopScore.Rows[0][0].ToString() + " " + dtTopScore.Rows[0][1].ToString() + " (" + dtTopScore.Rows[0][2].ToString() + " )";

                sqlQuery = "select m.match_date ,date_format(m.match_date, \'%d/%c/%Y') as 'Match_Date', 'HOME' as 'home/away', concat('vs ',t.team_name) as 'lawan', concat(goal_home, ' - ', goal_away) as 'Score' from `match` m, team t where team_home = '" + simpan + "' and m.team_away = t.team_id union select m.match_date ,date_format(m.match_date, \'%d/%c/%Y') as 'match date', 'AWAY' as 'Home/Away', concat('vs ',t.team_name) as 'Lawan', concat(goal_home, ' - ', goal_away) as 'Score' from `match` m, team t where team_away = '" + simpan + "' and m.team_home = t.team_id order by 1 desc limit 5;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtgridMatch);
                dataGridViewMatch.DataSource = dtgridMatch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Team_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_name ,concat(m.manager_name,' (',n.nation,')') ,concat(t.home_stadium,', ',t.city,' (',t.capacity,')'),t.team_id from team t, manager m , nationality n where t.manager_id = m.manager_id and m.nationality_id = n.nationality_id ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);



            DataTeam(0);
        }
    }
}
