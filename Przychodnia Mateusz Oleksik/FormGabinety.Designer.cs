namespace Przychodnia_Mateusz_Oleksik
{
    partial class FormGabinety
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDodajGabinet = new System.Windows.Forms.Button();
            this.buttonUsunGabinet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 277);
            this.listBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer gabinetu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUsunGabinet);
            this.groupBox1.Location = new System.Drawing.Point(173, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzanie gabinetami";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 311);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista gabinetów:";
            // 
            // buttonDodajGabinet
            // 
            this.buttonDodajGabinet.Location = new System.Drawing.Point(6, 64);
            this.buttonDodajGabinet.Name = "buttonDodajGabinet";
            this.buttonDodajGabinet.Size = new System.Drawing.Size(162, 23);
            this.buttonDodajGabinet.TabIndex = 2;
            this.buttonDodajGabinet.Text = "Dodaj gabinet do listy";
            this.buttonDodajGabinet.UseVisualStyleBackColor = true;
            this.buttonDodajGabinet.Click += new System.EventHandler(this.buttonDodajGabinet_Click);
            // 
            // buttonUsunGabinet
            // 
            this.buttonUsunGabinet.Location = new System.Drawing.Point(6, 19);
            this.buttonUsunGabinet.Name = "buttonUsunGabinet";
            this.buttonUsunGabinet.Size = new System.Drawing.Size(162, 23);
            this.buttonUsunGabinet.TabIndex = 3;
            this.buttonUsunGabinet.Text = "Usuń wybrany gabinet z listy";
            this.buttonUsunGabinet.UseVisualStyleBackColor = true;
            this.buttonUsunGabinet.Click += new System.EventHandler(this.buttonUsunGabinet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDodajGabinet);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(173, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 245);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodawanie gabinetów";
            // 
            // FormGabinety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormGabinety";
            this.Text = "FormGabinety";
            this.Load += new System.EventHandler(this.FormGabinety_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUsunGabinet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDodajGabinet;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}