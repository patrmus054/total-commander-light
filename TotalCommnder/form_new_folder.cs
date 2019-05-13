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
    public partial class form_new_folder : Form, IFrameNewFolder
    {
        public form_new_folder()
        {
            InitializeComponent();
        }

        public List<DirectoryElement> Directories
        {
            set
            {
                
                if (value != null)
                {
                    cbDestinationPath.Items.Clear();

                    string[] elements = new string[value.Count];
                    int i = 0;
                    foreach (DirectoryElement folder in value)
                    {
                        elements[i] = folder.Name;
                        i++;
                    }
                    cbDestinationPath.Items.AddRange(elements);
                }
            }
        }

        public string GetNewFolderName
        {
            get
            { 
            return tbNewFolderName.Text;
            }
        }

        public string GetNewFolderDestination
        {
            get
            {
                return cbDestinationPath.Text;
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
