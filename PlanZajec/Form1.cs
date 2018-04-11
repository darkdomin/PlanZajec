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

namespace PlanZajec
{
    public partial class Form1 : Form
    {
        string konfiguracja = "datasource=localhost;CharSet=Utf8;port=3306;username=root;password=Darek80;database=przepis";
        string wyszukaniePrzedmiot = "SELECT * FROM planzajec.plan order by przedmiot ;";
        string wyszukanieCzas = "SELECT * FROM planzajec.czas order by czas;";
        int id;
        public Form1()
        {
            InitializeComponent();
           
        }
        #region Przyciski
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPrzedmiotAdd.Text == "") { }
            else
            {
                string sql = "insert into planzajec.plan (przedmiot)values('" + txtPrzedmiotAdd.Text.ToUpper() + "');" +
                         "insert into planzajec.lacznik (idplan,idczas,idstatystyki)values(last_insert_id(),3,1)";
                string opisMwssageBox = "Przedmiot dodany";
                string opisElse = "Pole - Przedmiot - Musi być wypełnione";
                Dodaj(sql, opisMwssageBox, opisElse);
                OdswiezSiatke(wyszukaniePrzedmiot, dgGridPrzedmiot);
            }
            CzyscPola();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCzasAdd.Text != "")
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = laczBaze.CreateCommand();
                MySqlCommand zapytanie2 = laczBaze.CreateCommand();
                MySqlTransaction transakcja;
                laczBaze.Open();
                transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);
                zapytanie.Connection = laczBaze;
                zapytanie.Transaction = transakcja;
                try
                {
                    zapytanie.CommandText = "insert into planzajec.czas (czas)values('" + txtCzasAdd.Text.ToUpper() + "');" +
                         "insert into planzajec.lacznik (idplan,idczas,idstatystyki)values(1,last_insert_id(),1)";
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show("Nowy Czas dodany");
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                    laczBaze.Close();
                }
            }
            OdswiezSiatke(wyszukanieCzas, dgGridCzas);
            CzyscPola();
        }

        private void dgViewPrzedmiot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                id = Convert.ToInt32(dgGridPrzedmiot.Rows[e.RowIndex].Cells[0].Value);
                if(this.Width==670)
                {
                    if(txtSubjectOne.ReadOnly==false) txtSubjectOne.Text = dgGridPrzedmiot.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
                }
                else
                txtPrzedmiot.Text = dgGridPrzedmiot.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
              //  MiddleForm();
                UnvisibleLabelEnd();
                txtCzas.Visible = true;
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Wyszukanie(dgGridPrzedmiot, wyszukaniePrzedmiot);
            Wyszukanie(dgGridCzas, wyszukanieCzas);
            Ukryj();
            dgGridPrzedmiot.Rows.ToString().ToUpper();
        }

        private void dgViewCzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgGridCzas.Rows[e.RowIndex].Cells[0].Value);
            txtCzas.Text = dgGridCzas.Rows[e.RowIndex].Cells[1].Value.ToString();
            MiddleForm();
            txtCzas.Visible = true;
            UnvisibleLabelEnd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ostrzezenie1 = "UWAGA! Czy chesz usunąć przedmiot?\nCzy chcesz kontynuować kasowanie?";
            string sql1 = "  delete from planzajec.lacznik where idplan= " + id + ";delete from planzajec.plan where idplan = " + id + "; ";
            string wiadomosc1 = "Usunięto przepis z programu";
            if (txtPrzedmiot.Text == "") { }
            else Usun(ostrzezenie1, sql1, wiadomosc1);

            string ostrzezenie2 = "UWAGA! Czy chesz usunąć Czas?\nCzy chcesz kontynuować kasowanie?";
            string sql2 = "  delete from planzajec.lacznik where idczas= " + id + ";delete from planzajec.czas where idczas = " + id + "; ";
            string wiadomosc2 = "Usunięto czas z programu";
            if (txtCzas.Text == "") { }
            else Usun(ostrzezenie2, sql2, wiadomosc2);
            OdswiezSiatke(wyszukaniePrzedmiot, dgGridPrzedmiot);
            OdswiezSiatke(wyszukanieCzas, dgGridCzas);
            CzyscPola();
            UnvisibleLabelEnd();
        }

        private void btnModyfikuj_Click(object sender, EventArgs e)
        {
            string sql = "Update planzajec.plan set przedmiot='" + txtPrzedmiot.Text + "' where idplan=" + id + ";" +

                            "update planzajec.lacznik set idplan  =" + id + " where idplan= " + id + "";
            string sql2 = "Update planzajec.czas set czas='" + txtCzas.Text + "' where idczas=" + id + ";" +

                            "update planzajec.lacznik set idczas  =" + id + " where idczas= " + id + "";
            if (txtPrzedmiot.Text == "") { }
            else
            {
                Modyfikacja(txtPrzedmiot, sql);
                OdswiezSiatke(wyszukaniePrzedmiot, dgGridPrzedmiot);
            }
            if (txtCzas.Text == "") { }
            else
            {
                Modyfikacja(txtCzas, sql2);
                OdswiezSiatke(wyszukanieCzas, dgGridCzas);
            }
            UnvisibleLabelEnd();
        }
        #endregion
        #region Funkcje
        public void Wyszukanie(DataGridView nazwasiatki, string sql)
        {
            MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
            MySqlCommand zapytania = new MySqlCommand(sql, laczBaze);
            try
            {
                MySqlDataAdapter moja = new MySqlDataAdapter();
                moja.SelectCommand = zapytania;
                DataTable tabela = new DataTable();
                moja.Fill(tabela);
                BindingSource zrodlo = new BindingSource();
                zrodlo.DataSource = tabela;
                nazwasiatki.DataSource = zrodlo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            laczBaze.Close();
        }

        public void Dodaj(string sql, string opisMessageBox, string opisElse)
        {
            if (txtPrzedmiotAdd != null)
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = laczBaze.CreateCommand();
                MySqlTransaction transakcja;
                laczBaze.Open();
                transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);
                zapytanie.Connection = laczBaze;
                zapytanie.Transaction = transakcja;
                try
                {
                    zapytanie.CommandText = sql;
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show(opisMessageBox);
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                    laczBaze.Close();
                }
            }
            else
            {
                MessageBox.Show(opisElse);
            }
        }

        public void Ukryj()
        {
            dgGridPrzedmiot.Columns[0].Visible = false;
            dgGridCzas.Columns["idczas"].Visible = false;
        }

        public void Usun(string ostrzezenie, string sql, string wiadomosc)
        {
            if (txtPrzedmiot.Text != "" || txtCzas.Text != "")
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = laczBaze.CreateCommand();
                MySqlTransaction transakcja;
                laczBaze.Open();
                transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);
                zapytanie.Connection = laczBaze;
                zapytanie.Transaction = transakcja;
                try
                {
                    if (MessageBox.Show(ostrzezenie, "UWAGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        zapytanie.CommandText = sql;
                        zapytanie.ExecuteNonQuery();
                        transakcja.Commit();
                        MessageBox.Show(wiadomosc);
                    }
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                    laczBaze.Close();
                }
            }
        }

        public void OdswiezSiatke(string sql, DataGridView nazwaSiatki)
        {
            MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
            MySqlCommand zapytanie = new MySqlCommand(sql, laczBaze);
            try
            {
                laczBaze.Open();
                MySqlDataAdapter moja = new MySqlDataAdapter();
                moja.SelectCommand = zapytanie;
                DataTable tabela = new DataTable();
                moja.Fill(tabela);
                BindingSource zrodlo = new BindingSource();
                zrodlo.DataSource = tabela;
                nazwaSiatki.DataSource = zrodlo;
            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
            }
            laczBaze.Close();
        }

        public void MiddleForm()
        {
            this.Width = 318;
            this.Height = 358;
        }

        public void BigForm()
        {
            this.Width = 318;
            this.Height = 463;
        }

        public void SmallForm()
        {
            this.Width = 318;
            this.Height = 155;
        }

        public void CzyscPola()
        {
            txtCzasAdd.Text = "";
            txtPrzedmiotAdd.Text = "";
            txtPrzedmiot.Text = "";
            txtCzas.Text = "";
        }
        public void UnvisibleLabelEnd()
        {
            lblEnd.Visible = false;
        }

        public void Modyfikacja(TextBox nazwaTextbox, string sql)
        {
            if (txtPrzedmiot.Text != "" && txtCzas.Text != "")
            {
                MessageBox.Show("Mozna edytować jeden element na raz");
            }
            else if (txtPrzedmiot.Text != "" || txtCzas.Text != "")
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = laczBaze.CreateCommand();
                MySqlTransaction transakcja;
                laczBaze.Open();
                transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);
                zapytanie.Connection = laczBaze;
                zapytanie.Transaction = transakcja;
                try
                {
                    txtPrzedmiot.Text.Replace(@"\", @"\\");
                    txtPrzedmiot.Text.Replace(@"'", @"''");
                    zapytanie.CommandText = sql;
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    txtPrzedmiot.Text.Replace(@"\\", @"\");
                    txtPrzedmiot.Text.Replace(@"''", @"'");
                    MessageBox.Show("Modyfikacja powiodła się");
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                    laczBaze.Close();
                }
            }
        }
        #endregion
        int pomiarCzasu;
        int sekundy;
        int minuty=0, godziny=0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sekundy--;
            if (sekundy ==00&&minuty>0)
            {
                minuty--;
                sekundy = 59;
            }else { }
            if (minuty == 00&&godziny>0)
            {
                godziny--;
                minuty = 59;
            }
            lblWyswietlacz.Text = godziny + ":" + minuty + ":" + pomiarCzasu;
            if (godziny < 10 )

                lblWyswietlacz.Text = "0" + godziny + ":" + minuty + ":" + sekundy;
            if (minuty < 10 )
                lblWyswietlacz.Text = "0"+godziny + ":" + "0" + minuty + ":" + sekundy;
            if (sekundy < 10)
                lblWyswietlacz.Text = "0"+godziny + ":"  +"0"+ minuty + ":" +"0"+ sekundy;
            

            if (godziny==0&&minuty==0&&sekundy==0)
            {
                Show();
                timer1.Enabled = false;
                MiddleForm();
                lblEnd.Text = "Koniec";
                lblEnd.Visible = true;
                txtCzas.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnAddCzas.Visible = true;
            btnAddPrzedmiot.Visible = true;
            txtCzasAdd.Visible = true;
            txtPrzedmiotAdd.Visible = true;
            BigForm();
            UnvisibleLabelEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCzas.Visible = false;
            pomiarCzasu = Convert.ToInt32(txtCzas.Text);
            sekundy = pomiarCzasu;
            timer1.Interval = 1000;
            timer1.Start();
            Form1 nowa = new Form1();
            SmallForm();
            UnvisibleLabelEnd();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            MiddleForm();
            txtCzas.Visible = true;
            UnvisibleLabelEnd();
        }

        private void txtSubjectOne_Click(object sender, EventArgs e)
        {
            txtSubjectOne.ReadOnly = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                txtPrzedmiot.Text = "" ;
                timer1.Stop();
                

                btnPause.Text = "Uruchom";
            }
            else
            {
                timer1.Start();
                btnPause.Text = "Pause";
            }

        }
    }
}