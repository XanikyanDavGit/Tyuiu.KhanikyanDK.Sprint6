using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KhanikyanDK.Sprint6.Task5.V14
{
    partial class FormMain
    {
        private Button buttonLoad;
        private DataGridView dataGridViewAll;
        private DataGridView dataGridViewFiltered;
        private PictureBox pictureBoxChart;
        private Label labelAll;
        private Label labelFiltered;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.dataGridViewAll = new DataGridView();
            this.dataGridViewFiltered = new DataGridView();
            this.pictureBoxChart = new PictureBox();
            this.labelAll = new Label();
            this.labelFiltered = new Label();
            this.buttonInfo = new Button();

            // buttonLoad
            this.buttonLoad.Text = "Загрузить данные";
            this.buttonLoad.Location = new Point(20, 20);
            this.buttonLoad.Size = new Size(160, 30);
            this.buttonLoad.Click += new EventHandler(this.buttonLoad_Click);

            // dataGridViewAll
            this.dataGridViewAll.Location = new Point(20, 80);
            this.dataGridViewAll.Size = new Size(260, 250);
            this.dataGridViewAll.ColumnCount = 1;
            this.dataGridViewAll.Columns[0].HeaderText = "Все числа ≥10";
            this.dataGridViewAll.ReadOnly = true;

            // dataGridViewFiltered
            this.dataGridViewFiltered.Location = new Point(300, 80);
            this.dataGridViewFiltered.Size = new Size(260, 250);
            this.dataGridViewFiltered.ColumnCount = 1;
            this.dataGridViewFiltered.Columns[0].HeaderText = "Числа ≥10";
            this.dataGridViewFiltered.ReadOnly = true;

            // labelAll
            this.labelAll.Location = new Point(20, 60);
            this.labelAll.Text = "Все числа ≥10";
            this.labelAll.AutoSize = true;

            // labelFiltered
            this.labelFiltered.Location = new Point(300, 60);
            this.labelFiltered.Text = "Числа ≥10";
            this.labelFiltered.AutoSize = true;

            // pictureBoxChart
            this.pictureBoxChart.Location = new Point(580, 60);
            this.pictureBoxChart.Size = new Size(400, 270);
            this.pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxChart.Paint += new PaintEventHandler(this.pictureBoxChart_Paint);

            // buttonInfo
            this.buttonInfo.Location = new Point(190, 20);
            this.buttonInfo.Size = new Size(35, 30);
            this.buttonInfo.Text = "?";
            this.buttonInfo.Click += new EventHandler(this.buttonInfo_Click);

            // FormMain
            this.ClientSize = new Size(1000, 370);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.dataGridViewFiltered);
            this.Controls.Add(this.pictureBoxChart);
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.labelFiltered);
            this.Controls.Add(this.buttonInfo);
            this.Text = "Спринт 6 | Таск 5 | Вариант 14 | Ханикян Д. К.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}