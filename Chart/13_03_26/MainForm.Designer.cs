namespace _13_03_26
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListSection = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Visits = new LiveCharts.WinForms.CartesianChart();
            this.Income = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListSection
            // 
            this.ListSection.FormattingEnabled = true;
            this.ListSection.Location = new System.Drawing.Point(12, 12);
            this.ListSection.Name = "ListSection";
            this.ListSection.Size = new System.Drawing.Size(126, 290);
            this.ListSection.TabIndex = 0;
            // 
            // Visits
            // 
            this.Visits.Location = new System.Drawing.Point(144, 12);
            this.Visits.Name = "Visits";
            this.Visits.Size = new System.Drawing.Size(644, 426);
            this.Visits.TabIndex = 1;
            this.Visits.Text = "cartesianChart1";
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(12, 321);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(126, 117);
            this.Income.TabIndex = 2;
            this.Income.Text = "pieChart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.Visits);
            this.Controls.Add(this.ListSection);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListSection;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LiveCharts.WinForms.CartesianChart Visits;
        private LiveCharts.WinForms.PieChart Income;
    }
}

