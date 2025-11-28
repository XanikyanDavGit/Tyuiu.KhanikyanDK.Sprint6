using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KhanikyanDK.Sprint6.Task5.V14.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private double[] numbersGreaterOrEqual10 = Array.Empty<double>();

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Указываем путь к файлу
                string path = @"C:\DataSprint5\InPutDataFileTask5V14.txt";

                // Загружаем данные
                numbersGreaterOrEqual10 = ds.LoadFromDataFile(path);

                // Очищаем таблицы
                dataGridViewAll.Rows.Clear();
                dataGridViewFiltered.Rows.Clear();

                // Если файл пустой или нет подходящих чисел
                if (numbersGreaterOrEqual10.Length == 0)
                {
                    MessageBox.Show("В файле нет чисел, больших или равных 10.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Добавляем значения в обе таблицы
                foreach (double val in numbersGreaterOrEqual10)
                {
                    dataGridViewAll.Rows.Add(val);
                    dataGridViewFiltered.Rows.Add(val);
                }

                // Обновляем график
                pictureBoxChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (numbersGreaterOrEqual10.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int x = 20, y = 20;
            int barHeight = 20;
            int maxWidth = pictureBoxChart.Width - 100;

            double max = numbersGreaterOrEqual10.Max();
            if (max == 0) max = 1;

            foreach (double val in numbersGreaterOrEqual10)
            {
                int barWidth = (int)((val / max) * maxWidth);
                g.FillRectangle(Brushes.LightBlue, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);
                g.DrawString(val.ToString("0.###"), this.Font, Brushes.Black, x + barWidth + 5, y);
                y += barHeight + 5;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Sprint6, вариант 14 выполнен студентом Ханикян Давит Каренович, ИИПБ-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}