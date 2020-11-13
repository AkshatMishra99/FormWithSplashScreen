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

namespace FormWithSplashScreen
{
    public partial class Form1 : Form
    {
        Dictionary<string, Student> studentList = new Dictionary<string, Student>();
        bool found;
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            if (studentList.Count == 0)
            {
                find_Btn.Enabled = false;
            }
            found = false;
            upd_Btn.Enabled = false;
        }
    
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void find_Btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {

            }
            else
            {
                if (studentList.ContainsKey(textBox1.Text))
                {
                    Student temp = new Student(studentList[textBox1.Text]);
                    nameInput.Text = temp.name;
                    emailInput.Text = temp.email;
                    addInput.Text = temp.address;
                    phInput.Text = temp.phno;
                    pictureBox1.Image = temp.image;
                    found = true;
                    upd_Btn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No result found!");
                }
            }
        }

        private void crt_Btn_Click(object sender, EventArgs e)
        {
            if (found == false)
            {
                foreach(Control c in groupBox1.Controls)
                {
                    c.Enabled = true;
                }
                sub_Btn.Enabled = true;
                rst_Btn.Enabled = true;
            }
        }

        private void upd_Btn_Click(object sender, EventArgs e)
        {
            if (found)
            {
                foreach (Control c in groupBox1.Controls)
                {
                    c.Enabled = true;
                }
            }
        }
        OpenFileDialog op;
        private void upl_Btn_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            op.Multiselect = false;
            if (op.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(op.FileName);
                string filepath = op.FileName;
                Bitmap b = new Bitmap(op.FileName);
                pictureBox1.Image = b;
            }
        }

        private void sub_Btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter Valid Roll Number", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (studentList.ContainsKey(textBox1.Text))
            {
                MessageBox.Show("Enter Valid Roll Number", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameInput.Text.Length == 0)
            {
                MessageBox.Show("Enter Valid Name", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (emailInput.Text.Length == 0)
            {
                MessageBox.Show("Enter Valid Email", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (phInput.Text.Length == 0)
            {
                MessageBox.Show("Enter Valid Phone Number", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addInput.Text.Length == 0)
            {
                MessageBox.Show("Enter Valid Address", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (op.FileName.Length == 0)
            {
                MessageBox.Show("Upload Image First", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Student newStudent = new Student(nameInput.Text, addInput.Text, emailInput.Text, phInput.Text, new Bitmap(op.FileName));
                studentList.Add(textBox1.Text, newStudent);
                MessageBox.Show("Entry Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                find_Btn.Enabled = true;
                foreach (Control c in groupBox1.Controls)
                {
                    c.Enabled = false;
                    try
                    {
                        TextBox t = (TextBox)c;
                        t.Text = "";
                    }
                    catch(Exception E)
                    {
                        continue;
                    }
                    
                }
                sub_Btn.Enabled = false;
                rst_Btn.Enabled = false;
                pictureBox1.Image = null;
            }
        }
    }
    public class Student
    {
        internal string name, address, email, phno;
        internal Bitmap image;
        public Student(string n,string a,string e,string ph,Bitmap img)
        {
            this.name = n;
            this.address = a;
            this.email = e;
            this.phno = ph;
            this.image = img;
        }
        public Student(Student s1)
        {
            this.name = s1.name;
            this.address = s1.address;
            this.email = s1.email;
            this.phno = s1.phno;
            this.image = s1.image;
        }
        public void setDetails(string n,string a,string e,string ph,Bitmap img)
        {
            this.name = n;
            this.address = a;
            this.email = e;
            this.phno = ph;
            this.image = img;
        }
    }
}
