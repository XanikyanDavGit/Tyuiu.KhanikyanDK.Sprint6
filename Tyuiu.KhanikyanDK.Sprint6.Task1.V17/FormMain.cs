using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.KhanikyanDK.Sprint6.Task1.V17.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task1.V17
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

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Таблица значений функции:");
                sb.AppendLine("f(x) = (3x - 1.5/sin(x) - 3 + x) + 2");
                sb.AppendLine("на диапазоне [-5; 5] с шагом 1");
                sb.AppendLine();

                for (int i = 0; i < results.Length; i++)
                {
                    int x = start + i;
                    sb.AppendLine($"x = {x,3}, f(x) = {results[i]:F2}");
                }

                textBoxResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Sprint6, вариант 17 выполнен студентом Ханикян Давит Каренович, ИИПБ-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}