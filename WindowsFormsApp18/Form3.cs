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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();//กำหนดให้ F9 เปิด form9 ใหม่
            f9.ShowDialog();//ให้ show form 9 ขึ้นมา
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();//คำสั่งปิดโปรแกรม
        }
    }
}
