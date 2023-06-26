namespace _2._1___2._10
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
            button1=new Button();
            first=new TextBox();
            second=new TextBox();
            btnDelete=new Button();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            button5=new Button();
            button6=new Button();
            button7=new Button();
            button8=new Button();
            button9=new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(12, 12);
            button1.Name="button1";
            button1.Size=new Size(160, 75);
            button1.TabIndex=0;
            button1.Text="Вставка одной строки в другую строку";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // first
            // 
            first.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            first.Location=new Point(340, 36);
            first.Name="first";
            first.Size=new Size(139, 29);
            first.TabIndex=1;
            // 
            // second
            // 
            second.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            second.Location=new Point(340, 107);
            second.Name="second";
            second.Size=new Size(139, 29);
            second.TabIndex=2;
            // 
            // btnDelete
            // 
            btnDelete.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location=new Point(12, 107);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new Size(160, 76);
            btnDelete.TabIndex=3;
            btnDelete.Text="Удаление подстроки из заданной строки ";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // button2
            // 
            button2.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(12, 218);
            button2.Name="button2";
            button2.Size=new Size(160, 75);
            button2.TabIndex=4;
            button2.Text="Извлечение подстроки из заданной строки ";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location=new Point(12, 325);
            button3.Name="button3";
            button3.Size=new Size(160, 94);
            button3.TabIndex=5;
            button3.Text="Определение вхождения подстроки в заданной строке ";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // button4
            // 
            button4.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location=new Point(301, 218);
            button4.Name="button4";
            button4.Size=new Size(206, 94);
            button4.TabIndex=6;
            button4.Text="Преобразование строки в число";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // button5
            // 
            button5.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location=new Point(630, 13);
            button5.Name="button5";
            button5.Size=new Size(158, 74);
            button5.TabIndex=7;
            button5.Text="Вставка специального символа ";
            button5.UseVisualStyleBackColor=true;
            button5.Click+=button5_Click;
            // 
            // button6
            // 
            button6.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location=new Point(630, 101);
            button6.Name="button6";
            button6.Size=new Size(158, 82);
            button6.TabIndex=8;
            button6.Text="Вставка символа торговой марки ";
            button6.UseVisualStyleBackColor=true;
            button6.Click+=button6_Click;
            // 
            // button7
            // 
            button7.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location=new Point(630, 218);
            button7.Name="button7";
            button7.Size=new Size(158, 96);
            button7.TabIndex=9;
            button7.Text="Создание строки из повторяющихся символов ";
            button7.UseVisualStyleBackColor=true;
            button7.Click+=button7_Click;
            // 
            // button8
            // 
            button8.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location=new Point(630, 333);
            button8.Name="button8";
            button8.Size=new Size(158, 78);
            button8.TabIndex=10;
            button8.Text="Использование метода String.Format";
            button8.UseVisualStyleBackColor=true;
            button8.Click+=button8_Click;
            // 
            // button9
            // 
            button9.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location=new Point(301, 333);
            button9.Name="button9";
            button9.Size=new Size(206, 78);
            button9.TabIndex=11;
            button9.Text="Преобразование строки в объект Color и обратно";
            button9.UseVisualStyleBackColor=true;
            button9.Click+=button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnDelete);
            Controls.Add(second);
            Controls.Add(first);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox first;
        private TextBox second;
        private Button btnDelete;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}