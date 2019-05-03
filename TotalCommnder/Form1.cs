using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCommnder
{
    public partial class Form1 : Form, IView
    {
        public event Action move;

        public Form1()
        {
            InitializeComponent();
            //tcPanel1.CurrentPath = "C:\\";
            //tcPanel1.Drives = System.IO.Directory.GetLogicalDrives();
        }

        public IPanelView PanelLeft
        {
            get
            {
                return tcPanel1;
            }
        }
            

        public IPanelView PanelRight
        {
            get
            {
                return tcPanel2;
            }
        }

        private void TcPanel1_Load(object sender, EventArgs e)
        {

        }

        private void BtMove_Click(object sender, EventArgs e)
        {
            form_file_path_change form = new form_file_path_change();
            form.ShowDialog();
           // move();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
