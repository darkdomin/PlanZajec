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

        int idSubject, idTime, seconds = 0, minutes = 0, hours = 0, timeMeasurement, addTime = 0;

        public Form1()
        {
            InitializeComponent();
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
                if (r.SubjectDescription == txtSubjectAdd.Text)
                {
                    MessageBox.Show("Taka nazwa już istnieje w bazie danych");
                    txtSubjectAdd.Text = "";
                }
            }

            if (txtSubjectAdd.Text != "")
            {
                Subject model = new Subject();
                model.SubjectDescription = txtSubjectAdd.Text;
                FunctionClassSubject.add(model);
                filldgSubject(dgGridSubject);
                MessageBox.Show("Dodano przedmiot!!!");
                txtSubjectAdd.Text = "";
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
                filldgTime(dgGridTime);
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
            if (lblDisplay.Text == "00:00:00" && timer1.Enabled == false)
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
            timeMeasurement = 0;
            txtSubject.Text = "";
            txtTime.Text = "";
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
                lblDisplaySchema.Visible = false;
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
                idSubject = Convert.ToInt32(dgGridSubject.Rows[e.RowIndex].Cells[0].Value);
                if (this.Width == 700)
                {
                    foreach (Control p in gbSubject.Controls)
                    {
                        if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text == "")
                        {
                            p.Text = dgGridSubject.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
                            break;
                        }
                    }
                }
                else
                {
                    txtSubject.Text = dgGridSubject.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MiddleForm();
                }
            }
          dgGridSubject.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgGridSubject.Rows.ToString().ToUpper();
            dgGridSubject.Columns.Add("id", "Id");
            dgGridSubject.Columns.Add("imie", "Przedmiot");
            dgGridSubject.Columns.Add("stat", "Statystyka w min");
            dgGridTime.Columns.Add("pochodzenie", "Id");
            dgGridTime.Columns.Add("telefon", "Czas");

            dgGridSubject.Columns[0].Visible = false;
            dgGridTime.Columns[0].Visible = false;
            filldgSubject(dgGridSubject);
            filldgTime(dgGridTime);
        }

        private void dgViewCzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTime = Convert.ToInt32(dgGridTime.Rows[e.RowIndex].Cells[0].Value);
                if (this.Width == 700)
                {
                    foreach (Control p in gbTime.Controls)
                    {
                        if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text == "")
                        {
                            p.Text = dgGridTime.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
                            break;
                        }
                    }
                }
                else
                {
                    txtTime.Text = dgGridTime.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MiddleForm();
                }
                dgGridTime.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            }
            // txtTime.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text != "")
            {
                var z = FunctionClassSubject.getById(idSubject);
                FunctionClassSubject.del(z.Id);
                MessageBox.Show("Usnięty!!");
                filldgSubject(dgGridSubject);
                txtSubject.Text = "";
                if (txtSubject.Text == "") dgGridSubject.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            }
            else if (txtTime.Text != "")
            {
                var zm = FunctionClassTime.getById(idTime);
                FunctionClassTime.del(zm.Id);
                MessageBox.Show("Usnięty!!");
                Form1.filldgTime(dgGridTime);
                txtTime.Text = "";
                dgGridTime.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
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
            txtTime.Visible = true;
            lblDisplay.Text = "00:00:00";
            timeMeasurement = 0;
            txtTime.Text = "";
            txtSubject.Text = "Zakończone przed czasem".ToUpper();
            this.Location = new System.Drawing.Point(500, 200);
            btnSchema.Text = "Plan";
            this.btnPause.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            if (txtSubject.ReadOnly == true)
            {
                txtSubject.ReadOnly = false;
                txtTime.ReadOnly = false;
            }
            else
            {
                if (txtSubject.Text != "")
                {
                    var z = FunctionClassSubject.getById(idSubject);
                    z.SubjectDescription = txtSubject.Text;
                    FunctionClassSubject.update(z);
                    MessageBox.Show("Zmodyfikowano!!");
                    filldgSubject(dgGridSubject);
                    txtSubject.ReadOnly = true;
                    txtTime.ReadOnly = true;
                }
                else if (txtTime.Text != "")
                {
                    var zm = FunctionClassTime.getById(idTime);
                    zm.TimeDuration = int.Parse(txtTime.Text);
                    FunctionClassTime.update(zm);
                    MessageBox.Show("Zmodyfikowano!!");
                    Form1.filldgTime(dgGridTime);
                    txtTime.ReadOnly = true;
                    txtSubject.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Nie można zostawić pustego  ");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            seconds = 0; minutes = 0; hours = 0;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPause.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            btnPause.Text = "Pauza";

            LoadSchema();
            if (txtTime.Text == "") { }
            else
            {
                txtTime.Visible = false;
                timeMeasurement = Convert.ToInt32(txtTime.Text);
                minutes = timeMeasurement;
                timer1.Interval = 1000;
                timer1.Start();
                Form1 nowa = new Form1();
                SmallForm();
                this.Location = new System.Drawing.Point(0, 0);
            }
        }

        private void btnafterAdd_Click(object sender, EventArgs e)
        {

            btnAddTime.Visible = true;
            btnAddPrzedmiot.Visible = true;
            txtTimeAdd.Visible = true;
            txtSubjectAdd.Visible = true;
            BigForm();
        }

        public void Display(Label nazwa)
        {
            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (minutes == 00 && hours > 0)
            {
                hours--;
                minutes = 59;
            }
            if (seconds == 00 && minutes > 0)
            {
                minutes--;
                seconds = 59;
            }
            else { seconds--; }
            nazwa.Text = hours + ":" + minutes + ":" + seconds;

            if (seconds < 10 && hours < 10 && minutes < 10)
                nazwa.Text = "0" + hours + ":" + "0" + minutes + ":" + "0" + seconds;
            if (minutes < 10 && hours < 10 && seconds > 9)
                nazwa.Text = "0" + hours + ":" + "0" + minutes + ":" + seconds;

            if (hours < 10 && seconds < 10 && minutes > 9)
                nazwa.Text = "0" + hours + ":" + minutes + ":" + 0 + seconds;
            if (hours < 10 && seconds > 9 && minutes > 9)
                nazwa.Text = "0" + hours + ":" + minutes + ":" + seconds;
        }

        public void LoadSchema()
        {
            if (this.Width == 700)
            {
                foreach (Control p in gbSubject.Controls)
                {
                    if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text != "")
                    {
                        txtSubject.Text = p.Text;
                        p.Text = "";
                        break;
                    }
                }
                foreach (Control p in gbTime.Controls)
                {
                    if (p is TextBox && ((TextBox)p).ReadOnly == false && p.Text != "")
                    {

                        addTime += int.Parse(p.Text);
                        txtTime.Text = p.Text;
                        p.Text = "";
                        break;

                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Display(lblDisplay);

            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                this.Location = new System.Drawing.Point(500, 200);
                timer1.Enabled = false;
                foreach (Control p in gbTime.Controls)
                {
                    if ((p is TextBox) && ((TextBox)p).ReadOnly == false && p.Text != "")
                    {
                        LoadSchema();
                        SchemaForm();
                        txtSubject.Text = "Ukonczona fragment Schematu".ToUpper();
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
                txtTime.Visible = true;

                if (txtSubject.Text == "Ukonczona fragment Schematu".ToUpper()) { (new System.Media.SoundPlayer("Computer_Magic.wav")).Play(); }
                else
                {
                    int przeliczona;
                    var z = FunctionClassSubject.getById(idSubject);

                    if (int.TryParse(txtTime.Text, out przeliczona))
                    {
                        z.Statystyka += przeliczona;
                        FunctionClassSubject.update(z);
                        filldgSubject(dgGridSubject);
                    }
                    else
                    {
                        MessageBox.Show("Proszę wpisać cyfrę");
                    }
                    txtTime.Text = "";
                    txtSubject.Text = "Koniec";
                    (new System.Media.SoundPlayer("Computer_Magic.wav")).Play();
                }
                lblDisplaySchema.Text = addTime.ToString() + "";
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
            txtSubjectAdd.Text = "";
            txtSubject.Text = "";
            txtTime.Text = "";
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