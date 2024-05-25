namespace Złożoność_obliczeniowa_tablic
{
    partial class frFormularz
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lbWielkoscTablicy = new System.Windows.Forms.Label();
            this.txtWielkoscTablicy = new System.Windows.Forms.TextBox();
            this.btGenerujTablice = new System.Windows.Forms.Button();
            this.lbWygenerowanaTablica = new System.Windows.Forms.Label();
            this.btSortuj = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWielkoscTablicy
            // 
            this.lbWielkoscTablicy.AutoSize = true;
            this.lbWielkoscTablicy.Location = new System.Drawing.Point(12, 13);
            this.lbWielkoscTablicy.Name = "lbWielkoscTablicy";
            this.lbWielkoscTablicy.Size = new System.Drawing.Size(114, 13);
            this.lbWielkoscTablicy.TabIndex = 0;
            this.lbWielkoscTablicy.Text = "Podaj wielkość tablicy:";
            // 
            // txtWielkoscTablicy
            // 
            this.txtWielkoscTablicy.Location = new System.Drawing.Point(127, 7);
            this.txtWielkoscTablicy.Name = "txtWielkoscTablicy";
            this.txtWielkoscTablicy.Size = new System.Drawing.Size(100, 20);
            this.txtWielkoscTablicy.TabIndex = 1;
            // 
            // btGenerujTablice
            // 
            this.btGenerujTablice.Location = new System.Drawing.Point(237, 5);
            this.btGenerujTablice.Name = "btGenerujTablice";
            this.btGenerujTablice.Size = new System.Drawing.Size(110, 23);
            this.btGenerujTablice.TabIndex = 2;
            this.btGenerujTablice.Text = "Generuj Tablicę";
            this.btGenerujTablice.UseVisualStyleBackColor = true;
            this.btGenerujTablice.Click += new System.EventHandler(this.btGenerujTablice_Click);
            // 
            // lbWygenerowanaTablica
            // 
            this.lbWygenerowanaTablica.AutoSize = true;
            this.lbWygenerowanaTablica.Location = new System.Drawing.Point(15, 43);
            this.lbWygenerowanaTablica.Name = "lbWygenerowanaTablica";
            this.lbWygenerowanaTablica.Size = new System.Drawing.Size(42, 13);
            this.lbWygenerowanaTablica.TabIndex = 3;
            this.lbWygenerowanaTablica.Text = "Tablica";
            // 
            // btSortuj
            // 
            this.btSortuj.Location = new System.Drawing.Point(357, 5);
            this.btSortuj.Name = "btSortuj";
            this.btSortuj.Size = new System.Drawing.Size(75, 23);
            this.btSortuj.TabIndex = 4;
            this.btSortuj.Text = "Sortuj";
            this.btSortuj.UseVisualStyleBackColor = true;
            this.btSortuj.Click += new System.EventHandler(this.btSortuj_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.wartośćDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.wynikiBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 274);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(285, 183);
            this.dataGridView.TabIndex = 5;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(314, 274);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(300, 183);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Typ sortowania";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 120;
            // 
            // wartośćDataGridViewTextBoxColumn
            // 
            this.wartośćDataGridViewTextBoxColumn.DataPropertyName = "Wartość";
            this.wartośćDataGridViewTextBoxColumn.HeaderText = "Liczba operacji";
            this.wartośćDataGridViewTextBoxColumn.Name = "wartośćDataGridViewTextBoxColumn";
            this.wartośćDataGridViewTextBoxColumn.Width = 120;
            // 
            // wynikiBindingSource
            // 
            this.wynikiBindingSource.DataSource = typeof(Złożoność_obliczeniowa_tablic.Wyniki);
            // 
            // frFormularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btSortuj);
            this.Controls.Add(this.lbWygenerowanaTablica);
            this.Controls.Add(this.btGenerujTablice);
            this.Controls.Add(this.txtWielkoscTablicy);
            this.Controls.Add(this.lbWielkoscTablicy);
            this.Name = "frFormularz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Złożoność obliczeniowa dla różnych typów sortowania";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWielkoscTablicy;
        private System.Windows.Forms.TextBox txtWielkoscTablicy;
        private System.Windows.Forms.Button btGenerujTablice;
        private System.Windows.Forms.Label lbWygenerowanaTablica;
        private System.Windows.Forms.Button btSortuj;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource wynikiBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartośćDataGridViewTextBoxColumn;
    }
}

