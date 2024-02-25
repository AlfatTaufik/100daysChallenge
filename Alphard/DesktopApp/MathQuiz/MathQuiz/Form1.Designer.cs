namespace MathQuiz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftTable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plusRightTable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftTable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minusRightTable = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.dividedLeftTable = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dividedRightTable = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.timesLeftTable = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.timeRightTable = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(335, 8);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(137, 26);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeftTable
            // 
            this.plusLeftTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftTable.Location = new System.Drawing.Point(50, 75);
            this.plusLeftTable.Name = "plusLeftTable";
            this.plusLeftTable.Size = new System.Drawing.Size(60, 50);
            this.plusLeftTable.TabIndex = 2;
            this.plusLeftTable.Text = "?";
            this.plusLeftTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusLeftTable.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 2;
            this.label5.Text = "+";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightTable
            // 
            this.plusRightTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightTable.Location = new System.Drawing.Point(158, 75);
            this.plusRightTable.Name = "plusRightTable";
            this.plusRightTable.Size = new System.Drawing.Size(60, 50);
            this.plusRightTable.TabIndex = 2;
            this.plusRightTable.Text = "?";
            this.plusRightTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 2;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(274, 84);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            // 
            // minusLeftTable
            // 
            this.minusLeftTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftTable.Location = new System.Drawing.Point(50, 134);
            this.minusLeftTable.Name = "minusLeftTable";
            this.minusLeftTable.Size = new System.Drawing.Size(60, 50);
            this.minusLeftTable.TabIndex = 2;
            this.minusLeftTable.Text = "?";
            this.minusLeftTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minusLeftTable.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(224, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 2;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 2;
            this.label9.Text = "-";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(182, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 2;
            this.label10.Text = "?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightTable
            // 
            this.minusRightTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightTable.Location = new System.Drawing.Point(158, 134);
            this.minusRightTable.Name = "minusRightTable";
            this.minusRightTable.Size = new System.Drawing.Size(60, 50);
            this.minusRightTable.TabIndex = 2;
            this.minusRightTable.Text = "?";
            this.minusRightTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(274, 143);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 2;
            // 
            // dividedLeftTable
            // 
            this.dividedLeftTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftTable.Location = new System.Drawing.Point(50, 228);
            this.dividedLeftTable.Name = "dividedLeftTable";
            this.dividedLeftTable.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftTable.TabIndex = 2;
            this.dividedLeftTable.Text = "?";
            this.dividedLeftTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dividedLeftTable.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(224, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 2;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(103, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 2;
            this.label14.Text = "÷";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(182, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 2;
            this.label15.Text = "?";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightTable
            // 
            this.dividedRightTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightTable.Location = new System.Drawing.Point(158, 228);
            this.dividedRightTable.Name = "dividedRightTable";
            this.dividedRightTable.Size = new System.Drawing.Size(60, 50);
            this.dividedRightTable.TabIndex = 2;
            this.dividedRightTable.Text = "?";
            this.dividedRightTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(274, 237);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 4;
            // 
            // timesLeftTable
            // 
            this.timesLeftTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftTable.Location = new System.Drawing.Point(50, 178);
            this.timesLeftTable.Name = "timesLeftTable";
            this.timesLeftTable.Size = new System.Drawing.Size(60, 50);
            this.timesLeftTable.TabIndex = 2;
            this.timesLeftTable.Text = "?";
            this.timesLeftTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timesLeftTable.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(224, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 50);
            this.label18.TabIndex = 2;
            this.label18.Text = "=";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.plusLeftTable_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(103, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 50);
            this.label19.TabIndex = 2;
            this.label19.Text = "x";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeRightTable
            // 
            this.timeRightTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRightTable.Location = new System.Drawing.Point(158, 178);
            this.timeRightTable.Name = "timeRightTable";
            this.timeRightTable.Size = new System.Drawing.Size(60, 50);
            this.timeRightTable.TabIndex = 2;
            this.timeRightTable.Text = "?";
            this.timeRightTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(274, 187);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(145, 281);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start The Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.product);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.timeRightTable);
            this.Controls.Add(this.dividedRightTable);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minusRightTable);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.plusRightTable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timesLeftTable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dividedLeftTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusLeftTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.plusLeftTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label plusRightTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label minusRightTable;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label dividedLeftTable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dividedRightTable;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label timesLeftTable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label timeRightTable;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

