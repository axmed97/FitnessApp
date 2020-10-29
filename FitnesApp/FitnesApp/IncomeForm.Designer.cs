namespace FitnesApp
{
    partial class IncomeForm
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
            this.dtpMin = new System.Windows.Forms.DateTimePicker();
            this.dtgvIncomes = new System.Windows.Forms.DataGridView();
            this.dtpMax = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInTotal = new System.Windows.Forms.TextBox();
            this.txtPure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTool = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvOutcomes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOutcomes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMin
            // 
            this.dtpMin.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMin.Location = new System.Drawing.Point(47, 38);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.Size = new System.Drawing.Size(375, 34);
            this.dtpMin.TabIndex = 0;
            this.dtpMin.ValueChanged += new System.EventHandler(this.MonthValueChange);
            // 
            // dtgvIncomes
            // 
            this.dtgvIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvIncomes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvIncomes.BackgroundColor = System.Drawing.Color.White;
            this.dtgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIncomes.Location = new System.Drawing.Point(0, 500);
            this.dtgvIncomes.Name = "dtgvIncomes";
            this.dtgvIncomes.RowHeadersWidth = 51;
            this.dtgvIncomes.RowTemplate.Height = 24;
            this.dtgvIncomes.Size = new System.Drawing.Size(599, 367);
            this.dtgvIncomes.TabIndex = 4;
            // 
            // dtpMax
            // 
            this.dtpMax.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMax.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMax.Location = new System.Drawing.Point(670, 38);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.Size = new System.Drawing.Size(375, 34);
            this.dtpMax.TabIndex = 5;
            this.dtpMax.ValueChanged += new System.EventHandler(this.MonthValueChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Incomes";
            // 
            // txtInTotal
            // 
            this.txtInTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInTotal.Location = new System.Drawing.Point(47, 163);
            this.txtInTotal.Name = "txtInTotal";
            this.txtInTotal.Size = new System.Drawing.Size(376, 34);
            this.txtInTotal.TabIndex = 21;
            // 
            // txtPure
            // 
            this.txtPure.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPure.Location = new System.Drawing.Point(670, 163);
            this.txtPure.Name = "txtPure";
            this.txtPure.Size = new System.Drawing.Size(376, 34);
            this.txtPure.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pure Incomes";
            // 
            // txtTool
            // 
            this.txtTool.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTool.Location = new System.Drawing.Point(47, 310);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(376, 34);
            this.txtTool.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tools Outcome";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(670, 310);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(376, 34);
            this.txtSalary.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 34);
            this.label4.TabIndex = 26;
            this.label4.Text = "Worker Salary";
            // 
            // txtOutTotal
            // 
            this.txtOutTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutTotal.Location = new System.Drawing.Point(371, 438);
            this.txtOutTotal.Name = "txtOutTotal";
            this.txtOutTotal.Size = new System.Drawing.Size(376, 34);
            this.txtOutTotal.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 34);
            this.label5.TabIndex = 28;
            this.label5.Text = "Totals Outcomes";
            // 
            // dtgvOutcomes
            // 
            this.dtgvOutcomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvOutcomes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvOutcomes.BackgroundColor = System.Drawing.Color.White;
            this.dtgvOutcomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOutcomes.Location = new System.Drawing.Point(605, 500);
            this.dtgvOutcomes.Name = "dtgvOutcomes";
            this.dtgvOutcomes.RowHeadersWidth = 51;
            this.dtgvOutcomes.RowTemplate.Height = 24;
            this.dtgvOutcomes.Size = new System.Drawing.Size(599, 367);
            this.dtgvOutcomes.TabIndex = 30;
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1210, 879);
            this.Controls.Add(this.dtgvOutcomes);
            this.Controls.Add(this.txtOutTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTool);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMax);
            this.Controls.Add(this.dtgvIncomes);
            this.Controls.Add(this.dtpMin);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOutcomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMin;
        private System.Windows.Forms.DataGridView dtgvIncomes;
        private System.Windows.Forms.DateTimePicker dtpMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInTotal;
        private System.Windows.Forms.TextBox txtPure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvOutcomes;
    }
}