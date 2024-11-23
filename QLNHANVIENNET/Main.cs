using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIENNET
{
    public partial class frmmain : Form
    {
        private string loaitk;
        public frmmain(string loaitk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchucvu frmchucvu = new frmchucvu();
            frmchucvu.Show();
            this.Hide();    
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            if(loaitk == "Quản Lý")
            {
                mnudanhmuc.Enabled = true;
                mnuqlhs.Enabled = true; 
                mnuqtht.Enabled = true; 
            }
            if(loaitk =="Nhân Viên")
            {
                mnudanhmuc.Enabled = false;
                mnuqlhs.Enabled = true;
                mnuqtht.Enabled=false;
                
            }
        }
    }
}
