namespace MineSweeper
{
    partial class FormOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSizeGameY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSizeGameX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCellSizeY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3CellSizeX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOffsetCellY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOffsetCellX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.numericUpDownCountBombs = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeGameY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeGameX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3CellSizeX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetCellY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetCellX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBombs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownSizeGameY);
            this.groupBox1.Controls.Add(this.numericUpDownSizeGameX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры игры:";
            // 
            // numericUpDownSizeGameY
            // 
            this.numericUpDownSizeGameY.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSizeGameY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSizeGameY.Location = new System.Drawing.Point(75, 52);
            this.numericUpDownSizeGameY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownSizeGameY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSizeGameY.Name = "numericUpDownSizeGameY";
            this.numericUpDownSizeGameY.Size = new System.Drawing.Size(101, 25);
            this.numericUpDownSizeGameY.TabIndex = 3;
            this.numericUpDownSizeGameY.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // numericUpDownSizeGameX
            // 
            this.numericUpDownSizeGameX.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSizeGameX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSizeGameX.Location = new System.Drawing.Point(75, 21);
            this.numericUpDownSizeGameX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownSizeGameX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSizeGameX.Name = "numericUpDownSizeGameX";
            this.numericUpDownSizeGameX.Size = new System.Drawing.Size(101, 25);
            this.numericUpDownSizeGameX.TabIndex = 2;
            this.numericUpDownSizeGameX.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownCellSizeY);
            this.groupBox2.Controls.Add(this.numericUpDown3CellSizeX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры игровых ячеек:";
            // 
            // numericUpDownCellSizeY
            // 
            this.numericUpDownCellSizeY.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCellSizeY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCellSizeY.Location = new System.Drawing.Point(75, 52);
            this.numericUpDownCellSizeY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownCellSizeY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCellSizeY.Name = "numericUpDownCellSizeY";
            this.numericUpDownCellSizeY.Size = new System.Drawing.Size(101, 25);
            this.numericUpDownCellSizeY.TabIndex = 3;
            this.numericUpDownCellSizeY.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numericUpDown3CellSizeX
            // 
            this.numericUpDown3CellSizeX.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3CellSizeX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3CellSizeX.Location = new System.Drawing.Point(75, 21);
            this.numericUpDown3CellSizeX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown3CellSizeX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3CellSizeX.Name = "numericUpDown3CellSizeX";
            this.numericUpDown3CellSizeX.Size = new System.Drawing.Size(101, 25);
            this.numericUpDown3CellSizeX.TabIndex = 2;
            this.numericUpDown3CellSizeX.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Высота:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ширина:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownOffsetCellY);
            this.groupBox3.Controls.Add(this.numericUpDownOffsetCellX);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(227, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 93);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отступы ячеек:";
            // 
            // numericUpDownOffsetCellY
            // 
            this.numericUpDownOffsetCellY.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownOffsetCellY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownOffsetCellY.Location = new System.Drawing.Point(75, 52);
            this.numericUpDownOffsetCellY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownOffsetCellY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownOffsetCellY.Name = "numericUpDownOffsetCellY";
            this.numericUpDownOffsetCellY.Size = new System.Drawing.Size(101, 25);
            this.numericUpDownOffsetCellY.TabIndex = 3;
            this.numericUpDownOffsetCellY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownOffsetCellX
            // 
            this.numericUpDownOffsetCellX.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownOffsetCellX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownOffsetCellX.Location = new System.Drawing.Point(75, 21);
            this.numericUpDownOffsetCellX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownOffsetCellX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownOffsetCellX.Name = "numericUpDownOffsetCellX";
            this.numericUpDownOffsetCellX.Size = new System.Drawing.Size(101, 25);
            this.numericUpDownOffsetCellX.TabIndex = 2;
            this.numericUpDownOffsetCellX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Высота:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ширина:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label7.Location = new System.Drawing.Point(220, 120);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(60, 22);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Бомбы:";
            // 
            // numericUpDownCountBombs
            // 
            this.numericUpDownCountBombs.Location = new System.Drawing.Point(286, 124);
            this.numericUpDownCountBombs.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownCountBombs.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCountBombs.Name = "numericUpDownCountBombs";
            this.numericUpDownCountBombs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCountBombs.TabIndex = 7;
            this.numericUpDownCountBombs.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownCountBombs);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeGameY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeGameX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3CellSizeX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetCellY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetCellX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBombs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown numericUpDownSizeGameY;
        public System.Windows.Forms.NumericUpDown numericUpDownSizeGameX;
        public System.Windows.Forms.NumericUpDown numericUpDownCellSizeY;
        public System.Windows.Forms.NumericUpDown numericUpDown3CellSizeX;
        public System.Windows.Forms.NumericUpDown numericUpDownOffsetCellY;
        public System.Windows.Forms.NumericUpDown numericUpDownOffsetCellX;
        public System.Windows.Forms.NumericUpDown numericUpDownCountBombs;
    }
}