namespace Przychodnia_Mateusz_Oleksik
{
    partial class FormPracownicy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodaj_pracownika = new System.Windows.Forms.Button();
            this.edytuj_pracownika = new System.Windows.Forms.Button();
            this.usuń_pracownika = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonNadajUprawnienia = new System.Windows.Forms.Button();
            this.buttonOdbierzUprawnienia = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.formPacjenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPacjenciBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(445, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imię";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data rozpoczęcia pracy";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // dodaj_pracownika
            // 
            this.dodaj_pracownika.Location = new System.Drawing.Point(457, 278);
            this.dodaj_pracownika.Name = "dodaj_pracownika";
            this.dodaj_pracownika.Size = new System.Drawing.Size(210, 52);
            this.dodaj_pracownika.TabIndex = 1;
            this.dodaj_pracownika.Text = "Dodaj pracownika";
            this.dodaj_pracownika.UseVisualStyleBackColor = true;
            this.dodaj_pracownika.Click += new System.EventHandler(this.dodaj_pracownika_Click);
            // 
            // edytuj_pracownika
            // 
            this.edytuj_pracownika.Location = new System.Drawing.Point(457, 336);
            this.edytuj_pracownika.Name = "edytuj_pracownika";
            this.edytuj_pracownika.Size = new System.Drawing.Size(210, 52);
            this.edytuj_pracownika.TabIndex = 2;
            this.edytuj_pracownika.Text = "Edytuj pracownika";
            this.edytuj_pracownika.UseVisualStyleBackColor = true;
            this.edytuj_pracownika.Click += new System.EventHandler(this.edytuj_pracownika_Click);
            // 
            // usuń_pracownika
            // 
            this.usuń_pracownika.Location = new System.Drawing.Point(457, 394);
            this.usuń_pracownika.Name = "usuń_pracownika";
            this.usuń_pracownika.Size = new System.Drawing.Size(210, 52);
            this.usuń_pracownika.TabIndex = 3;
            this.usuń_pracownika.Text = "Usuń pracownika";
            this.usuń_pracownika.UseVisualStyleBackColor = true;
            this.usuń_pracownika.Click += new System.EventHandler(this.usuń_pracownika_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 420);
            this.listBox1.TabIndex = 4;
            // 
            // buttonNadajUprawnienia
            // 
            this.buttonNadajUprawnienia.Location = new System.Drawing.Point(212, 70);
            this.buttonNadajUprawnienia.Name = "buttonNadajUprawnienia";
            this.buttonNadajUprawnienia.Size = new System.Drawing.Size(166, 34);
            this.buttonNadajUprawnienia.TabIndex = 5;
            this.buttonNadajUprawnienia.Text = "Nadaj uprawnienia do wykonywania czynności medycznej";
            this.buttonNadajUprawnienia.UseVisualStyleBackColor = true;
            this.buttonNadajUprawnienia.Click += new System.EventHandler(this.buttonNadajUprawnienia_Click);
            // 
            // buttonOdbierzUprawnienia
            // 
            this.buttonOdbierzUprawnienia.Location = new System.Drawing.Point(212, 110);
            this.buttonOdbierzUprawnienia.Name = "buttonOdbierzUprawnienia";
            this.buttonOdbierzUprawnienia.Size = new System.Drawing.Size(166, 37);
            this.buttonOdbierzUprawnienia.TabIndex = 6;
            this.buttonOdbierzUprawnienia.Text = "Odbierz uprawnienia do wykonywania czynności medycznej";
            this.buttonOdbierzUprawnienia.UseVisualStyleBackColor = true;
            this.buttonOdbierzUprawnienia.Click += new System.EventHandler(this.buttonOdbierzUprawnienia_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // formPacjenciBindingSource
            // 
            this.formPacjenciBindingSource.DataSource = typeof(Przychodnia_Mateusz_Oleksik.FormPacjenci);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.usuń_pracownika);
            this.groupBox1.Controls.Add(this.edytuj_pracownika);
            this.groupBox1.Controls.Add(this.dodaj_pracownika);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 461);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pracownicy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.buttonOdbierzUprawnienia);
            this.groupBox2.Controls.Add(this.buttonNadajUprawnienia);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(690, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 461);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uprawnienia pracowników do czynności medycznych";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz czynność medyczną:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Uprawnienia pracownika:";
            // 
            // FormPracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPracownicy";
            this.Text = "FormPracownicy";
            this.Load += new System.EventHandler(this.Pracownik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPacjenciBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodaj_pracownika;
        private System.Windows.Forms.Button edytuj_pracownika;
        private System.Windows.Forms.Button usuń_pracownika;
        private System.Windows.Forms.BindingSource formPacjenciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNadajUprawnienia;
        private System.Windows.Forms.Button buttonOdbierzUprawnienia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}