using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML.XML;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //string path = @"C:\Users\ShenBY\Desktop\date\DataFile\Bureau_WLMQ\Station_LTY\DevProps.xml";
            DevProps devProps = new DevProps();
            TrainWin trainWin = new TrainWin();
            trainWin.DevPropsLoad();
            dataGridView1.DataSource = DevProps.trainWins ;


        }

    }
}
