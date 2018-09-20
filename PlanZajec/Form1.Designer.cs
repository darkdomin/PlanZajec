namespace PlanZajec
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddPrzedmiot = new System.Windows.Forms.Button();
            this.txtPrzedmiotAdd = new System.Windows.Forms.TextBox();
            this.btnAddCzas = new System.Windows.Forms.Button();
            this.txtTimeAdd = new System.Windows.Forms.TextBox();
            this.dgGridPrzedmiot = new System.Windows.Forms.DataGridView();
            this.dgGridCzas = new System.Windows.Forms.DataGridView();
            this.txtPrzedmiot = new System.Windows.Forms.TextBox();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblWyswietlacz = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnafterAdd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtSubjectEight = new System.Windows.Forms.TextBox();
            this.txtTimeNine = new System.Windows.Forms.TextBox();
            this.txtSubjectSeven = new System.Windows.Forms.TextBox();
            this.txtTimeEight = new System.Windows.Forms.TextBox();
            this.txtTimeSix = new System.Windows.Forms.TextBox();
            this.txtSubjectFour = new System.Windows.Forms.TextBox();
            this.txtTimeSeven = new System.Windows.Forms.TextBox();
            this.txtSubjectFive = new System.Windows.Forms.TextBox();
            this.txtTimeFour = new System.Windows.Forms.TextBox();
            this.txtSubjectSix = new System.Windows.Forms.TextBox();
            this.txtTimeFive = new System.Windows.Forms.TextBox();
            this.txtSubjectNine = new System.Windows.Forms.TextBox();
            this.txtTimeTwo = new System.Windows.Forms.TextBox();
            this.txtSubjectTwo = new System.Windows.Forms.TextBox();
            this.txtTimeThree = new System.Windows.Forms.TextBox();
            this.txtSubjectThree = new System.Windows.Forms.TextBox();
            this.txtSubjectOne = new System.Windows.Forms.TextBox();
            this.txtTimeOne = new System.Windows.Forms.TextBox();
            this.btnSchema = new System.Windows.Forms.Button();
            this.gbPrzedmiot = new System.Windows.Forms.GroupBox();
            this.gbCzas = new System.Windows.Forms.GroupBox();
            this.lblWyswietlaczSchema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridPrzedmiot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridCzas)).BeginInit();
            this.gbPrzedmiot.SuspendLayout();
            this.gbCzas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPrzedmiot
            // 
            this.btnAddPrzedmiot.Location = new System.Drawing.Point(12, 382);
            this.btnAddPrzedmiot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPrzedmiot.Name = "btnAddPrzedmiot";
            this.btnAddPrzedmiot.Size = new System.Drawing.Size(89, 43);
            this.btnAddPrzedmiot.TabIndex = 0;
            this.btnAddPrzedmiot.Text = "Dodaj Przedmiot";
            this.btnAddPrzedmiot.UseVisualStyleBackColor = true;
            this.btnAddPrzedmiot.Visible = false;
            this.btnAddPrzedmiot.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtPrzedmiotAdd
            // 
            this.txtPrzedmiotAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzedmiotAdd.Location = new System.Drawing.Point(107, 394);
            this.txtPrzedmiotAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrzedmiotAdd.Name = "txtPrzedmiotAdd";
            this.txtPrzedmiotAdd.Size = new System.Drawing.Size(183, 31);
            this.txtPrzedmiotAdd.TabIndex = 1;
            this.txtPrzedmiotAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrzedmiotAdd.Visible = false;
            // 
            // btnAddCzas
            // 
            this.btnAddCzas.Location = new System.Drawing.Point(12, 332);
            this.btnAddCzas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCzas.Name = "btnAddCzas";
            this.btnAddCzas.Size = new System.Drawing.Size(89, 45);
            this.btnAddCzas.TabIndex = 2;
            this.btnAddCzas.Text = "Dodaj Czas";
            this.btnAddCzas.UseVisualStyleBackColor = true;
            this.btnAddCzas.Visible = false;
            this.btnAddCzas.Click += new System.EventHandler(this.btnAddCzas_Click);
            // 
            // txtTimeAdd
            // 
            this.txtTimeAdd.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeAdd.Location = new System.Drawing.Point(107, 344);
            this.txtTimeAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeAdd.Name = "txtTimeAdd";
            this.txtTimeAdd.Size = new System.Drawing.Size(53, 33);
            this.txtTimeAdd.TabIndex = 3;
            this.txtTimeAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeAdd.Visible = false;
            // 
            // dgGridPrzedmiot
            // 
            this.dgGridPrzedmiot.AllowUserToAddRows = false;
            this.dgGridPrzedmiot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGridPrzedmiot.BackgroundColor = System.Drawing.Color.White;
            this.dgGridPrzedmiot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGridPrzedmiot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGridPrzedmiot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridPrzedmiot.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGridPrzedmiot.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgGridPrzedmiot.GridColor = System.Drawing.Color.Silver;
            this.dgGridPrzedmiot.Location = new System.Drawing.Point(12, 161);
            this.dgGridPrzedmiot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgGridPrzedmiot.Name = "dgGridPrzedmiot";
            this.dgGridPrzedmiot.ReadOnly = true;
            this.dgGridPrzedmiot.RowHeadersVisible = false;
            this.dgGridPrzedmiot.RowTemplate.ReadOnly = true;
            this.dgGridPrzedmiot.Size = new System.Drawing.Size(231, 160);
            this.dgGridPrzedmiot.TabIndex = 4;
            this.dgGridPrzedmiot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewPrzedmiot_CellClick);
            // 
            // dgGridCzas
            // 
            this.dgGridCzas.AllowUserToAddRows = false;
            this.dgGridCzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGridCzas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGridCzas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgGridCzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGridCzas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgGridCzas.GridColor = System.Drawing.Color.Silver;
            this.dgGridCzas.Location = new System.Drawing.Point(249, 161);
            this.dgGridCzas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgGridCzas.Name = "dgGridCzas";
            this.dgGridCzas.ReadOnly = true;
            this.dgGridCzas.RowHeadersVisible = false;
            this.dgGridCzas.Size = new System.Drawing.Size(41, 160);
            this.dgGridCzas.TabIndex = 5;
            this.dgGridCzas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewCzas_CellClick);
            // 
            // txtPrzedmiot
            // 
            this.txtPrzedmiot.BackColor = System.Drawing.Color.Black;
            this.txtPrzedmiot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrzedmiot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzedmiot.ForeColor = System.Drawing.Color.SlateGray;
            this.txtPrzedmiot.Location = new System.Drawing.Point(12, 82);
            this.txtPrzedmiot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrzedmiot.Name = "txtPrzedmiot";
            this.txtPrzedmiot.ReadOnly = true;
            this.txtPrzedmiot.Size = new System.Drawing.Size(278, 31);
            this.txtPrzedmiot.TabIndex = 6;
            this.txtPrzedmiot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrzedmiot.WordWrap = false;
            // 
            // txtCzas
            // 
            this.txtCzas.BackColor = System.Drawing.Color.Black;
            this.txtCzas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCzas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzas.ForeColor = System.Drawing.Color.White;
            this.txtCzas.Location = new System.Drawing.Point(240, 40);
            this.txtCzas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.ReadOnly = true;
            this.txtCzas.Size = new System.Drawing.Size(35, 24);
            this.txtCzas.TabIndex = 7;
            this.txtCzas.Visible = false;
            this.txtCzas.WordWrap = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 125);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 22);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModification
            // 
            this.btnModification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModification.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModification.ForeColor = System.Drawing.Color.White;
            this.btnModification.Location = new System.Drawing.Point(83, 125);
            this.btnModification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(65, 22);
            this.btnModification.TabIndex = 9;
            this.btnModification.Text = "Modyfikuj";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.btnModification_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 31);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(107, 10);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(96, 31);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pauza";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblWyswietlacz
            // 
            this.lblWyswietlacz.AutoSize = true;
            this.lblWyswietlacz.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyswietlacz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWyswietlacz.Location = new System.Drawing.Point(113, 47);
            this.lblWyswietlacz.Name = "lblWyswietlacz";
            this.lblWyswietlacz.Size = new System.Drawing.Size(80, 23);
            this.lblWyswietlacz.TabIndex = 13;
            this.lblWyswietlacz.Text = "00:00:00";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnd.Location = new System.Drawing.Point(121, 46);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 24);
            this.lblEnd.TabIndex = 14;
            // 
            // btnafterAdd
            // 
            this.btnafterAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnafterAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnafterAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnafterAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnafterAdd.ForeColor = System.Drawing.Color.White;
            this.btnafterAdd.Location = new System.Drawing.Point(154, 125);
            this.btnafterAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnafterAdd.Name = "btnafterAdd";
            this.btnafterAdd.Size = new System.Drawing.Size(65, 22);
            this.btnafterAdd.TabIndex = 15;
            this.btnafterAdd.Text = "Dodaj";
            this.btnafterAdd.UseVisualStyleBackColor = true;
            this.btnafterAdd.Click += new System.EventHandler(this.btnafterAdd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(223, 10);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 31);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // txtSubjectEight
            // 
            this.txtSubjectEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectEight.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectEight.Location = new System.Drawing.Point(6, 249);
            this.txtSubjectEight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectEight.Name = "txtSubjectEight";
            this.txtSubjectEight.ReadOnly = true;
            this.txtSubjectEight.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectEight.TabIndex = 17;
            this.txtSubjectEight.Text = "+";
            this.txtSubjectEight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectEight.WordWrap = false;
            this.txtSubjectEight.Click += new System.EventHandler(this.txtSubjectEight_Click);
            // 
            // txtTimeNine
            // 
            this.txtTimeNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeNine.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeNine.Location = new System.Drawing.Point(5, 292);
            this.txtTimeNine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeNine.Name = "txtTimeNine";
            this.txtTimeNine.ReadOnly = true;
            this.txtTimeNine.Size = new System.Drawing.Size(64, 31);
            this.txtTimeNine.TabIndex = 18;
            this.txtTimeNine.Text = "+";
            this.txtTimeNine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeNine.WordWrap = false;
            this.txtTimeNine.Click += new System.EventHandler(this.txtTimeNine_Click);
            // 
            // txtSubjectSeven
            // 
            this.txtSubjectSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectSeven.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectSeven.Location = new System.Drawing.Point(6, 214);
            this.txtSubjectSeven.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectSeven.Name = "txtSubjectSeven";
            this.txtSubjectSeven.ReadOnly = true;
            this.txtSubjectSeven.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectSeven.TabIndex = 19;
            this.txtSubjectSeven.Text = "+";
            this.txtSubjectSeven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectSeven.WordWrap = false;
            this.txtSubjectSeven.Click += new System.EventHandler(this.txtSubjectSeven_Click);
            // 
            // txtTimeEight
            // 
            this.txtTimeEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeEight.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeEight.Location = new System.Drawing.Point(5, 257);
            this.txtTimeEight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeEight.Name = "txtTimeEight";
            this.txtTimeEight.ReadOnly = true;
            this.txtTimeEight.Size = new System.Drawing.Size(64, 31);
            this.txtTimeEight.TabIndex = 20;
            this.txtTimeEight.Text = "+";
            this.txtTimeEight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeEight.WordWrap = false;
            this.txtTimeEight.Click += new System.EventHandler(this.txtTimeEight_Click);
            // 
            // txtTimeSix
            // 
            this.txtTimeSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeSix.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeSix.Location = new System.Drawing.Point(5, 187);
            this.txtTimeSix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeSix.Name = "txtTimeSix";
            this.txtTimeSix.ReadOnly = true;
            this.txtTimeSix.Size = new System.Drawing.Size(64, 31);
            this.txtTimeSix.TabIndex = 24;
            this.txtTimeSix.Text = "+";
            this.txtTimeSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeSix.WordWrap = false;
            this.txtTimeSix.Click += new System.EventHandler(this.txtTimeSix_Click);
            // 
            // txtSubjectFour
            // 
            this.txtSubjectFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectFour.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectFour.Location = new System.Drawing.Point(6, 109);
            this.txtSubjectFour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectFour.Name = "txtSubjectFour";
            this.txtSubjectFour.ReadOnly = true;
            this.txtSubjectFour.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectFour.TabIndex = 23;
            this.txtSubjectFour.Text = "+";
            this.txtSubjectFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectFour.WordWrap = false;
            this.txtSubjectFour.Click += new System.EventHandler(this.txtSubjectFour_Click);
            // 
            // txtTimeSeven
            // 
            this.txtTimeSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeSeven.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeSeven.Location = new System.Drawing.Point(5, 222);
            this.txtTimeSeven.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeSeven.Name = "txtTimeSeven";
            this.txtTimeSeven.ReadOnly = true;
            this.txtTimeSeven.Size = new System.Drawing.Size(64, 31);
            this.txtTimeSeven.TabIndex = 22;
            this.txtTimeSeven.Text = "+";
            this.txtTimeSeven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeSeven.WordWrap = false;
            this.txtTimeSeven.Click += new System.EventHandler(this.txtTimeSeven_Click);
            // 
            // txtSubjectFive
            // 
            this.txtSubjectFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectFive.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectFive.Location = new System.Drawing.Point(6, 144);
            this.txtSubjectFive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectFive.Name = "txtSubjectFive";
            this.txtSubjectFive.ReadOnly = true;
            this.txtSubjectFive.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectFive.TabIndex = 21;
            this.txtSubjectFive.Text = "+";
            this.txtSubjectFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectFive.WordWrap = false;
            this.txtSubjectFive.Click += new System.EventHandler(this.txtSubjectFive_Click);
            // 
            // txtTimeFour
            // 
            this.txtTimeFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeFour.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeFour.Location = new System.Drawing.Point(5, 117);
            this.txtTimeFour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeFour.Name = "txtTimeFour";
            this.txtTimeFour.ReadOnly = true;
            this.txtTimeFour.Size = new System.Drawing.Size(64, 31);
            this.txtTimeFour.TabIndex = 28;
            this.txtTimeFour.Text = "+";
            this.txtTimeFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeFour.WordWrap = false;
            this.txtTimeFour.Click += new System.EventHandler(this.txtTimeFour_Click);
            // 
            // txtSubjectSix
            // 
            this.txtSubjectSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectSix.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectSix.Location = new System.Drawing.Point(6, 179);
            this.txtSubjectSix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectSix.Name = "txtSubjectSix";
            this.txtSubjectSix.ReadOnly = true;
            this.txtSubjectSix.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectSix.TabIndex = 27;
            this.txtSubjectSix.Text = "+";
            this.txtSubjectSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectSix.WordWrap = false;
            this.txtSubjectSix.Click += new System.EventHandler(this.txtSubjectSix_Click);
            // 
            // txtTimeFive
            // 
            this.txtTimeFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeFive.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeFive.Location = new System.Drawing.Point(5, 152);
            this.txtTimeFive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeFive.Name = "txtTimeFive";
            this.txtTimeFive.ReadOnly = true;
            this.txtTimeFive.Size = new System.Drawing.Size(64, 31);
            this.txtTimeFive.TabIndex = 26;
            this.txtTimeFive.Text = "+";
            this.txtTimeFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeFive.WordWrap = false;
            this.txtTimeFive.Click += new System.EventHandler(this.txtTimeFive_Click);
            // 
            // txtSubjectNine
            // 
            this.txtSubjectNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectNine.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectNine.Location = new System.Drawing.Point(6, 284);
            this.txtSubjectNine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectNine.Name = "txtSubjectNine";
            this.txtSubjectNine.ReadOnly = true;
            this.txtSubjectNine.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectNine.TabIndex = 25;
            this.txtSubjectNine.Text = "+";
            this.txtSubjectNine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectNine.WordWrap = false;
            this.txtSubjectNine.Click += new System.EventHandler(this.txtSubjectNine_Click);
            // 
            // txtTimeTwo
            // 
            this.txtTimeTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeTwo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeTwo.Location = new System.Drawing.Point(5, 47);
            this.txtTimeTwo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeTwo.Name = "txtTimeTwo";
            this.txtTimeTwo.ReadOnly = true;
            this.txtTimeTwo.Size = new System.Drawing.Size(64, 31);
            this.txtTimeTwo.TabIndex = 32;
            this.txtTimeTwo.Text = "+";
            this.txtTimeTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeTwo.WordWrap = false;
            this.txtTimeTwo.Click += new System.EventHandler(this.txtTimeTwo_Click);
            // 
            // txtSubjectTwo
            // 
            this.txtSubjectTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectTwo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectTwo.Location = new System.Drawing.Point(6, 39);
            this.txtSubjectTwo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectTwo.Name = "txtSubjectTwo";
            this.txtSubjectTwo.ReadOnly = true;
            this.txtSubjectTwo.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectTwo.TabIndex = 31;
            this.txtSubjectTwo.Text = "+";
            this.txtSubjectTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectTwo.WordWrap = false;
            this.txtSubjectTwo.Click += new System.EventHandler(this.txtSubjectTwo_Click);
            // 
            // txtTimeThree
            // 
            this.txtTimeThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeThree.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeThree.Location = new System.Drawing.Point(5, 82);
            this.txtTimeThree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeThree.Name = "txtTimeThree";
            this.txtTimeThree.ReadOnly = true;
            this.txtTimeThree.Size = new System.Drawing.Size(64, 31);
            this.txtTimeThree.TabIndex = 30;
            this.txtTimeThree.Text = "+";
            this.txtTimeThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeThree.WordWrap = false;
            this.txtTimeThree.Click += new System.EventHandler(this.txtTimeThree_Click);
            // 
            // txtSubjectThree
            // 
            this.txtSubjectThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectThree.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectThree.Location = new System.Drawing.Point(6, 74);
            this.txtSubjectThree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectThree.Name = "txtSubjectThree";
            this.txtSubjectThree.ReadOnly = true;
            this.txtSubjectThree.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectThree.TabIndex = 29;
            this.txtSubjectThree.Text = "+";
            this.txtSubjectThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectThree.WordWrap = false;
            this.txtSubjectThree.Click += new System.EventHandler(this.txtSubjectThree_Click);
            // 
            // txtSubjectOne
            // 
            this.txtSubjectOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubjectOne.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectOne.Location = new System.Drawing.Point(6, 4);
            this.txtSubjectOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectOne.Name = "txtSubjectOne";
            this.txtSubjectOne.ReadOnly = true;
            this.txtSubjectOne.Size = new System.Drawing.Size(278, 31);
            this.txtSubjectOne.TabIndex = 35;
            this.txtSubjectOne.Text = "+";
            this.txtSubjectOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectOne.WordWrap = false;
            this.txtSubjectOne.Click += new System.EventHandler(this.txtSubjectOne_Click);
            // 
            // txtTimeOne
            // 
            this.txtTimeOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimeOne.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimeOne.Location = new System.Drawing.Point(5, 12);
            this.txtTimeOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeOne.Name = "txtTimeOne";
            this.txtTimeOne.ReadOnly = true;
            this.txtTimeOne.Size = new System.Drawing.Size(64, 31);
            this.txtTimeOne.TabIndex = 34;
            this.txtTimeOne.Text = "+";
            this.txtTimeOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeOne.WordWrap = false;
            this.txtTimeOne.Click += new System.EventHandler(this.txtTimeOne_Click);
            // 
            // btnSchema
            // 
            this.btnSchema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSchema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSchema.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSchema.ForeColor = System.Drawing.Color.White;
            this.btnSchema.Location = new System.Drawing.Point(225, 125);
            this.btnSchema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSchema.Name = "btnSchema";
            this.btnSchema.Size = new System.Drawing.Size(65, 22);
            this.btnSchema.TabIndex = 36;
            this.btnSchema.Text = "Plan";
            this.btnSchema.UseVisualStyleBackColor = true;
            this.btnSchema.Click += new System.EventHandler(this.btnSchema_Click_1);
            // 
            // gbPrzedmiot
            // 
            this.gbPrzedmiot.Controls.Add(this.txtSubjectOne);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectTwo);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectThree);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectFour);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectFive);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectSix);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectSeven);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectEight);
            this.gbPrzedmiot.Controls.Add(this.txtSubjectNine);
            this.gbPrzedmiot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrzedmiot.Location = new System.Drawing.Point(319, 6);
            this.gbPrzedmiot.Name = "gbPrzedmiot";
            this.gbPrzedmiot.Size = new System.Drawing.Size(284, 321);
            this.gbPrzedmiot.TabIndex = 37;
            this.gbPrzedmiot.TabStop = false;
            // 
            // gbCzas
            // 
            this.gbCzas.Controls.Add(this.txtTimeOne);
            this.gbCzas.Controls.Add(this.txtTimeTwo);
            this.gbCzas.Controls.Add(this.txtTimeThree);
            this.gbCzas.Controls.Add(this.txtTimeFour);
            this.gbCzas.Controls.Add(this.txtTimeFive);
            this.gbCzas.Controls.Add(this.txtTimeSix);
            this.gbCzas.Controls.Add(this.txtTimeSeven);
            this.gbCzas.Controls.Add(this.txtTimeEight);
            this.gbCzas.Controls.Add(this.txtTimeNine);
            this.gbCzas.Location = new System.Drawing.Point(605, -2);
            this.gbCzas.Name = "gbCzas";
            this.gbCzas.Size = new System.Drawing.Size(74, 329);
            this.gbCzas.TabIndex = 38;
            this.gbCzas.TabStop = false;
            // 
            // lblWyswietlaczSchema
            // 
            this.lblWyswietlaczSchema.AutoSize = true;
            this.lblWyswietlaczSchema.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyswietlaczSchema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWyswietlaczSchema.Location = new System.Drawing.Point(207, 47);
            this.lblWyswietlaczSchema.Name = "lblWyswietlaczSchema";
            this.lblWyswietlaczSchema.Size = new System.Drawing.Size(20, 23);
            this.lblWyswietlaczSchema.TabIndex = 39;
            this.lblWyswietlaczSchema.Text = "0";
            this.lblWyswietlaczSchema.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(300, 404);
            this.Controls.Add(this.lblWyswietlaczSchema);
            this.Controls.Add(this.gbCzas);
            this.Controls.Add(this.btnSchema);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnafterAdd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblWyswietlacz);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnModification);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.txtPrzedmiot);
            this.Controls.Add(this.dgGridCzas);
            this.Controls.Add(this.dgGridPrzedmiot);
            this.Controls.Add(this.txtTimeAdd);
            this.Controls.Add(this.btnAddCzas);
            this.Controls.Add(this.txtPrzedmiotAdd);
            this.Controls.Add(this.btnAddPrzedmiot);
            this.Controls.Add(this.gbPrzedmiot);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan Zajęć";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridPrzedmiot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridCzas)).EndInit();
            this.gbPrzedmiot.ResumeLayout(false);
            this.gbPrzedmiot.PerformLayout();
            this.gbCzas.ResumeLayout(false);
            this.gbCzas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPrzedmiot;
        private System.Windows.Forms.TextBox txtPrzedmiotAdd;
        private System.Windows.Forms.Button btnAddCzas;
        private System.Windows.Forms.TextBox txtTimeAdd;
        private System.Windows.Forms.DataGridView dgGridPrzedmiot;
        private System.Windows.Forms.DataGridView dgGridCzas;
        private System.Windows.Forms.TextBox txtPrzedmiot;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblWyswietlacz;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnafterAdd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtSubjectEight;
        private System.Windows.Forms.TextBox txtTimeNine;
        private System.Windows.Forms.TextBox txtSubjectSeven;
        private System.Windows.Forms.TextBox txtTimeEight;
        private System.Windows.Forms.TextBox txtTimeSix;
        private System.Windows.Forms.TextBox txtSubjectFour;
        private System.Windows.Forms.TextBox txtTimeSeven;
        private System.Windows.Forms.TextBox txtSubjectFive;
        private System.Windows.Forms.TextBox txtTimeFour;
        private System.Windows.Forms.TextBox txtSubjectSix;
        private System.Windows.Forms.TextBox txtTimeFive;
        private System.Windows.Forms.TextBox txtSubjectNine;
        private System.Windows.Forms.TextBox txtTimeTwo;
        private System.Windows.Forms.TextBox txtSubjectTwo;
        private System.Windows.Forms.TextBox txtTimeThree;
        private System.Windows.Forms.TextBox txtSubjectThree;
        private System.Windows.Forms.TextBox txtSubjectOne;
        private System.Windows.Forms.TextBox txtTimeOne;
        private System.Windows.Forms.Button btnSchema;
        private System.Windows.Forms.GroupBox gbPrzedmiot;
        private System.Windows.Forms.GroupBox gbCzas;
        private System.Windows.Forms.Label lblWyswietlaczSchema;
    }
}

