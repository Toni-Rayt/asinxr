using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asinxr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Предсказатель";
        }
        private int k = 0;
        public Random random = new Random();
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string[] array = new string[10] { "Предстоят небольшие приятные расходы", "Вас ждет банкротство", "Вы станете миллионером", "Вас ждет неприятная мелочь на работе", "У вас успешный день впереди", "НА работу лучше не ходить сегодня", "Вас ждут большие расходы", "На учебу едьте на общественном транспорте", "Не планируйте ничего на выходные", "Сегодня стоит сходить на тусовку" };
            for (int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(100);
                this.Invoke(new Action(() =>
                {
                    this.Text = "" + i.ToString() + "%";
                }));
                if (i == 100)
                {
                    int c = random.Next(0, 10);
                    MessageBox.Show(array[c]);
                }
            }
            button1.Enabled = true;
        }
    }
}
