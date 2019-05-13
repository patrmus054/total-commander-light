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
        public event Action Move;
        public event Action Delete;
        public event Action NewFolder;
        public event Action Copy;
        public event Action ShowDialog;

        public Form1()
        {
            InitializeComponent();
         
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


        private void BtMove_Click(object sender, EventArgs e)
        {
            Move();
            //form.Directories = tcPanel1.get
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            Delete?.Invoke();
        }

        private void BtCopy_Click(object sender, EventArgs e)
        {
            Copy?.Invoke();
        }

        private void BtNewFolder_Click(object sender, EventArgs e)
        {
            NewFolder?.Invoke();
        }
    }
}
