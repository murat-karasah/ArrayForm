using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForm
{
    public partial class Form1 : Form
    {
      public  string[] students = new string[5];
        public int[] note = new int[5];
        public int index;
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            students[index] = txtName.Text;
            note[index] = Convert.ToInt32(txtNote.Text);
            listBox1.Items.Add("Adı:" + students[index] + " not:" + note[index]);

            index++;
            if (index==5)
            {
                btnSave.Enabled = false;
            }
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            string arama = pushName.Text;
            int index1 = Array.IndexOf(students,arama);
            int asd = note[index1]; 
           txtPush.Text=  asd.ToString();
            
        }
    }
}
