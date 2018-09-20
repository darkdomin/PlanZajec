using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;


namespace PlanZajec
{
    public partial class Form1 : Form
    {

        int idSubject, idTime, sekundy = 0, minuty = 0, godziny = 0, pomiarCzasu, dodajCzas = 0;

        public Form1()
        {
            InitializeComponent();

            //dgGridPrzedmiot.Columns.Add("id", "Id");
            //dgGridPrzedmiot.Columns.Add("imie", "Przedmiot");
            //dgGridPrzedmiot.Columns.Add("stat", "Statystyka w min");
            //dgGridCzas.Columns.Add("pochodzenie", "Id");
            //dgGridCzas.Columns.Add("telefon", "Czas");

            //dgGridPrzedmiot.Columns[0].Visible = false;
            //dgGridCzas.Columns[0].Visible = false;

            //filldgSubject(dgGridPrzedmiot);
            //filldgTime(dgGridCzas);
        }

        public static void filldgSubject(DataGridView dg)
        { // Przy próbie uruchomienia bez Administratora wystepuje bład w tej funkcji - spowodowany dostępem
            dg.Rows.Clear();
            foreach (var r in FunctionClassSubject.getAll())
            {
                dg.Rows.Add(r.Id, r.SubjectDescription, r.Statystyka);
            }
        }

        public static void filldgTime(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (var r in FunctionClassTime.getAll())
            {
                dg.Rows.Add(r.Id, r.TimeDuration.ToString());
            }
        }

        #region Przyciski
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
          

            foreach (var r in FunctionClassSubject.getAll())
            {
                if (r.SubjectDescription == txtPrzedmiotAdd.Text)
                {
                    MessageBox.Show("Taka nazwa już istnieje w bazie danych");
                    txtPrzedmiotAdd.Text = "";
                }
            }

            if (txtPrzedmiotAdd.Text != "")
            {
                Subject model = new Subject();
                model.SubjectDescription = txtPrzedmiotAdd.Text;
                FunctionClassSubject.add(model);
                filldgSubject(dgGridPrzedmiot);
                MessageBox.Show("Dodano przedmiot!!!");
                txtPrzedmiotAdd.Text = "";
            }
            else
            {
                MessageBox.Show("Podaj nazwę Przedmiotu");
            }
        }

