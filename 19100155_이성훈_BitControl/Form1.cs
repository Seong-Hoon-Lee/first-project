using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19100155_이성훈_BitControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        public void SetCheckBox(int num)
        {
            chk0.Checked = (num & 0x01) != 0;
            chk1.Checked = (num & 0x02) != 0;
            chk2.Checked = (num & 0x04) != 0;
            chk3.Checked = (num & 0x08) != 0;
            chk4.Checked = (num & 0x10) != 0;
            chk5.Checked = (num & 0x20) != 0;
            chk6.Checked = (num & 0x40) != 0;
            chk7.Checked = (num & 0x80) != 0;
        }

        public int GetCheckBox()
        {
            int num = 0;
            if (chk0.Checked) num |= 0x01;
            if (chk1.Checked) num |= 0x02;
            if (chk2.Checked) num |= 0x04;
            if (chk3.Checked) num |= 0x08;
            if (chk4.Checked) num |= 0x10;
            if (chk5.Checked) num |= 0x20;
            if (chk6.Checked) num |= 0x40;
            if (chk7.Checked) num |= 0x80;
            return num;
        }
        private void btnToBit_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            SetCheckBox(num);

        }

        private void btnFromBit_Click(object sender, EventArgs e)
        {
            int num=GetCheckBox();

            txtNumber.Text = Convert.ToString(num);
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            int idx = Convert.ToInt32(txtIndex.Text);
            num |= 0x01 << idx;
            txtNumber.Text = Convert.ToString(num);

            SetCheckBox(num);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            int idk = Convert.ToInt32(txtIndex.Text);
            num &= ~(0x01 << idk);
            txtNumber.Text = Convert.ToString(num);

            SetCheckBox(num);

        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            int idk = Convert.ToInt32(txtIndex.Text);
            num ^= 0x01 << idk;
            txtNumber.Text = Convert.ToString(num);
            SetCheckBox(num);
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            int num0, num1, num2, num3, num4, num5, num6, num7;
            int num = Convert.ToInt32(txtNumber.Text);
            num0 = (num & 0x80) << 1;
            num1 = (num & 0x40) << 1;
            num2 = (num & 0x20) << 1;
            num3 = (num & 0x10) << 1;
            num4 = (num & 0x08) << 1;
            num5 = (num & 0x04) << 1;
            num6 = (num & 0x02) << 1;
            num7 = (num & 0x01) << 1;
            num = num0 + num1 +num2+ num3 + num4 + num5 + num6 + num7;
            txtNumber.Text = Convert.ToString(num);
            SetCheckBox(num);
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            int num0, num1, num2, num3, num4, num5, num6, num7;
            int num = Convert.ToInt32(txtNumber.Text);
            num0 = (num & 0x80) >> 1;
            num1 = (num & 0x40) >> 1;
            num2 = (num & 0x20) >> 1;
            num3 = (num & 0x10) >> 1;
            num4 = (num & 0x08) >> 1;
            num5 = (num & 0x04) >> 1;
            num6 = (num & 0x02) >> 1;
            num7 = (num & 0x01) >> 1;
            num = num0 + num1 + num2+ num3 + num4 + num5 + num6 + num7;
            txtNumber.Text = Convert.ToString(num);
            SetCheckBox(num);
        }
    }
}
