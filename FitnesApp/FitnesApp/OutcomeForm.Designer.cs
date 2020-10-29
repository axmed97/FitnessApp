namespace FitnesApp
{
    partial class OutcomeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.nmudTool = new System.Windows.Forms.NumericUpDown();
            this.nmudSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 34);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tools Outcome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Worker Salary";
            // 
            // dtgv
            // 
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv.Location = new System.Drawing.Point(0, 323);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(993, 283);
            this.dtgv.TabIndex = 30;
            this.dtgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_RowHeaderMouseDoubleClick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(366, 204);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 52);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nmudTool
            // 
            this.nmudTool.DecimalPlaces = 2;
            this.nmudTool.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudTool.Location = new System.Drawing.Point(29, 98);
            this.nmudTool.Name = "nmudTool";
            this.nmudTool.Size = new System.Drawing.Size(336, 34);
            this.nmudTool.TabIndex = 32;
            // 
            // nmudSalary
            // 
            this.nmudSalary.DecimalPlaces = 2;
            this.nmudSalary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudSalary.Location = new System.Drawing.Point(474, 98);
            this.nmudSalary.Name = "nmudSalary";
            this.nmudSalary.Size = new System.Drawing.Size(336, 34);
            this.nmudSalary.TabIndex = 33;
            // 
            // OutcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(993, 606);
            this.Controls.Add(this.nmudSalary);
            this.Controls.Add(this.nmudTool);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "OutcomeForm";
            this.Text = "OutcomeForm";
            this.Load += new System.EventHandler(this.OutcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nmudTool;
        private System.Windows.Forms.NumericUpDown nmudSalary;
    }
}