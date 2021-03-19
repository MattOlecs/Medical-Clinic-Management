namespace Przychodnia_Mateusz_Oleksik
{
    partial class FormPacjenci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOdbierzUprawnienieZdrowia = new System.Windows.Forms.Button();
            this.buttonNadajUprawnieneiZdrowia = new System.Windows.Forms.Button();
            this.comboBoxZdrowie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxZdrowie = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOdbierzUprawnienieDokumentacji = new System.Windows.Forms.Button();
            this.buttonNadajUprawnienieDokumentacji = new System.Windows.Forms.Button();
            this.comboBoxDokumentacja = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxDokumentacja = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(803, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imię";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PESEL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Rok urodzenia";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adres zamieszkania";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefon";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Adres email";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj pacjenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edytuj dane pacjenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(622, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Usuń pacjenta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 516);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 354);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.buttonOdbierzUprawnienieZdrowia);
            this.tabPage3.Controls.Add(this.buttonNadajUprawnieneiZdrowia);
            this.tabPage3.Controls.Add(this.comboBoxZdrowie);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.listBoxZdrowie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Upoważnienia do informacji o stanie zdrowia pacjenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pracownicy:";
            // 
            // buttonOdbierzUprawnienieZdrowia
            // 
            this.buttonOdbierzUprawnienieZdrowia.Location = new System.Drawing.Point(238, 95);
            this.buttonOdbierzUprawnienieZdrowia.Name = "buttonOdbierzUprawnienieZdrowia";
            this.buttonOdbierzUprawnienieZdrowia.Size = new System.Drawing.Size(235, 23);
            this.buttonOdbierzUprawnienieZdrowia.TabIndex = 8;
            this.buttonOdbierzUprawnienieZdrowia.Text = "Odbierz uprawnienie pracownikowi";
            this.buttonOdbierzUprawnienieZdrowia.UseVisualStyleBackColor = true;
            this.buttonOdbierzUprawnienieZdrowia.Click += new System.EventHandler(this.buttonOdbierzUprawnienieZdrowia_Click);
            // 
            // buttonNadajUprawnieneiZdrowia
            // 
            this.buttonNadajUprawnieneiZdrowia.Location = new System.Drawing.Point(238, 66);
            this.buttonNadajUprawnieneiZdrowia.Name = "buttonNadajUprawnieneiZdrowia";
            this.buttonNadajUprawnieneiZdrowia.Size = new System.Drawing.Size(235, 23);
            this.buttonNadajUprawnieneiZdrowia.TabIndex = 7;
            this.buttonNadajUprawnieneiZdrowia.Text = "Nadaj uprawnienie pracownikowi";
            this.buttonNadajUprawnieneiZdrowia.UseVisualStyleBackColor = true;
            this.buttonNadajUprawnieneiZdrowia.Click += new System.EventHandler(this.buttonNadajUprawnieneiZdrowia_Click);
            // 
            // comboBoxZdrowie
            // 
            this.comboBoxZdrowie.FormattingEnabled = true;
            this.comboBoxZdrowie.Location = new System.Drawing.Point(238, 28);
            this.comboBoxZdrowie.Name = "comboBoxZdrowie";
            this.comboBoxZdrowie.Size = new System.Drawing.Size(235, 21);
            this.comboBoxZdrowie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Upoważnieni pracownicy:";
            // 
            // listBoxZdrowie
            // 
            this.listBoxZdrowie.FormattingEnabled = true;
            this.listBoxZdrowie.Location = new System.Drawing.Point(7, 28);
            this.listBoxZdrowie.Name = "listBoxZdrowie";
            this.listBoxZdrowie.Size = new System.Drawing.Size(225, 290);
            this.listBoxZdrowie.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonOdbierzUprawnienieDokumentacji);
            this.tabPage1.Controls.Add(this.buttonNadajUprawnienieDokumentacji);
            this.tabPage1.Controls.Add(this.comboBoxDokumentacja);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.listBoxDokumentacja);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(795, 328);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Upoważnienia do dokumentacji pacjenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pracownicy:";
            // 
            // buttonOdbierzUprawnienieDokumentacji
            // 
            this.buttonOdbierzUprawnienieDokumentacji.Location = new System.Drawing.Point(238, 94);
            this.buttonOdbierzUprawnienieDokumentacji.Name = "buttonOdbierzUprawnienieDokumentacji";
            this.buttonOdbierzUprawnienieDokumentacji.Size = new System.Drawing.Size(235, 23);
            this.buttonOdbierzUprawnienieDokumentacji.TabIndex = 14;
            this.buttonOdbierzUprawnienieDokumentacji.Text = "Odbierz uprawnienie pracownikowi";
            this.buttonOdbierzUprawnienieDokumentacji.UseVisualStyleBackColor = true;
            this.buttonOdbierzUprawnienieDokumentacji.Click += new System.EventHandler(this.buttonOdbierzUprawnienieDokumentacji_Click);
            // 
            // buttonNadajUprawnienieDokumentacji
            // 
            this.buttonNadajUprawnienieDokumentacji.Location = new System.Drawing.Point(238, 65);
            this.buttonNadajUprawnienieDokumentacji.Name = "buttonNadajUprawnienieDokumentacji";
            this.buttonNadajUprawnienieDokumentacji.Size = new System.Drawing.Size(235, 23);
            this.buttonNadajUprawnienieDokumentacji.TabIndex = 13;
            this.buttonNadajUprawnienieDokumentacji.Text = "Nadaj uprawnienie pracownikowi";
            this.buttonNadajUprawnienieDokumentacji.UseVisualStyleBackColor = true;
            this.buttonNadajUprawnienieDokumentacji.Click += new System.EventHandler(this.buttonNadajUprawnienieDokumentacji_Click);
            // 
            // comboBoxDokumentacja
            // 
            this.comboBoxDokumentacja.FormattingEnabled = true;
            this.comboBoxDokumentacja.Location = new System.Drawing.Point(238, 27);
            this.comboBoxDokumentacja.Name = "comboBoxDokumentacja";
            this.comboBoxDokumentacja.Size = new System.Drawing.Size(235, 21);
            this.comboBoxDokumentacja.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Upoważnieni pracownicy:";
            // 
            // listBoxDokumentacja
            // 
            this.listBoxDokumentacja.FormattingEnabled = true;
            this.listBoxDokumentacja.Location = new System.Drawing.Point(7, 27);
            this.listBoxDokumentacja.Name = "listBoxDokumentacja";
            this.listBoxDokumentacja.Size = new System.Drawing.Size(225, 290);
            this.listBoxDokumentacja.TabIndex = 11;
            // 
            // FormPacjenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 884);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPacjenci";
            this.Text = "FormPacjenci";
            this.Load += new System.EventHandler(this.FormPacjenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBoxZdrowie;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOdbierzUprawnienieZdrowia;
        private System.Windows.Forms.Button buttonNadajUprawnieneiZdrowia;
        private System.Windows.Forms.ComboBox comboBoxZdrowie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOdbierzUprawnienieDokumentacji;
        private System.Windows.Forms.Button buttonNadajUprawnienieDokumentacji;
        private System.Windows.Forms.ComboBox comboBoxDokumentacja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxDokumentacja;
    }
}