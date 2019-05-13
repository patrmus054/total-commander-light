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
    public partial class form_move_item : Form, IFrameMoveItem
    {
        public form_move_item()
        {
            InitializeComponent();
        }

        public List<DirectoryElement> Directories
        {
            set
            {
                if (value != null)
                {
                    cbDestination.Items.Clear();

                    string[] elements = new string[value.Count];
                    int i = 0;
                    foreach(DirectoryElement folder in value)
                    {
                        elements[i] = folder.Name;
                        i++;
                    }
                    cbDestination.Items.AddRange(elements);

                }
            }
        }

        private void CbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtCommit_Click(object sender, EventArgs e)
        {
            //Move();
        }
    }
}
