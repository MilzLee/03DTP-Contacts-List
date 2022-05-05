﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace _03DTP_Contacts_List
{
    public partial class Contact_Edit : Form
    {
        public static string name = Form1.edit_contactName;
        public static string number = Form1.edit_contactNum;
        public static string age = Form1.edit_contactAge;

        public Contact_Edit()
        {
            InitializeComponent();
            displayName.Text = name;
            displayNumber.Text = number;
            displayAge.Text = ("Age: [ " + age + " ]");
        }

        // Activates the Name textbox
        private void btnName_Click(object sender, EventArgs e)
        {
            editName.Enabled = true;
            this.ActiveControl = editName;
            editName.Text = "";

        }
        // Readies the contact name to be passed into Form1 
        private void okName_Click(object sender, EventArgs e)
        {
            editName.Enabled = false;
            name = editName.Text;
            displayName.Text = name;
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            editNumber.Enabled = true;
            this.ActiveControl = editNumber;
            editNumber.Text = "";

        }

        private void okNumber_Click(object sender, EventArgs e)
        {
            number = editNumber.Text;
            if (Regex.IsMatch(number, @"^\d+$"))
            {
                displayNumber.Text = number;
                editNumber.Enabled = false;
            }
            else
            {
                editNumber.Text = "";
                this.ActiveControl = editNumber;

            }

        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            editAge.Enabled = true;
            this.ActiveControl = editAge;
            editAge.Text = "";
        }

        private void okAge_Click(object sender, EventArgs e)
        {
            age = editAge.Text;
            if (Regex.IsMatch(age, @"^\d+$"))
            {
                displayAge.Text = ("Age: [ " + age + " ]");
                editAge.Enabled = false;
            }
            else
            {
                editAge.Text = "";
                this.ActiveControl = editAge;
            }
        }

        private void okEdit_Click(object sender, EventArgs e)
        {
            Form1.edit_contactName = name;
            Form1.edit_contactNum = number;
            Form1.edit_contactAge = age;
            Form1.editConfirm = true;
            this.Close();
        }
    }
}
