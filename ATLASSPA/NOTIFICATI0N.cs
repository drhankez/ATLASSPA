﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class NOTIFICATI0N : Form
    {
        public NOTIFICATI0N()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private NOTIFICATI0N.enmAction action;
        private int x, y;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer167.Interval = 5000;
                    action = enmAction.close;
                    break;
                case NOTIFICATI0N.enmAction.start:
                    this.timer167.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = NOTIFICATI0N.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer167.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            timer167.Interval = 1;
            action = enmAction.close;
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                NOTIFICATI0N frm = (NOTIFICATI0N)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    //this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    // this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    // this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    //this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.label1.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer167.Interval = 1;
            this.timer167.Start();
        }
    }
}
