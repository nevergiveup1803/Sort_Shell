using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sort_Shell
{
    public partial class Form1 : Form
    {
        //глобально объявляем массив
        int[] mas;

        //время выполнения в милисекундах
        long time_ms = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void случайныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //скрываем область вывода отсортированного массива с её элементами
            listBox2.Items.Clear();
            listBox2.Visible = false;
            label2.Visible = false;
            groupBox2.Visible = false;

            //скрываем элементы для ввода массива вручную
            label3.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;

            //скрываем диаграмму
            chart1.Visible = false;

            //очищаем список элементов исходного массива и заполняем его случайными числами
            listBox1.Items.Clear();
            Random r = new Random();
            //случайно выберем длину 
            int n = r.Next(1000,50000);
            mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                //заполняем случайно и сразу добавляем в список элемент массива
                mas[i] = r.Next(1,1000);
                listBox1.Items.Insert(i,mas[i].ToString());
            }
            //отображаем результаты
            label1.Text = "Исходный массив из "+ n+" элементов:";
            label1.Visible = true;
            listBox1.Visible = true;
            groupBox1.Visible = true;
            button1.Visible = true;
            
        }

        private void заполнениеМассиваToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            //сортировка Шелла

            //инициализируем шаг
            int sh = mas.Length / 2;

            while (sh > 0) //пока шаг не 0
            {
                for (int i = 0; i < (mas.Length - sh); i++)
                {
                    int j = i;
                    //начиная с i-го элемента до начала массива и пока текущий элемент массива больше элемента, находящегося на расстоянии шага
                    while ((j >= 0) && (mas[j] > mas[j + sh]))
                    {
                        //меняем их местами
                        int tmp = mas[j];
                        mas[j] = mas[j + sh];
                        mas[j + sh] = tmp;
                        j -= sh;
                    }
                }
                //уменьшаем шаг
                sh /= 2;
            }

            timer.Stop();
            
          
            time_ms = timer.ElapsedMilliseconds;
            


            //отображаем результаты сортировки
            listBox2.Items.Clear();
            listBox2.Visible = true;
            label2.Visible = true;
            label2.Text="Результат сортировки: " + time_ms.ToString()+ " милисек";
            groupBox2.Visible = true;
            for (int i = 0; i < mas.Length; i++)
                listBox2.Items.Insert(i, mas[i].ToString());

        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //скрываем область вывода отсортированного массива с её элементами
            listBox2.Items.Clear();
            listBox2.Visible = false;
            label2.Visible = false;
            groupBox2.Visible = false;

            //скрываем элементы для ввода массива вручную
            label3.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;

            //скрываем диаграмму
            chart1.Visible = false;

            //открываем файл через диалого открытия
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;

                FileStream f = File.Open(name, FileMode.Open, FileAccess.Read);

                if (f != null)
                {
                    StreamReader sr = new StreamReader(f);
                    string str = sr.ReadLine();
                    //удаляем лишние пробелы (с помощью метода Trim() и регулярного выражения
                    str = str.Trim();
                    str = Regex.Replace(str, "[ ]+", " ");

                    //из строки через метод Split() выделяем отдельные элементы массива и заполняем ими массив
                    string[] s = str.Split();
                    int n = s.Length;
                    mas = new int[n];
                    listBox1.Items.Clear();
                    for (int i = 0; i < mas.Length; i++)
                        {
                            mas[i] = int.Parse(s[i]);
                            listBox1.Items.Insert(i, mas[i].ToString());
                        }

                    //отображаем исходный массив
                    label1.Text = "Исходный массив из " + n + " элементов:";
                    listBox1.Visible = true;
                    groupBox1.Visible = true;
                    button1.Visible = true;
                    sr.Close();
                }
                f.Close();

            }
        }

        private void вводВручнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //скрываем область вывода отсортированного массива с её элементами
            listBox2.Items.Clear();
            listBox2.Visible = false;
            label2.Visible = false;
            groupBox2.Visible = false;

            //скрываем область вывода исходного массива с её элементами
            listBox1.Items.Clear();
            listBox1.Visible = false;
            label1.Visible = false;
            groupBox1.Visible = false;

            //скрываем кнопку сортировки
            button1.Visible = false;

            //скрываем диаграмму
            chart1.Visible = false;

            //настраиваем элементы для ввола вручную
            label3.Text = "Введите элементы массива через пробел и нажмите на кнопку Готово";
            label3.Visible = true;
            textBox1.Visible = true;
           // textBox1.Width = this.ClientSize.Width - 30;
            textBox1.Clear();
            button2.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //заполняем массив введёнными в строку числами
            
            //если строка пуста, то выводим ссобщение о необходимости ввода элементов
            if (textBox1.Text == "")
                MessageBox.Show("Необходимо ввести элементы массива");
            else
            {
                //удаляем лишние пробелы (с помощью метода Trim() и регулярного выражения)
                string str = textBox1.Text;
                str = str.Trim();
                str = Regex.Replace(str, "[ ]+", " ");

                //из строки через метод Split() выделяем отдельные элементы массива и заполняем ими массив
                string[] s = str.Split();
                int n = s.Length;
                mas = new int[n];
                listBox1.Items.Clear();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = int.Parse(s[i]);
                    listBox1.Items.Insert(i, mas[i].ToString());
                }

                //скрываем элементы ввода 
                textBox1.Visible = false;
                button2.Visible = false;
                label3.Visible = false;

                //отображаем исходный массив
                label1.Text = "Исходный массив из " + n + " элементов:";
                label1.Visible = true;
                listBox1.Visible = true;
                groupBox1.Visible = true;
                button1.Visible = true;
                
            }
        }

        private void сохранениеРезультатовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            groupBox1.Height = this.ClientSize.Height - 30;
            listBox1.Height = this.ClientSize.Height - 60;
            groupBox2.Height = this.ClientSize.Height - 30;
            listBox2.Height = this.ClientSize.Height - 60;
            textBox1.Width = this.ClientSize.Width - 30;
        }

        private void сохранитьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (time_ms != -1)
                {
                    string filename = saveFileDialog1.FileName;
                    StreamWriter sr = new StreamWriter(filename, true);
                    sr.WriteLine(mas.Length.ToString() + "\t" + time_ms.ToString() + " мс");
                    MessageBox.Show("Статистика сохранена");
                    sr.Close();
                    time_ms = -1;
                }
            }
        }

        private void сохранитьРезультатСортировкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                StreamWriter sr = new StreamWriter(filename, false);
                // сохраняем текст в файл
                for (int i = 0; i < mas.Length; i++)
                {
                    sr.WriteLine(mas[i]);
                }
                MessageBox.Show("Файл сохранен");
                sr.Close();
            }
        }

        private void диаграммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;

                FileStream f = File.Open(name, FileMode.Open, FileAccess.Read);

                if (f != null)
                {
                    StreamReader sr = new StreamReader(f);
                    List<int> masX = new List<int>();
                    List<int> masY = new List<int>();

                    string str = sr.ReadLine();

                    while (str != null)
                    {

                        string[] s = str.Split();
                        masX.Add(int.Parse(s[0]));
                        masY.Add(int.Parse(s[1]));
                        str = sr.ReadLine();
                    }
                    this.chart1.Series["Series1"].Points.DataBindXY(masX, masY);
                    chart1.Visible = true;
                    sr.Close();
                }
                f.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
