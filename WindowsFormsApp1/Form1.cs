using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lv_ThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_ThongTin.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lv_ThongTin.SelectedItems)
                {
                    ListViewItem items = lv_ThongTin.Items[0];
                    txtFirstName.Text = item.SubItems[0].Text;
                    txtLastName.Text = item.SubItems[1].Text;
                    txtPhone.Text = item.SubItems[2].Text;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtFirstName.Text);
            item.SubItems.Add(txtLastName.Text);
            item.SubItems.Add(txtPhone.Text);
            lv_ThongTin.Items.Add(item);

            txtPhone.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lv_ThongTin.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_ThongTin.SelectedItems[0];
                item.SubItems[0].Text = txtFirstName.Text;
                item.SubItems[1].Text = txtLastName.Text;
                item.SubItems[2].Text = txtPhone.Text;

                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv_ThongTin.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lv_ThongTin.SelectedItems)
                {
                    txtFirstName.Text = item.SubItems[0].Text;
                    txtLastName.Text = item.SubItems[1].Text;
                    txtPhone.Text = item.SubItems[2].Text;
                    lv_ThongTin.Items.Remove(item);
                }
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
            }
        }
    }
}
