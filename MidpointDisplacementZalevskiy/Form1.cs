using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidpointDisplacementZalevskiy
{
    public partial class Form1 : Form
    {
        Random rnd;
        Pen pen;
        Graphics g;
        private bool flag_time_to_stop = false;
        private int xStart,yStart,xEnd,yEnd;
        private int x0, y0;
        public Form1()
        {
            this.rnd = new Random();
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.Black, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.textBox_roughness.Text = 0.3.ToString();
            this.textBox_iterations.Text = 50.ToString();
            this.textBox_time_to_stop.Text = 0.ToString();
            this.radioButton1_disable_time_to_stop.Checked = true;
            this.textBox_time_to_stop.Visible = false;
            this.label_time_to_stop.Visible = false;
            
        }

        private void button_start_Click(object sender, EventArgs e) // сгенерировать
        {
            GenerateMidpoint();
        }
        private void GenerateMidpoint()
        {
            var time_to_stop = 0;
            if(this.flag_time_to_stop && textBox_time_to_stop.Text == "")
            {
                MessageBox.Show("Введите время для остановки");
                return;
            }
            else
            {
                time_to_stop = int.Parse(this.textBox_time_to_stop.Text);
            }
            if(this.textBox_iterations.Text == "" || this.textBox_roughness.Text == "" || xStart * yStart * xEnd * yEnd == 0)
            {
                MessageBox.Show("Введите все данные или создайте прямую!");
                return;
            }
            var leftPosition = this.pictureBox1.Height / 2 - yStart;
            var rightPosition = this.pictureBox1.Height / 2 - yEnd;
            var len = xEnd - xStart;


            var iterations = int.Parse(this.textBox_iterations.Text);         
            var roughness = double.Parse(this.textBox_roughness.Text);
            


            double[] vector = new double[iterations];
            for(var i =0;i< iterations; i++)
            {
                vector[i] = 0; // заполнение
            }
            //len = xEnd
            //leftPos = yStart
            //rightPos = yEnd
            //len = xEnd - xStart;
            vector[0] = leftPosition;
            vector[vector.Length-1] = rightPosition;          
            Midpoint(vector, 0, vector.Length - 1, len, roughness);
            DrawLines(vector, len, iterations, leftPosition,time_to_stop);       
        }

        private void button_clear_canvas_Click(object sender, EventArgs e)
        {
            this.g.Clear(Color.DarkGray);
            this.pictureBox1.Invalidate();
            this.xStart = 0;
            this.yStart= 0;
            this.xEnd = 0;
            this.yEnd = 0;
        }

        private void radioButton_time_to_stop_CheckedChanged(object sender, EventArgs e)
        {
            this.flag_time_to_stop = true;
            this.label_time_to_stop.Visible = true;
            this.textBox_time_to_stop.Visible = true;
            this.textBox_time_to_stop.Text = "0";
        }

        private void radioButton1_disable_time_to_stop_CheckedChanged(object sender, EventArgs e)
        {
            this.flag_time_to_stop = false;
            this.label_time_to_stop.Visible = false;
            this.textBox_time_to_stop.Visible = false;
        }

        private void DrawLines(double[] vector,int len, int iterations, int left, int time_to_stop)
        {
            TimeSpan ts = new TimeSpan(0, 0, time_to_stop); // для остановки рисования
            g.Clear(Color.DarkGray); // перезаливает канвас
            g.DrawLine(pen, xStart, yStart, xEnd, yEnd); // Рисует прямую
            if (iterations==1)
            {
                iterations++;
            }
            var step = len / (iterations - 1);
            Point prev_p = new Point(xStart, pictureBox1.Height / 2 - left);
            for (int i = 0;i< vector.Length;i++)
            {
               
                Point cur_p = new Point(xStart + (step * (i)), pictureBox1.Height / 2 - (int)vector[i]); // тут рисует по середине
                System.Threading.Thread.Sleep(50); // для отрисовки
                g.DrawLine(new Pen(Color.Black, 3), prev_p, cur_p);
                pictureBox1.Refresh();
                if(flag_time_to_stop)
                {
                    ts -= TimeSpan.FromSeconds(1);
                    if (ts == TimeSpan.Zero)
                    {
                        break;
                    }
                }
                prev_p = cur_p;               
            }
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = Convert.ToInt32(e.X); 
            y0 = Convert.ToInt32(e.Y); 
            if (xStart < 1 && yStart < 1)
            {
                xStart = x0;
                yStart = y0;
            }
            else
            {
                xEnd = x0;
                yEnd = y0;
                g.DrawLine(pen, xStart, yStart, xEnd, yEnd);
                pictureBox1.Invalidate();
            }
        }
        private double GetRand(double min, double max)
        {
            return min + Math.Floor(this.rnd.NextDouble() * (max - min));
        }
        private void Midpoint(double[] vector, int leftIndex, int rightIndex, int len, double r)
        {
            if(len < 1)
            {
                return;
            }
            var hl = vector[leftIndex];
            var hr = vector[rightIndex];
            var h = (hl + hr) / 2 + GetRand(-r * len, r * len);
            int index = (int)Math.Floor(leftIndex + (rightIndex - leftIndex) / 2.0);
            vector[index] = h;
            Midpoint(vector, leftIndex, index, len / 2, r);
            Midpoint(vector, index, rightIndex, len / 2, r);
        }
    }
}
