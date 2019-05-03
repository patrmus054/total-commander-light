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
    public partial class form_file_path_change : Form, IFrameMoveItem
    {
        public form_file_path_change()
        {
            InitializeComponent();
        }

        public string[] Directories
        {
            set
            {
                //foreach(DirectoryElement element in value){

                //}
            }
        }

        private void CbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
