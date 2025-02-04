namespace Gpax
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbGrades = new TextBox();
            tbGPAX = new TextBox();
            button1 = new Button();
            tbMaxGrade = new TextBox();
            tbMinGrade = new TextBox();
            tbStudentCount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 101);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Input grade0-4";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 151);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "GPAX";
            // 
            // tbGrades
            // 
            tbGrades.Location = new Point(293, 94);
            tbGrades.Name = "tbGrades";
            tbGrades.Size = new Size(125, 27);
            tbGrades.TabIndex = 2;
            // 
            // tbGPAX
            // 
            tbGPAX.Location = new Point(293, 144);
            tbGPAX.Name = "tbGPAX";
            tbGPAX.Size = new Size(125, 27);
            tbGPAX.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(456, 94);
            button1.Name = "button1";
            button1.Size = new Size(134, 77);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbMaxGrade
            // 
            tbMaxGrade.Location = new Point(293, 197);
            tbMaxGrade.Name = "tbMaxGrade";
            tbMaxGrade.Size = new Size(125, 27);
            tbMaxGrade.TabIndex = 5;
            // 
            // tbMinGrade
            // 
            tbMinGrade.Location = new Point(293, 255);
            tbMinGrade.Name = "tbMinGrade";
            tbMinGrade.Size = new Size(125, 27);
            tbMinGrade.TabIndex = 6;
            // 
            // tbStudentCount
            // 
            tbStudentCount.Location = new Point(293, 317);
            tbStudentCount.Name = "tbStudentCount";
            tbStudentCount.Size = new Size(125, 27);
            tbStudentCount.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 204);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 8;
            label3.Text = "Max grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 258);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "MinGrade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 324);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 10;
            label5.Text = "Student count";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 535);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbStudentCount);
            Controls.Add(tbMinGrade);
            Controls.Add(tbMaxGrade);
            Controls.Add(button1);
            Controls.Add(tbGPAX);
            Controls.Add(tbGrades);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbGrades;
        private TextBox tbGPAX;
        private Button button1;
        private TextBox tbMaxGrade;
        private TextBox tbMinGrade;
        private TextBox tbStudentCount;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
