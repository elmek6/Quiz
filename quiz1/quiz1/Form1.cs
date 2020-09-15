using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace quiz1
{
    public partial class Form1 : Form
    {
        int gi = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void lesen(int num)
        {

            if (cboXMLFile.Text == "")
            {
                MessageBox.Show("First choose the book");
                return;
            }
            XDocument doc = XDocument.Load(cboXMLFile.Text);



            var fragen = doc.Descendants("f");

            //MessageBox.Show(fragen.Elements("f").Count);
            //            fragen.Elements("f").Count;

            var c = fragen;

            //            Dictionary<string, string> keyValues = new Dictionary<string, string>();

            scrBarH.Maximum = c.Count();
            scrBarH.Value = gi;

            if ((gi > 0) | (gi < scrBarH.Maximum))  //c.Count()
            {   //for (int i = 0; i < ca.Count(); i++)                

                //listBox1.Items.Add(c.ElementAt(gi).Element("tit").Value);
                //listBox1.Items.Add(c.ElementAt(gi).Element("cor").Value);
                lblAnt.Text = "";

                gi = gi + num;

                List<string> l = new List<string>();

                l.Clear();

                txtFrage.Clear();

                try
                {


                    txtFrage.Text = "";

                    l.Add(c.ElementAt(gi).Element("tit").Value);
                    lblAnt.Text = c.ElementAt(gi).Element("cor").Value;
                    l.Add("");
                    l.Add(c.ElementAt(gi).Element("a").Value);
                    l.Add("");
                    l.Add(c.ElementAt(gi).Element("b").Value);
                    l.Add("");
                    l.Add(c.ElementAt(gi).Element("c").Value);
                    l.Add("");
                    l.Add(c.ElementAt(gi).Element("d").Value);
                    l.Add("");
                    l.Add(c.ElementAt(gi).Element("e").Value);                    



                }
                catch (Exception)
                {

                    //         throw;
                }


                txtFrage.Lines = l.ToArray(); 
            }


            checkBox0.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            if (!chkAnt.Checked)
            {
                lblAnt.Visible = false;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("jjj", "nnn");
            //listBox1.Items.Add("abc");
            lesen(-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lesen(1);
        }

        private void chkFrage_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblAnt.Visible = chkAnt.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        { }

        private void cboXMLFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            gi = 0;
            lesen(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblAnt.Visible = true;
        }

        private void scrBarH_Scroll(object sender, ScrollEventArgs e)
        {
            gi = scrBarH.Value;
            lesen(0);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
}