        private void btnAddCzas_Click(object sender, EventArgs e)
        {
            foreach (var r in FunctionClassTime.getAll())
            {
                if (r.TimeDuration == int.Parse(txtTimeAdd.Text))
                {
                    MessageBox.Show("Taka nazwa już istnieje w bazie danych");
                    txtTimeAdd.Text = "";
                }
            }
            int przeliczona;
            if ( txtTimeAdd.Text != "" && int.TryParse(txtTimeAdd.Text, out przeliczona))
            {
                Time model = new Time();
                model.TimeDuration = przeliczona;
                FunctionClassTime.add(model);
                filldgTime(dgGridCzas);
                MessageBox.Show("Dodano czas!!!");
                txtTimeAdd.Text = "";
            }
            else
            {
                MessageBox.Show("Wpisz czas");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (lblWyswietlacz.Text == "00:00:00" && timer1.Enabled == false)
            {

            }
            else if (timer1.Enabled == true)
            {

                timer1.Stop();
                btnPause.Text = "Uruchom";
                this.btnPause.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            }
            else
            {
                timer1.Start();
                btnPause.Text = "Pause";
                this.btnPause.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            }
        }

        private void btnSchema_Click_1(object sender, EventArgs e)
        {
            pomiarCzasu = 0;
            txtPrzedmiot.Text = "";
            txtCzas.Text = "";
            string buttonPlan = "Plan";
            if (btnSchema.Text == buttonPlan)
            {
                SchemaForm();
                buttonPlan = "Zmiejsz";
                btnSchema.Text = buttonPlan;
                // lblWyswietlaczSchema.Visible = true;
            }
            else
            {
                lblWyswietlaczSchema.Visible = false;
                MiddleForm();
                buttonPlan = "Plan";
                btnSchema.Text = buttonPlan;
                foreach (Control p in Controls)
                {
                    if (p is TextBox) ((TextBox)p).ReadOnly = true;
                }
            }
        }

        private void dgViewPrzedmiot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                idSubject = Convert.ToInt32(dgGridPrzedmiot.Rows[e.RowIndex].Cells[0].Value);
                if (this.Width == 700)
                {
                    foreach (Control p in gbPrzedmiot.Controls)
                    {
                        if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text == "")
                        {
                            p.Text = dgGridPrzedmiot.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
                            break;
                        }
                    }
                }
                else
                {
                    txtPrzedmiot.Text = dgGridPrzedmiot.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MiddleForm();
                }
            }

         // dgGridPrzedmiot.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgGridPrzedmiot.Rows.ToString().ToUpper();
            dgGridPrzedmiot.Columns.Add("id", "Id");
            dgGridPrzedmiot.Columns.Add("imie", "Przedmiot");
            dgGridPrzedmiot.Columns.Add("stat", "Statystyka w min");
            dgGridCzas.Columns.Add("pochodzenie", "Id");
            dgGridCzas.Columns.Add("telefon", "Czas");

            dgGridPrzedmiot.Columns[0].Visible = false;
            dgGridCzas.Columns[0].Visible = false;
            filldgSubject(dgGridPrzedmiot);
            filldgTime(dgGridCzas);
            
        }

        private void dgViewCzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTime = Convert.ToInt32(dgGridCzas.Rows[e.RowIndex].Cells[0].Value);
                if (this.Width == 700)
                {
                    foreach (Control p in gbCzas.Controls)
                    {
                        if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text == "")
                        {
                            p.Text = dgGridCzas.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
                            break;
                        }
                    }
                }
                else
                {
                    txtCzas.Text = dgGridCzas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MiddleForm();
                }
                dgGridCzas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            }

            // txtCzas.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {



            if (txtPrzedmiot.Text != "")
            {
                var z = FunctionClassSubject.getById(idSubject);
                FunctionClassSubject.del(z.Id);
                MessageBox.Show("Usnięty!!");
                filldgSubject(dgGridPrzedmiot);
                txtPrzedmiot.Text = "";
                if (txtPrzedmiot.Text == "") dgGridPrzedmiot.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            }
            else if (txtCzas.Text != "")
            {
                var zm = FunctionClassTime.getById(idTime);
                FunctionClassTime.del(zm.Id);
                MessageBox.Show("Usnięty!!");
                Form1.filldgTime(dgGridCzas);
                txtCzas.Text = "";
                 dgGridCzas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            }
            else
            {
                MessageBox.Show("Nie można usunąć pustki");
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            btnPause.Text = "Pause";
            MiddleForm();
            txtCzas.Visible = true;
            lblWyswietlacz.Text = "00:00:00";
            pomiarCzasu = 0;
            txtCzas.Text = "";
            txtPrzedmiot.Text = "Zakończone przed czasem".ToUpper();
            this.Location = new System.Drawing.Point(500, 200);
            btnSchema.Text = "Plan";
            this.btnPause.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            if (txtPrzedmiot.ReadOnly == true)
            {
                txtPrzedmiot.ReadOnly = false;
                txtCzas.ReadOnly = false;
            }
            else
            {
                if (txtPrzedmiot.Text != "")
                {
                    var z = FunctionClassSubject.getById(idSubject);
                    z.SubjectDescription = txtPrzedmiot.Text;
                    FunctionClassSubject.update(z);
                    MessageBox.Show("Zmodyfikowano!!");
                    filldgSubject(dgGridPrzedmiot);
                    txtPrzedmiot.ReadOnly = true;
                    txtCzas.ReadOnly = true;
                }
                else if (txtCzas.Text != "")
                {
                    var zm = FunctionClassTime.getById(idTime);
                    zm.TimeDuration = int.Parse(txtCzas.Text);
                    FunctionClassTime.update(zm);
                    MessageBox.Show("Zmodyfikowano!!");
                    Form1.filldgTime(dgGridCzas);
                    txtCzas.ReadOnly = true;
                    txtPrzedmiot.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Nie można zostawić pustego  ");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sekundy = 0; minuty = 0; godziny = 0;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPause.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            btnPause.Text = "Pauza";

            LoadSchema();
            if (txtCzas.Text == "") { }
            else
            {
                txtCzas.Visible = false;
                pomiarCzasu = Convert.ToInt32(txtCzas.Text);
                minuty = pomiarCzasu;
                timer1.Interval = 1000;
                timer1.Start();
                Form1 nowa = new Form1();
                SmallForm();
                this.Location = new System.Drawing.Point(0, 0);
            }
        }

        private void btnafterAdd_Click(object sender, EventArgs e)
        {

            btnAddCzas.Visible = true;
            btnAddPrzedmiot.Visible = true;
            txtTimeAdd.Visible = true;
            txtPrzedmiotAdd.Visible = true;
            BigForm();
        }

        public void Display(Label nazwa)
        {


            if (minuty >= 60)
            {
                godziny++;
                minuty = minuty - 60;
            }
            if (minuty == 00 && godziny > 0)
            {
                godziny--;
                minuty = 59;
            }
            if (sekundy == 00 && minuty > 0)
            {
                minuty--;
                sekundy = 59;
            }
            else { sekundy--; }
            nazwa.Text = godziny + ":" + minuty + ":" + sekundy;

            if (sekundy < 10 && godziny < 10 && minuty < 10)
                nazwa.Text = "0" + godziny + ":" + "0" + minuty + ":" + "0" + sekundy;
            if (minuty < 10 && godziny < 10 && sekundy > 9)
                nazwa.Text = "0" + godziny + ":" + "0" + minuty + ":" + sekundy;

            if (godziny < 10 && sekundy < 10 && minuty > 9)
                nazwa.Text = "0" + godziny + ":" + minuty + ":" + 0 + sekundy;
            if (godziny < 10 && sekundy > 9 && minuty > 9)
                nazwa.Text = "0" + godziny + ":" + minuty + ":" + sekundy;
           
        }

        public void LoadSchema()
        {
            if (this.Width == 700)
            {
                foreach (Control p in gbPrzedmiot.Controls)
                {
                    if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text != "")
                    {
                        txtPrzedmiot.Text = p.Text;
                        p.Text = "";
                        break;
                    }
                }
                foreach (Control p in gbCzas.Controls)
                {
                    if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text != "")
                    {

                        dodajCzas += int.Parse(p.Text);
                        txtCzas.Text = p.Text;
                        p.Text = "";
                        break;

                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Display(lblWyswietlacz);

            if (godziny == 0 && minuty == 0 && sekundy == 0)
            {
                this.Location = new System.Drawing.Point(500, 200);
                timer1.Enabled = false;
                foreach (Control p in gbCzas.Controls)
                {
                    if ((p is TextBox) && ((TextBox)p).ReadOnly == false && p.Text != "")
                    {
                        LoadSchema();
                        SchemaForm();
                        txtPrzedmiot.Text = "Ukonczona fragment Schematu".ToUpper();
                        break;
                    }
                    else if ((p is TextBox) && ((TextBox)p).ReadOnly == true)
                    {
                        LoadSchema();
                        MiddleForm();
                        btnSchema.Text = "Plan";
                        break;
                    }
                }
                lblEnd.Visible = true;
                txtCzas.Visible = true;

                if (txtPrzedmiot.Text == "Ukonczona fragment Schematu".ToUpper()) { (new System.Media.SoundPlayer("Computer_Magic.wav")).Play(); }
                else
                {
                    int przeliczona;
                    var z = FunctionClassSubject.getById(idSubject);

                    if (int.TryParse(txtCzas.Text, out przeliczona))
                    {
                        z.Statystyka += przeliczona;
                        FunctionClassSubject.update(z);
                        filldgSubject(dgGridPrzedmiot);
                    }
                    else
                    {
                        MessageBox.Show("Proszę wpisać cyfrę");
                    }
                    txtCzas.Text = "";
                    txtPrzedmiot.Text = "Koniec";
                    (new System.Media.SoundPlayer("Computer_Magic.wav")).Play();
                }
                lblWyswietlaczSchema.Text = dodajCzas.ToString() + "";
            }
        }
        #endregion

        public void MiddleForm()
        {
            this.Width = 320;
            this.Height = 369;
        }

        public void BigForm()
        {
            this.Width = 320;
            this.Height = 475;
        }

        public void SmallForm()
        {
            this.Width = 320;
            this.Height = 160;
        }

        public void ClearMainField()
        {
            txtTimeAdd.Text = "";
            txtPrzedmiotAdd.Text = "";
            txtPrzedmiot.Text = "";
            txtCzas.Text = "";
        }

        #region Schema And Function 

        public void SchemaForm()
        {
            this.Width = 700;
            this.Height = 372;
        }

        public void UnlockBlockField(TextBox nazwa)
        {
            if (nazwa.ReadOnly == true) nazwa.ReadOnly = false;
            else if (nazwa.ReadOnly == false && nazwa.Text == "") nazwa.ReadOnly = true;
        }

        public void ClearFieldSchema(TextBox nazwa)
        {
            if (nazwa.ReadOnly == false)
                nazwa.Text = "";
        }

        public void AddSharp(TextBox nazwa)
        {
            if (nazwa.Text == "" && nazwa.ReadOnly == true) nazwa.Text = "+";
        }

        private void txtSubjectOne_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectOne);
            ClearFieldSchema(txtSubjectOne);
            AddSharp(txtSubjectOne);
        }

        private void txtSubjectTwo_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectTwo);
            ClearFieldSchema(txtSubjectTwo);
            AddSharp(txtSubjectTwo);
        }

        private void txtSubjectThree_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectThree);
            ClearFieldSchema(txtSubjectThree);
            AddSharp(txtSubjectThree);
        }

        private void txtSubjectFour_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectFour);
            ClearFieldSchema(txtSubjectFour);
            AddSharp(txtSubjectFour);
        }

        private void txtSubjectFive_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectFive);
            ClearFieldSchema(txtSubjectFive);
            AddSharp(txtSubjectFive);
        }

        private void txtSubjectSix_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectSix);
            ClearFieldSchema(txtSubjectSix);
            AddSharp(txtSubjectSix);
        }

        private void txtSubjectSeven_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectSeven);
            ClearFieldSchema(txtSubjectSeven);
            AddSharp(txtSubjectSeven);
        }

        private void txtSubjectEight_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectEight);
            ClearFieldSchema(txtSubjectEight);
            AddSharp(txtSubjectEight);
        }

        private void txtSubjectNine_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtSubjectNine);
            ClearFieldSchema(txtSubjectNine);
            AddSharp(txtSubjectNine);
        }

        private void txtTimeOne_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeOne);
            ClearFieldSchema(txtTimeOne);
            AddSharp(txtTimeOne);
        }

        private void txtTimeTwo_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeTwo);
            ClearFieldSchema(txtTimeTwo);
            AddSharp(txtTimeTwo);
        }

        private void txtTimeThree_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeThree);
            ClearFieldSchema(txtTimeThree);
            AddSharp(txtTimeThree);
        }

        private void txtTimeFour_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeFour);
            ClearFieldSchema(txtTimeFour);
            AddSharp(txtTimeFour);
        }

        private void txtTimeFive_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeFive);
            ClearFieldSchema(txtTimeFive);
            AddSharp(txtTimeFive);
        }

        private void txtTimeSix_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeSix);
            ClearFieldSchema(txtTimeSix);
            AddSharp(txtTimeSix);
        }

        private void txtTimeSeven_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeSeven);
            ClearFieldSchema(txtTimeSeven);
            AddSharp(txtTimeSeven);
        }

        private void txtTimeEight_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeEight);
            ClearFieldSchema(txtTimeEight);
            AddSharp(txtTimeEight);
        }

        private void txtTimeNine_Click(object sender, EventArgs e)
        {
            UnlockBlockField(txtTimeNine);
            ClearFieldSchema(txtTimeNine);
            AddSharp(txtTimeNine);
        }

        #endregion
    }
}