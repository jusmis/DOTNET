namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boooksDataSet = new WindowsFormsApp1.BoooksDataSet();
            this.authorsTableAdapter = new WindowsFormsApp1.BoooksDataSetTableAdapters.AuthorsTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.pensjaTextBox = new System.Windows.Forms.TextBox();
            this.kontoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.imiecTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskocTextBox = new System.Windows.Forms.TextBox();
            this.adrescTextBox = new System.Windows.Forms.TextBox();
            this.telefoncTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.pYearTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.GenereTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boooksDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.boooksDataSet;
            this.authorsBindingSource.CurrentChanged += new System.EventHandler(this.AuthorsBindingSource_CurrentChanged);
            // 
            // boooksDataSet
            // 
            this.boooksDataSet.DataSetName = "BoooksDataSet";
            this.boooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(111, 8);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(100, 20);
            this.imieTextBox.TabIndex = 0;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(111, 36);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.kontoTextBox);
            this.tabPage2.Controls.Add(this.pensjaTextBox);
            this.tabPage2.Controls.Add(this.peselTextBox);
            this.tabPage2.Controls.Add(this.telefonTextBox);
            this.tabPage2.Controls.Add(this.adresTextBox);
            this.tabPage2.Controls.Add(this.nazwiskoTextBox);
            this.tabPage2.Controls.Add(this.imieTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(111, 62);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresTextBox.TabIndex = 2;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(111, 88);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 3;
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(111, 114);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(100, 20);
            this.peselTextBox.TabIndex = 4;
            // 
            // pensjaTextBox
            // 
            this.pensjaTextBox.Location = new System.Drawing.Point(111, 140);
            this.pensjaTextBox.Name = "pensjaTextBox";
            this.pensjaTextBox.Size = new System.Drawing.Size(100, 20);
            this.pensjaTextBox.TabIndex = 5;
            // 
            // kontoTextBox
            // 
            this.kontoTextBox.Location = new System.Drawing.Point(111, 166);
            this.kontoTextBox.Name = "kontoTextBox";
            this.kontoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kontoTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "empFirstNAme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "empLastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "empAdress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "empPhoneNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "empPESEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "empSalary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "empAccount";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.AuthorTextBox);
            this.tabPage3.Controls.Add(this.GenereTextBox);
            this.tabPage3.Controls.Add(this.TypeTextBox);
            this.tabPage3.Controls.Add(this.ConditionTextBox);
            this.tabPage3.Controls.Add(this.PriceTextBox);
            this.tabPage3.Controls.Add(this.pYearTextBox);
            this.tabPage3.Controls.Add(this.TitleTextBox);
            this.tabPage3.Controls.Add(this.ISBNTextBox);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Books";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Powrót do Menu ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.telefoncTextBox);
            this.tabPage1.Controls.Add(this.adrescTextBox);
            this.tabPage1.Controls.Add(this.nazwiskocTextBox);
            this.tabPage1.Controls.Add(this.imiecTextBox);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 374);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.nazwaTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 374);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Authors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Location = new System.Drawing.Point(112, 11);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "AuthorName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "cusFirstName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "cusLastName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "cusAdress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "cusPhoneNumber";
            // 
            // imiecTextBox
            // 
            this.imiecTextBox.Location = new System.Drawing.Point(119, 7);
            this.imiecTextBox.Name = "imiecTextBox";
            this.imiecTextBox.Size = new System.Drawing.Size(100, 20);
            this.imiecTextBox.TabIndex = 5;
            // 
            // nazwiskocTextBox
            // 
            this.nazwiskocTextBox.Location = new System.Drawing.Point(119, 33);
            this.nazwiskocTextBox.Name = "nazwiskocTextBox";
            this.nazwiskocTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskocTextBox.TabIndex = 6;
            // 
            // adrescTextBox
            // 
            this.adrescTextBox.Location = new System.Drawing.Point(119, 60);
            this.adrescTextBox.Name = "adrescTextBox";
            this.adrescTextBox.Size = new System.Drawing.Size(100, 20);
            this.adrescTextBox.TabIndex = 7;
            // 
            // telefoncTextBox
            // 
            this.telefoncTextBox.Location = new System.Drawing.Point(119, 87);
            this.telefoncTextBox.Name = "telefoncTextBox";
            this.telefoncTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoncTextBox.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Condition";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Genere";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "AuthorID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Title";
            this.label17.Click += new System.EventHandler(this.Label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "ISBN";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "publicationYear";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Price";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(117, 35);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNTextBox.TabIndex = 8;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(117, 9);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 9;
            // 
            // pYearTextBox
            // 
            this.pYearTextBox.Location = new System.Drawing.Point(117, 62);
            this.pYearTextBox.Name = "pYearTextBox";
            this.pYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.pYearTextBox.TabIndex = 10;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(117, 89);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 11;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(117, 119);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionTextBox.TabIndex = 12;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(117, 146);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 13;
            // 
            // GenereTextBox
            // 
            this.GenereTextBox.Location = new System.Drawing.Point(117, 175);
            this.GenereTextBox.Name = "GenereTextBox";
            this.GenereTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenereTextBox.TabIndex = 14;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(117, 202);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorTextBox.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(141, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Dodaj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boooksDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BoooksDataSet boooksDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BoooksDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kontoTextBox;
        private System.Windows.Forms.TextBox pensjaTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox telefoncTextBox;
        private System.Windows.Forms.TextBox adrescTextBox;
        private System.Windows.Forms.TextBox nazwiskocTextBox;
        private System.Windows.Forms.TextBox imiecTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox GenereTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox pYearTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
    }
}

