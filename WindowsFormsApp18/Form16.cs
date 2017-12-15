using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();//กำหนดให้ f17 เปิด form17 ใหม่
            f17.textBox1.Text = numericUpDown2.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown2 มาเเสดงใน textBox1 ที่อยู่ใน Form17
            f17.textBox2.Text = numericUpDown3.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown3 มาเเสดงใน textBox2 ที่อยู่ใน Form17

            f17.textBox4.Text = numericUpDown5.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown5 มาเเสดงใน textBox4 ที่อยู่ใน Form17
            f17.textBox5.Text = numericUpDown6.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown6 มาเเสดงใน textBox5 ที่อยู่ใน Form17
            f17.textBox6.Text = numericUpDown7.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown7 มาเเสดงใน textBox6 ที่อยู่ใน Form17
            f17.textBox7.Text = numericUpDown8.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown8 มาเเสดงใน textBox7 ที่อยู่ใน Form17
            f17.textBox8.Text = numericUpDown9.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown9 มาเเสดงใน textBox8 ที่อยู่ใน Form17
            f17.textBox9.Text = numericUpDown10.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown10 มาเเสดงใน textBox9 ที่อยู่ใน Form17
            f17.textBox10.Text = numericUpDown11.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown11 มาเเสดงใน textBox10 ที่อยู่ใน Form17
            f17.textBox11.Text = numericUpDown12.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown12 มาเเสดงใน textBox11 ที่อยู่ใน Form17
            f17.textBox12.Text = numericUpDown13.Value.ToString();//ให้ดึงตัวเลขจาก numericUpDown13 มาเเสดงใน textBox12 ที่อยู่ใน Form17
            f17.ShowDialog();//โชว์ form ที่ 17 ขึ้นมาาา

        }
    }
}
