namespace QualiCalc.pages
{
    partial class VariableControlChartUC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IsControlled = new System.Windows.Forms.CheckBox();
            this.IsAcceptable = new System.Windows.Forms.CheckBox();
            this.IsNonconforming = new System.Windows.Forms.CheckBox();
            this.IsCentered = new System.Windows.Forms.CheckBox();
            this.IsCapable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(17, 14);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(823, 349);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // IsControlled
            // 
            this.IsControlled.AutoSize = true;
            this.IsControlled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsControlled.Enabled = false;
            this.IsControlled.Location = new System.Drawing.Point(90, 453);
            this.IsControlled.Name = "IsControlled";
            this.IsControlled.Size = new System.Drawing.Size(82, 19);
            this.IsControlled.TabIndex = 2;
            this.IsControlled.Text = "Controlled";
            this.IsControlled.UseVisualStyleBackColor = true;
            // 
            // IsAcceptable
            // 
            this.IsAcceptable.AutoSize = true;
            this.IsAcceptable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsAcceptable.Enabled = false;
            this.IsAcceptable.Location = new System.Drawing.Point(261, 453);
            this.IsAcceptable.Name = "IsAcceptable";
            this.IsAcceptable.Size = new System.Drawing.Size(85, 19);
            this.IsAcceptable.TabIndex = 3;
            this.IsAcceptable.Text = "Acceptable";
            this.IsAcceptable.UseVisualStyleBackColor = true;
            // 
            // IsNonconforming
            // 
            this.IsNonconforming.AutoSize = true;
            this.IsNonconforming.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsNonconforming.Enabled = false;
            this.IsNonconforming.Location = new System.Drawing.Point(422, 422);
            this.IsNonconforming.Name = "IsNonconforming";
            this.IsNonconforming.Size = new System.Drawing.Size(112, 19);
            this.IsNonconforming.TabIndex = 4;
            this.IsNonconforming.Text = "Nonconforming";
            this.IsNonconforming.UseVisualStyleBackColor = true;
            // 
            // IsCentered
            // 
            this.IsCentered.AutoSize = true;
            this.IsCentered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsCentered.Enabled = false;
            this.IsCentered.Location = new System.Drawing.Point(437, 488);
            this.IsCentered.Name = "IsCentered";
            this.IsCentered.Size = new System.Drawing.Size(74, 19);
            this.IsCentered.TabIndex = 5;
            this.IsCentered.Text = "Centered";
            this.IsCentered.UseVisualStyleBackColor = true;
            // 
            // IsCapable
            // 
            this.IsCapable.AutoSize = true;
            this.IsCapable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsCapable.Enabled = false;
            this.IsCapable.Location = new System.Drawing.Point(605, 488);
            this.IsCapable.Name = "IsCapable";
            this.IsCapable.Size = new System.Drawing.Size(69, 19);
            this.IsCapable.TabIndex = 6;
            this.IsCapable.Text = "Capable";
            this.IsCapable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "-------->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "-------->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "-------->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "-------->";
            // 
            // VariableControlChartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsCapable);
            this.Controls.Add(this.IsCentered);
            this.Controls.Add(this.IsNonconforming);
            this.Controls.Add(this.IsAcceptable);
            this.Controls.Add(this.IsControlled);
            this.Controls.Add(this.Chart);
            this.Name = "VariableControlChartUC";
            this.Size = new System.Drawing.Size(860, 581);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private CheckBox IsControlled;
        private CheckBox IsAcceptable;
        private CheckBox IsNonconforming;
        private CheckBox IsCentered;
        private CheckBox IsCapable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
