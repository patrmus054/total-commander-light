using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCommnder
{
    public partial class TCPanel : UserControl, IPanelView
    {
        private string[] currentDrive;
        public event Action LoadDrivesList;
        public event Action LoadDirectoryElements;
        public event Action selectedDriveChange;
        public event Action pathTextChanged;
        public event Action listViewItemClicked;
        public event Action updatePathText;

        public TCPanel()
        {
            InitializeComponent();
        }

        public string CurrentPath {
            get
            {
                return tvPath.Text;
            }
            set
            {
                tvPath.Text = value;
            }
        }
        public string[] Drives {
            set
            {
                cbDirveList.Items.Clear();
                cbDirveList.Items.AddRange(value);
            }

            get
            {
                return currentDrive;
            }
        }

        public List<DirectoryElement> DirectoryElements
        {
            set
            {
                foreach(DirectoryElement element in value)
                {
                    //listBox.Items.Add(new ListViewItem(element.ToString()));
                    listBox.Items.Add(element);
                }
            } 
        }

        string IPanelView.GetCurrentDrive {
            get
            {
                return cbDirveList.SelectedItem.ToString();
            }
        }

        private void TCPanel_Load(object sender, EventArgs e)
        {
            Drives = System.IO.Directory.GetLogicalDrives();
        }

        private void TvPath_TextChanged(object sender, EventArgs e)
        {
            pathTextChanged?.Invoke();
        }

        private void CbDirveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedDriveChange != null)
                selectedDriveChange();
            updatePathText?.Invoke();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewItemClicked?.Invoke();
            updatePathText?.Invoke();
        }

        public void AddListBoxItem(object item)
        {
            listBox.Items.Add(item);
            
        }

        public void ClearListBoxItems()
        {
            listBox.Items.Clear();
        }

    }
}
