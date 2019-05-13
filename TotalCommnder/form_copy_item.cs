using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotalCommnder.Presenters;

namespace TotalCommnder
{
    public partial class form_copy_item : Form, IFrameCopyItem
    {
        public form_copy_item()
        {
            InitializeComponent();
        }

        public List<DirectoryElement> Directories
        {
            set
            {
                if (value != null)
                {
                    cbSourceFormCopy.Items.Clear();

                    string[] elements = new string[value.Count];
                    int i = 0;
                    foreach (DirectoryElement folder in value)
                    {
                        elements[i] = folder.Name;
                        i++;
                    }
                    cbSourceFormCopy.Items.AddRange(elements);
                }
                cbSourceFormCopy.SelectedIndex = 0;
            }
        }

        public DirectoryElement GetSelectedItem
        {
            get
            {
                //return (DirectoryElement)cbSourceFormCopy.SelectedItem;
                return new DirectoryElement(DirectoryElementType.DIRECTORY, cbSourceFormCopy.SelectedItem.ToString());
            }
        }

        public event Action Commit;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_commit_Click(object sender, EventArgs e)
        {
            FrameCopyPresenter.selectedItem = GetSelectedItem;
            this.Close();
        }
    }
}
