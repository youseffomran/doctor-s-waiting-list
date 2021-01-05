using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        linkedlist l1 = new linkedlist();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lblpatientname.Visible = true;
                patientnametxt.Visible = true;
                btnConfirm.Visible = true;
                patientnametxt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                l1.addtotail(patientnametxt.Text);
                StreamWriter sw = new StreamWriter("Doctor's Waitng List.txt",true);
                string strData = patientnametxt.Text + " in " + string.Format("{0:HH:mm:ss tt}", DateTime.Now);
                sw.WriteLine(strData);
                sw.Close();
                patientnametxt.Text = "";
                lblpatientname.Visible = false;
                patientnametxt.Visible = false;
                btnConfirm.Visible = false;
                nextpatienttxt.Text = l1.head.value1;              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEnteringRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (l1.head == null)
                {
                    string print = "No Data";
                    nextpatienttxt.Text = print;
                }
                else
                {
                    inroomtxt.Text = l1.head.value1;
                }
                l1.deletehead();
                if (l1.head == null)
                {
                    string print = "No Patients";
                    nextpatienttxt.Text = print;
                }
                else
                    nextpatienttxt.Text = l1.head.value1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
            FileStream fileStream = File.Open("Doctor's Waitng List.txt", FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
            Application.Exit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }          
        }
        private void btnClosingTime_Click(object sender, EventArgs e)
        {
            try
            {
                nextpatienttxt.Text = "";
                inroomtxt.Text = "";
                while (l1.head != null)
                {
                    l1.head = l1.head.next;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new Form();
                TextBox txtShow = new TextBox();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Size = this.Size;
                frm.Font = this.Font;
                frm.Icon = this.Icon;
                frm.Text = "Patient List";
                txtShow.Multiline = true;
                txtShow.Dock = DockStyle.Fill;
                frm.Controls.Add(txtShow);
                StreamReader sr = new StreamReader("Doctor's Waitng List.txt");
                string str = sr.ReadToEnd();
                sr.Close();
                txtShow.Text = str;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnEarnings_Click(object sender, EventArgs e)
        {
            try
            {
                int costperpatient = 100;
                int totalearnings = l1.counter * costperpatient;
                MessageBox.Show("Total Number of Patient = " + l1.counter
                                + "\n" + "Cost Per Patient = " + costperpatient
                                + "\n" + "Total Earnings = " + totalearnings);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } 
   /* public class node
    {
        public string value1;
        public node next;
        public node(string value1)
        {
            this.value1 = value1;
        }
    } */
   public class linkedlist
    {
        public node head;
        public node tail;
        public int counter = 0;         
        public void addtotail(string value1)
        {
            node newnode = new node(value1);
            if (head == null)
            {
                head = tail = newnode;
                counter++;
            }
            else
            {
                tail.next = newnode;
                tail = newnode;
                counter++;
            }
        }
        public void deletehead()
        {
            if (head == null)
            {
                Console.WriteLine("");
            }
            else
                head = head.next;
        }
    }
}