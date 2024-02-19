using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listwiewprioritets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text; string str2 = textBox2.Text;
            ListViewItem listViewItem = new ListViewItem(textBox1.Text);

            ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem(); listViewSubItem.Text = str2;

            listViewItem.SubItems.Add(listViewSubItem);
            listView1.Items.Add(listViewItem);

            listView1.Sort(textBox1);
            listView1.Sort(textBox2);
        }

    
    }
}
  