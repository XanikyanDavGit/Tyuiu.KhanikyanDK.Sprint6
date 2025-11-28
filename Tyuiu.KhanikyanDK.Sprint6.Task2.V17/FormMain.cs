using System;
using System.Windows.Forms;
using Tyuiu.KhanikyanDK.Sprint6.Task2.V17.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int start = -5; // диапазон фиксирован по условию
                int stop = 5;

                double[] results = ds.GetMassFunction(start, stop);

                // Очищаем DataGridView
                dataGridViewResult.Rows.Clear();

                // Заполняем DataGridView
                for (int i = 0; i < results.Length; i++)
                {
                    int x = start + i;
                    dataGridViewResult.Rows.Add(x.ToString(), results[i].ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 Sprint6, вариант 17 выполнен студентом Ханикян Давит Каренович, ИИПБ-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}