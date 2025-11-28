using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KhanikyanDK.Sprint6.Task3.V6
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonReplace;
        private Button buttonInfo;
        private DataGridView dataGridViewResult;
        private Label labelCondition;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelCondition = new Label();
            buttonReplace = new Button();
            buttonInfo = new Button();
            dataGridViewResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(12, 12);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(584, 60);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Условие:\r\nДан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.\r\nРезультат вывести в DataGridView.";
            // 
            // buttonReplace
            // 
            buttonReplace.Location = new Point(480, 70);
            buttonReplace.Margin = new Padding(3, 4, 3, 4);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.Size = new Size(120, 40);
            buttonReplace.TabIndex = 1;
            buttonReplace.Text = "Заменить";
            buttonReplace.UseVisualStyleBackColor = true;
            buttonReplace.Click += buttonReplace_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(480, 280);
            buttonInfo.Margin = new Padding(3, 4, 3, 4);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(120, 40);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeight = 29;
            dataGridViewResult.Location = new Point(12, 70);
            dataGridViewResult.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(450, 250);
            dataGridViewResult.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 350);
            Controls.Add(labelCondition);
            Controls.Add(buttonReplace);
            Controls.Add(buttonInfo);
            Controls.Add(dataGridViewResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Ханикян Д. К.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}