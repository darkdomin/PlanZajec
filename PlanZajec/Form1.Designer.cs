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
            this.btnAddPrzedmiot = new System.Windows.Forms.Button();
            this.txtPrzedmiotAdd = new System.Windows.Forms.TextBox();
            this.btnAddCzas = new System.Windows.Forms.Button();
            this.txtCzasAdd = new System.Windows.Forms.TextBox();
            this.dgGridPrzedmiot = new System.Windows.Forms.DataGridView();
            this.dgGridCzas = new System.Windows.Forms.DataGridView();
            this.txtPrzedmiot = new System.Windows.Forms.TextBox();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnModyfikuj = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblWyswietlacz = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnafterAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubjectOne = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridPrzedmiot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridCzas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPrzedmiot
            // 
            this.btnAddPrzedmiot.Location = new System.Drawing.Point(12, 376);
            this.btnAddPrzedmiot.Name = "btnAddPrzedmiot";
            this.btnAddPrzedmiot.Size = new System.Drawing.Size(89, 42);
            this.btnAddPrzedmiot.TabIndex = 0;
            this.btnAddPrzedmiot.Text = "Dodaj Przedmiot";
            this.btnAddPrzedmiot.UseVisualStyleBackColor = true;
            this.btnAddPrzedmiot.Visible = false;
            this.btnAddPrzedmiot.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrzedmiotAdd
            // 
            this.txtPrzedmiotAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzedmiotAdd.Location = new System.Drawing.Point(108, 389);
            this.txtPrzedmiotAdd.Name = "txtPrzedmiotAdd";
            this.txtPrzedmiotAdd.Size = new System.Drawing.Size(183, 29);
            this.txtPrzedmiotAdd.TabIndex = 1;
            this.txtPrzedmiotAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrzedmiotAdd.Visible = false;
            // 
            // btnAddCzas
            // 
            this.btnAddCzas.Location = new System.Drawing.Point(12, 322);
            this.btnAddCzas.Name = "btnAddCzas";
            this.btnAddCzas.Size = new System.Drawing.Size(89, 45);
            this.btnAddCzas.TabIndex = 2;
            this.btnAddCzas.Text = "Dodaj Czas";
            this.btnAddCzas.UseVisualStyleBackColor = true;
            this.btnAddCzas.Visible = false;
            this.btnAddCzas.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCzasAdd
            // 
            this.txtCzasAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzasAdd.Location = new System.Drawing.Point(107, 336);
            this.txtCzasAdd.Name = "txtCzasAdd";
            this.txtCzasAdd.Size = new System.Drawing.Size(53, 31);
            this.txtCzasAdd.TabIndex = 3;
            this.txtCzasAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCzasAdd.Visible = false;
            // 
            // dgGridPrzedmiot
            // 
            this.dgGridPrzedmiot.AllowUserToAddRows = false;
            this.dgGridPrzedmiot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGridPrzedmiot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridPrzedmiot.Location = new System.Drawing.Point(12, 161);
            this.dgGridPrzedmiot.Name = "dgGridPrzedmiot";
            this.dgGridPrzedmiot.RowHeadersVisible = false;
            this.dgGridPrzedmiot.RowTemplate.ReadOnly = true;
            this.dgGridPrzedmiot.Size = new System.Drawing.Size(184, 150);
            this.dgGridPrzedmiot.TabIndex = 4;
            this.dgGridPrzedmiot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewPrzedmiot_CellClick);
            // 
            // dgGridCzas
            // 
            this.dgGridCzas.AllowUserToAddRows = false;
            this.dgGridCzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGridCzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridCzas.Location = new System.Drawing.Point(202, 161);
            this.dgGridCzas.Name = "dgGridCzas";
            this.dgGridCzas.RowHeadersVisible = false;
            this.dgGridCzas.Size = new System.Drawing.Size(89, 150);
            this.dgGridCzas.TabIndex = 5;
            this.dgGridCzas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewCzas_CellClick);
            // 
            // txtPrzedmiot
            // 
            this.txtPrzedmiot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzedmiot.Location = new System.Drawing.Point(12, 76);
            this.txtPrzedmiot.Name = "txtPrzedmiot";
            this.txtPrzedmiot.ReadOnly = true;
            this.txtPrzedmiot.Size = new System.Drawing.Size(278, 29);
            this.txtPrzedmiot.TabIndex = 6;
            this.txtPrzedmiot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrzedmiot.WordWrap = false;
            // 
            // txtCzas
            // 
            this.txtCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzas.Location = new System.Drawing.Point(13, 41);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.ReadOnly = true;
            this.txtCzas.Size = new System.Drawing.Size(74, 29);
            this.txtCzas.TabIndex = 7;
            this.txtCzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCzas.WordWrap = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnModyfikuj
            // 
            this.btnModyfikuj.Location = new System.Drawing.Point(107, 114);
            this.btnModyfikuj.Name = "btnModyfikuj";
            this.btnModyfikuj.Size = new System.Drawing.Size(89, 38);
            this.btnModyfikuj.TabIndex = 9;
            this.btnModyfikuj.Text = "Modyfikuj";
            this.btnModyfikuj.UseVisualStyleBackColor = true;
            this.btnModyfikuj.Click += new System.EventHandler(this.btnModyfikuj_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(12, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pauza";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblWyswietlacz
            // 
            this.lblWyswietlacz.AutoSize = true;
            this.lblWyswietlacz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyswietlacz.Location = new System.Drawing.Point(113, 13);
            this.lblWyswietlacz.Name = "lblWyswietlacz";
            this.lblWyswietlacz.Size = new System.Drawing.Size(80, 24);
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
            this.btnafterAdd.Location = new System.Drawing.Point(202, 114);
            this.btnafterAdd.Name = "btnafterAdd";
            this.btnafterAdd.Size = new System.Drawing.Size(89, 38);
            this.btnafterAdd.TabIndex = 15;
            this.btnafterAdd.Text = "Dodaj";
            this.btnafterAdd.UseVisualStyleBackColor = true;
            this.btnafterAdd.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSubjectOne
            // 
            this.txtSubjectOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSubjectOne.Location = new System.Drawing.Point(296, 76);
            this.txtSubjectOne.Name = "txtSubjectOne";
            this.txtSubjectOne.ReadOnly = true;
            this.txtSubjectOne.Size = new System.Drawing.Size(278, 29);
            this.txtSubjectOne.TabIndex = 17;
            this.txtSubjectOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubjectOne.WordWrap = false;
            this.txtSubjectOne.Click += new System.EventHandler(this.txtSubjectOne_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(580, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 29);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 315);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSubjectOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnafterAdd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblWyswietlacz);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnModyfikuj);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.txtPrzedmiot);
            this.Controls.Add(this.dgGridCzas);
            this.Controls.Add(this.dgGridPrzedmiot);
            this.Controls.Add(this.txtCzasAdd);
            this.Controls.Add(this.btnAddCzas);
            this.Controls.Add(this.txtPrzedmiotAdd);
            this.Controls.Add(this.btnAddPrzedmiot);
            this.Name = "Form1";
            this.Text = "Plan Zajęć";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridPrzedmiot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridCzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPrzedmiot;
        private System.Windows.Forms.TextBox txtPrzedmiotAdd;
        private System.Windows.Forms.Button btnAddCzas;
        private System.Windows.Forms.TextBox txtCzasAdd;
        private System.Windows.Forms.DataGridView dgGridPrzedmiot;
        private System.Windows.Forms.DataGridView dgGridCzas;
        private System.Windows.Forms.TextBox txtPrzedmiot;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnModyfikuj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblWyswietlacz;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnafterAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubjectOne;
        private System.Windows.Forms.TextBox textBox2;
    }
}

