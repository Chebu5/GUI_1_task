namespace WinFormsApp1
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
            label3 = new Label();
            SideA = new TextBox();
            SideB = new TextBox();
            SideC = new TextBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 43);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Первая сторона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 106);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Вторая сторона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 153);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Третья сторона";
            // 
            // SideA
            // 
            SideA.Location = new Point(150, 43);
            SideA.Name = "SideA";
            SideA.Size = new Size(125, 27);
            SideA.TabIndex = 3;
            // 
            // SideB
            // 
            SideB.Location = new Point(150, 99);
            SideB.Name = "SideB";
            SideB.Size = new Size(125, 27);
            SideB.TabIndex = 4;
            // 
            // SideC
            // 
            SideC.Location = new Point(150, 150);
            SideC.Name = "SideC";
            SideC.Size = new Size(125, 27);
            SideC.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(13, 189);
            button1.Name = "button1";
            button1.Size = new Size(125, 48);
            button1.TabIndex = 6;
            button1.Text = "Ответ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 241);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(156, 189);
            button2.Name = "button2";
            button2.Size = new Size(129, 48);
            button2.TabIndex = 8;
            button2.Text = "Очистить поля";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 21);
            label5.MaximumSize = new Size(200, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 140);
            label5.TabIndex = 9;
            label5.Text = "Даны вещественные положительные числа a, b, c. Если существует треугольник со сторонами a, b, c, то определить, является ли он прямоугольным.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 275);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(SideC);
            Controls.Add(SideB);
            Controls.Add(SideA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Проверка на прямоугольник";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox SideA;
        private TextBox SideB;
        private TextBox SideC;
        private Button button1;
        private Label label4;
        private Button button2;
        private Label label5;
    }
}
