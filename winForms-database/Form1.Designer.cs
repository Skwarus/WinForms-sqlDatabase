namespace winForms_database
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.liczba1,
            this.liczba2,
            this.liczba3,
            this.liczba4,
            this.liczba5,
            this.liczba6});
            this.dataGridView1.Location = new System.Drawing.Point(57, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // liczba1
            // 
            this.liczba1.HeaderText = "Liczba1";
            this.liczba1.Name = "liczba1";
            // 
            // liczba2
            // 
            this.liczba2.HeaderText = "Liczba2";
            this.liczba2.Name = "liczba2";
            // 
            // liczba3
            // 
            this.liczba3.HeaderText = "Liczba3";
            this.liczba3.Name = "liczba3";
            // 
            // liczba4
            // 
            this.liczba4.HeaderText = "Liczba4";
            this.liczba4.Name = "liczba4";
            // 
            // liczba5
            // 
            this.liczba5.HeaderText = "Liczba5";
            this.liczba5.Name = "liczba5";
            // 
            // liczba6
            // 
            this.liczba6.HeaderText = "Liczba6";
            this.liczba6.Name = "liczba6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add a draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba1;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba2;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba3;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba4;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba5;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba6;
        private System.Windows.Forms.Button button1;
    }
}

