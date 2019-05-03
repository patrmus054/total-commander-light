using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    public interface IPanelView
    {
        string CurrentPath { get; set; }
        string[] Drives { set; }
        string GetCurrentDrive { get; }
        List<DirectoryElement> DirectoryElements { set; }
        void AddListBoxItem(object item);
        void ClearListBoxItems();
        
        event Action LoadDrivesList;
        event Action LoadDirectoryElements;
        event Action selectedDriveChange;
        event Action pathTextChanged;
        event Action listViewItemClicked;
        event Action updatePathText;

    }
}
