namespace WindowsFormsApp1
{
    partial class Form5
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
            this.boooksDataSet5 = new WindowsFormsApp1.BoooksDataSet5();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new WindowsFormsApp1.BoooksDataSet5TableAdapters.AuthorsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boooksDataSet6 = new WindowsFormsApp1.BoooksDataSet6();
            this.toOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toOrderTableAdapter = new WindowsFormsApp1.BoooksDataSet6TableAdapters.toOrderTableAdapter();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boooksDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boooksDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.bookIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(152, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // boooksDataSet5
            // 
            this.boooksDataSet5.DataSetName = "BoooksDataSet5";
            this.boooksDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.boooksDataSet5;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "select";
            this.Column1.Name = "Column1";
            // 
            // boooksDataSet6
            // 
            this.boooksDataSet6.DataSetName = "BoooksDataSet6";
            this.boooksDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toOrderBindingSource
            // 
            this.toOrderBindingSource.DataMember = "toOrder";
            this.toOrderBindingSource.DataSource = this.boooksDataSet6;
            // 
            // toOrderTableAdapter
            // 
            this.toOrderTableAdapter.ClearBeforeFill = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boooksDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boooksDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BoooksDataSet5 boooksDataSet5;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BoooksDataSet5TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private BoooksDataSet6 boooksDataSet6;
        private System.Windows.Forms.BindingSource toOrderBindingSource;
        private BoooksDataSet6TableAdapters.toOrderTableAdapter toOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}