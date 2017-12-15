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
    public partial class Form17 : Form
    {
        double num = 0;
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = num + double.Parse(textBox1.Text)* 205000;//แปลงค่าจาก textbox1 นำมา * ด้วยราคารถแล้ว+num ซื้อมีค่าเริ่มต้นเป็น 0
            num = num + double.Parse(textBox2.Text) * 485000;//แปลงค่าจาก textbox2 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน         
            num = num + double.Parse(textBox4.Text) * 1090000;//แปลงค่าจาก textbox4 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox5.Text) * 205000;//แปลงค่าจาก textbox5 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox6.Text) * 1526000;//แปลงค่าจาก textbox6 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox7.Text) * 83000;//แปลงค่าจาก textbox7 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox8.Text) * 220000;//แปลงค่าจาก textbox8 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox9.Text) * 939900;//แปลงค่าจาก textbox9 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox10.Text) * 179500;//แปลงค่าจาก textbox10 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox11.Text) * 785000;//แปลงค่าจาก textbox11 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  
            num = num + double.Parse(textBox12.Text) * 694000;//แปลงค่าจาก textbox12 นำมา * ด้วยราคารถแล้ว+num ซึ่งมีค่าเท่ากับด้านบน  

            label14.Text = num.ToString();//เเสดงค่าของ sum ใน label14 เเละแปลงค่าเป็น string 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();//คำสั่งปิดโปรแกรม
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();//กำหนดให้ F3 เปิด form3 ใหม่
            f3.ShowDialog();//ให้ show form 3 ขึ้นมา
        }
    }
}
