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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrtFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblLeftSegment = new System.Windows.Forms.Label();
            this.lblRightSegment = new System.Windows.Forms.Label();
            this.nmrcLeft = new System.Windows.Forms.NumericUpDown();
            this.nmrcRight = new System.Windows.Forms.NumericUpDown();
            this.lblPowerPol = new System.Windows.Forms.Label();
            this.nmrcPowerPol = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.chrtError = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdBtnEven = new System.Windows.Forms.RadioButton();
            this.rdBtnCheb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPowerPol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtError)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtFunc
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Interval = 0.05D;
            chartArea1.Name = "main";
            this.chrtFunc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtFunc.Legends.Add(legend1);
            this.chrtFunc.Location = new System.Drawing.Point(12, 12);
            this.chrtFunc.Name = "chrtFunc";
            this.chrtFunc.Size = new System.Drawing.Size(616, 332);
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
            this.nmrcLeft.Location = new System.Drawing.Point(223, 361);
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
            this.nmrcRight.Location = new System.Drawing.Point(223, 384);
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
            this.lblPowerPol.Location = new System.Drawing.Point(9, 409);
            this.lblPowerPol.Name = "lblPowerPol";
            this.lblPowerPol.Size = new System.Drawing.Size(208, 13);
            this.lblPowerPol.TabIndex = 5;
            this.lblPowerPol.Text = "Степень интерполяционного полинома:";
            // 
            // nmrcPowerPol
            // 
            this.nmrcPowerPol.Location = new System.Drawing.Point(223, 407);
            this.nmrcPowerPol.Name = "nmrcPowerPol";
            this.nmrcPowerPol.Size = new System.Drawing.Size(67, 20);
            this.nmrcPowerPol.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(749, 353);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Построить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalcClick);
            // 
            // chrtError
            // 
            this.chrtError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "main";
            this.chrtError.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtError.Legends.Add(legend2);
            this.chrtError.Location = new System.Drawing.Point(634, 12);
            this.chrtError.Name = "chrtError";
            this.chrtError.Size = new System.Drawing.Size(287, 332);
            this.chrtError.TabIndex = 8;
            this.chrtError.Text = "chart1";
            // 
            // rdBtnEven
            // 
            this.rdBtnEven.AutoSize = true;
            this.rdBtnEven.Checked = true;
            this.rdBtnEven.Location = new System.Drawing.Point(324, 361);
            this.rdBtnEven.Name = "rdBtnEven";
            this.rdBtnEven.Size = new System.Drawing.Size(151, 17);
            this.rdBtnEven.TabIndex = 9;
            this.rdBtnEven.TabStop = true;
            this.rdBtnEven.Text = "Равномерное разбиение";
            this.rdBtnEven.UseVisualStyleBackColor = true;
            // 
            // rdBtnCheb
            // 
            this.rdBtnCheb.AutoSize = true;
            this.rdBtnCheb.Location = new System.Drawing.Point(324, 382);
            this.rdBtnCheb.Name = "rdBtnCheb";
            this.rdBtnCheb.Size = new System.Drawing.Size(154, 17);
            this.rdBtnCheb.TabIndex = 10;
            this.rdBtnCheb.Text = "Чебышевское разбиение";
            this.rdBtnCheb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 436);
            this.Controls.Add(this.rdBtnCheb);
            this.Controls.Add(this.rdBtnEven);
            this.Controls.Add(this.chrtError);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.nmrcPowerPol);
            this.Controls.Add(this.lblPowerPol);
            this.Controls.Add(this.nmrcRight);
            this.Controls.Add(this.nmrcLeft);
            this.Controls.Add(this.lblRightSegment);
            this.Controls.Add(this.lblLeftSegment);
            this.Controls.Add(this.chrtFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chrtFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPowerPol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtError)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtError;
        private System.Windows.Forms.RadioButton rdBtnEven;
        private System.Windows.Forms.RadioButton rdBtnCheb;
    }
}

