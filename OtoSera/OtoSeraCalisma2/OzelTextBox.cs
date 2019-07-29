﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication4
{
    public class OzelTextBox : TextBox
    {
        private string arkayazi = "";
        Label lbl = new Label();

        public OzelTextBox()
        {
            lbl.Click += new System.EventHandler(lbl_click);
            lbl.Location = new Point(2, 1);
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.Gray;
            base.Controls.Add(lbl);
        }
        public Font ArkayaziFont
        {
            get
            {
                return lbl.Font;
            }
            set
            {
                lbl.Font = value;
            }
        }
        public string Arkayazi
        {
            get
            {
                return arkayazi;
            }
            set
            {
                this.arkayazi = value;
                base.ForeColor = Color.Gray;
                lbl.Text = arkayazi;
                if (value != "")
                    base.Controls.Add(lbl);
                lbl.Location = new Point(2, 1);
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (base.Text == "")
                base.Controls.Add(lbl);
        }
        public void lbl_click(object sender, EventArgs e)
        {
            base.Focus();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (base.Text != "")
            {
                base.Controls.Remove(lbl);
            }
            else
            {
                if (this.Arkayazi != "")
                    base.Controls.Add(lbl);
            }

        }
    }
}
