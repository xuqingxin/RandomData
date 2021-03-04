namespace RandomData
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudUpper = new System.Windows.Forms.NumericUpDown();
            this.nudLower = new System.Windows.Forms.NumericUpDown();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(283, 122);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "生成";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "上限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "下限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数量";
            // 
            // nudUpper
            // 
            this.nudUpper.DecimalPlaces = 3;
            this.nudUpper.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudUpper.Location = new System.Drawing.Point(76, 61);
            this.nudUpper.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudUpper.Name = "nudUpper";
            this.nudUpper.Size = new System.Drawing.Size(100, 21);
            this.nudUpper.TabIndex = 7;
            this.nudUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudUpper.Value = new decimal(new int[] {
            102,
            0,
            0,
            131072});
            // 
            // nudLower
            // 
            this.nudLower.DecimalPlaces = 3;
            this.nudLower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLower.Location = new System.Drawing.Point(76, 125);
            this.nudLower.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLower.Name = "nudLower";
            this.nudLower.Size = new System.Drawing.Size(100, 21);
            this.nudLower.TabIndex = 8;
            this.nudLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNumber
            // 
            this.nudNumber.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNumber.Location = new System.Drawing.Point(273, 61);
            this.nudNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(100, 21);
            this.nudNumber.TabIndex = 9;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumber.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 216);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.nudLower);
            this.Controls.Add(this.nudUpper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机数据生成器";
            ((System.ComponentModel.ISupportInitialize)(this.nudUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudUpper;
        private System.Windows.Forms.NumericUpDown nudLower;
        private System.Windows.Forms.NumericUpDown nudNumber;
    }
}

