using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnEntities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kiettest();
        }


        public void kiettest()
        {
            string hello = "xin chao";
            MessageBox.Show(hello);
        }
    }
}
