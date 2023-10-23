using System;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace TestPictures
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openFileDialog1.FileName, $"..\\Resources\\{openFileDialog1.SafeFileName}");

                //using (ResXResourceWriter resx = new ResXResourceWriter(@".\Resources.resx"))
                //{
                //    resx.AddResource("Title", "Classic American Cars");
                //}
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
