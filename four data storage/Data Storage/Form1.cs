﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Storage
{
    public partial class Form1 : Form
    {
        int fileee;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            fileee += ID.Text.Length;
            fileee += Name_E.Text.Length;
            fileee += Faculty.Text.Length;
            fileee += GPA.Text.Length;
            fileee += Nationality.Text.Length;
            fileee += Address.Text.Length;
            File.AppendAllText("file.txt", "ID: " +
                   ID.Text + " Name: " + Name_E.Text + " Faculty: " +
                   Faculty.Text + " Address: " + Address.Text +
                   " Nationality: " + Nationality.Text + " GPA: "
                   + GPA.Text + Environment.NewLine);
            string readText = File.ReadAllText("file.txt");
            fileee = 0;
            richTextBox1.Text = File.ReadAllText("file.txt");
            
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string l;
            int ct = 0;
            
            System.IO.StreamReader file = new System.IO.StreamReader("file.txt");
            while ((l = file.ReadLine()) != null)
            {
                    if (l.Contains(ID_S.Text))
                    {
                        richTextBox1.Text = l;
                    }

                ct++;
            }
            
            file.Close();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string l2;
            int ct = 0;
            
            System.IO.StreamReader file = new System.IO.StreamReader("file.txt");
            while ((l2 = file.ReadLine()) != null)
            {
                if (l2.Contains(Name_S.Text))
                {
                    richTextBox1.Text = l2;
                }

                ct++;
            }
            file.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}