namespace lab1NewtonPolyn
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrtFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblLeftSegment = new System.Windows.Forms.Label();
            this.lblRightSegment = new System.Windows.Forms.Label();
            this.nmrcLeft = new System.Windows.Forms.NumericUpDown();
            this.nmrcRight = new System.Windows.Forms.NumericUpDown();
            this.lblPowerPol = new System.Windows.Forms.Label();
            this.nmrcPowerPol = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPowerPol)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtFunc
            // 
            chartArea1.Name = "func";
            this.chrtFunc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtFunc.Legends.Add(legend1);
            this.chrtFunc.Location = new System.Drawing.Point(12, 12);
            this.chrtFunc.Name = "chrtFunc";
            this.chrtFunc.Size = new System.Drawing.Size(775, 332);
            this.chrtFunc.TabIndex = 0;
            this.chrtFunc.Text = "chart1";
            // 
            // lblLeftSegment
            // 
            this.lblLeftSegment.AutoSize = true;
            this.lblLeftSegment.Location = new System.Drawing.Point(9, 363);
            this.lblLeftSegment.Name = "lblLeftSegment";
            this.lblLeftSegment.Size = new System.Drawing.Size(184, 13);
            this.lblLeftSegment.TabIndex = 1;
            this.lblLeftSegment.Text = "Левая граница интерполирования:";
            // 
            // lblRightSegment
            // 
            this.lblRightSegment.AutoSize = true;
            this.lblRightSegment.Location = new System.Drawing.Point(9, 386);
            this.lblRightSegment.Name = "lblRightSegment";
            this.lblRightSegment.Size = new System.Drawing.Size(190, 13);
            this.lblRightSegment.TabIndex = 2;
            this.lblRightSegment.Text = "Правая граница интерполирования:";
            // 
            // nmrcLeft
            // 
            this.nmrcLeft.DecimalPlaces = 1;
            this.nmrcLeft.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrcLeft.Location = new System.Drawing.Point(209, 361);
            this.nmrcLeft.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrcLeft.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nmrcLeft.Name = "nmrcLeft";
            this.nmrcLeft.Size = new System.Drawing.Size(67, 20);
            this.nmrcLeft.TabIndex = 3;
            this.nmrcLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nmrcRight
            // 
            this.nmrcRight.DecimalPlaces = 1;
            this.nmrcRight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrcRight.Location = new System.Drawing.Point(209, 384);
            this.nmrcRight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrcRight.Minimum = new decimal(new int[] {
            59,
            0,
            0,
            -2147483648});
            this.nmrcRight.Name = "nmrcRight";
            this.nmrcRight.Size = new System.Drawing.Size(67, 20);
            this.nmrcRight.TabIndex = 4;
            this.nmrcRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPowerPol
            // 
            this.lblPowerPol.AutoSize = true;
            this.lblPowerPol.Location = new System.Drawing.Point(305, 363);
            this.lblPowerPol.Name = "lblPowerPol";
            this.lblPowerPol.Size = new System.Drawing.Size(205, 13);
            this.lblPowerPol.TabIndex = 5;
            this.lblPowerPol.Text = "Степень интерполяционного полинома";
            // 
            // nmrcPowerPol
            // 
            this.nmrcPowerPol.Location = new System.Drawing.Point(516, 361);
            this.nmrcPowerPol.Name = "nmrcPowerPol";
            this.nmrcPowerPol.Size = new System.Drawing.Size(70, 20);
            this.nmrcPowerPol.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(592, 358);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Построить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalcClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 413);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.nmrcPowerPol);
            this.Controls.Add(this.lblPowerPol);
            this.Controls.Add(this.nmrcRight);
            this.Controls.Add(this.nmrcLeft);
            this.Controls.Add(this.lblRightSegment);
            this.Controls.Add(this.lblLeftSegment);
            this.Controls.Add(this.chrtFunc);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chrtFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPowerPol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFunc;
        private System.Windows.Forms.Label lblLeftSegment;
        private System.Windows.Forms.Label lblRightSegment;
        private System.Windows.Forms.NumericUpDown nmrcLeft;
        private System.Windows.Forms.NumericUpDown nmrcRight;
        private System.Windows.Forms.Label lblPowerPol;
        private System.Windows.Forms.NumericUpDown nmrcPowerPol;
        private System.Windows.Forms.Button btnCalc;
    }
}

