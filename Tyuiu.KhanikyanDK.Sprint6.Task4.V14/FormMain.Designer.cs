using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KhanikyanDK.Sprint6.Task4.V14
{
    partial class FormMain
    {
        private PictureBox pictureBoxCondition;
        private TextBox textBoxResult;
        private Button buttonCalc;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            pictureBoxCondition = new PictureBox();
            textBoxResult = new TextBox();
            buttonCalc = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.ImageLocation = "C:\\Users\\Иван\\source\\repos\\Tyuiu.KhanikyanDK.Sprint6\\img\\task4.png";
            pictureBoxCondition.Location = new Point(20, 20);
            pictureBoxCondition.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(500, 80);
            pictureBoxCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition.TabIndex = 0;
            pictureBoxCondition.TabStop = false;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new System.Drawing.Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResult.Location = new Point(20, 120);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(500, 250);
            textBoxResult.TabIndex = 1;
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(20, 380);
            buttonCalc.Margin = new Padding(3, 4, 3, 4);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(120, 35);
            buttonCalc.TabIndex = 2;
            buttonCalc.Text = "Вычислить";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(490, 380);
            buttonInfo.Margin = new Padding(3, 4, 3, 4);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(35, 35);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 433);
            Controls.Add(buttonInfo);
            Controls.Add(buttonCalc);
            Controls.Add(textBoxResult);
            Controls.Add(pictureBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 4 | Ханикян Д. К. | Вариант 14";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}