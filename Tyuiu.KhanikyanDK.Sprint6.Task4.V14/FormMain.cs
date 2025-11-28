using System;
using System.Windows.Forms;
using Tyuiu.KhanikyanDK.Sprint6.Task4.V14.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int start = -5;
                int stop = 5;
                double[] values = ds.GetMassFunction(start, stop);

                textBoxResult.Clear();
                textBoxResult.AppendText("Таблица значений функции:\r\n");
                textBoxResult.AppendText("f(x) = 2x - 4 + ((2x - 1) / (sin(x) + 1))\r\n");
                textBoxResult.AppendText("на диапазоне [-5; 5] с шагом 1\r\n\r\n");

                for (int i = 0; i < values.Length; i++)
                {
                    textBoxResult.AppendText($"x = {start + i,3}, f(x) = {values[i]:F2}\r\n");
                }

                ds.SaveToFile(values, "OutPutFileTask4V14.txt");

                MessageBox.Show("Вычисления выполнены и сохранены в OutPutFileTask4V14.txt", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Sprint6, вариант 14 выполнен студентом Ханикян Давит Каренович, ИИПБ-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}