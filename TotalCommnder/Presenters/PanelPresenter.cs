using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    class PanelPresenter
    {
        IPanelView view;
        Model model;

        public PanelPresenter( IPanelView panelView, Model Model)
        {
            this.view = panelView;
            this.model = Model;
            this.view.selectedDriveChange += driveChanged;
            this.view.listViewItemClicked += listViewItemClicked;
            this.view.arrayClicked += backArrowClicked;
        }

        public string currentPath
        {
            get
            {
                return view.CurrentPath;
            }
        }
    

        public void driveChanged()
        {

            view.CurrentPath = "";
            view.ClearListBoxItems();
            view.CurrentPath = view.GetCurrentDrive;
            view.DirectoryElements = model.LoadPathFiles(view.CurrentPath);

        }
      
        public void listViewItemClicked()
        {
            DirectoryElement directoryElement = view.GetListBoxItem;
            if(directoryElement.Type == DirectoryElementType.DIRECTORY && directoryElement != null) {
                view.CurrentPath = directoryElement.Name;
                view.ClearListBoxItems();
                view.DirectoryElements = model.LoadPathFiles(view.CurrentPath);
            }
        }

        public DirectoryElement getSeletedItem()
        {
            return view.GetListBoxItem;
        }
        public void backArrowClicked()
        {
            view.CurrentPath = model.previousPath(view.CurrentPath);
            view.ClearListBoxItems();
            view.DirectoryElements = model.LoadPathFiles(view.CurrentPath);
            
        }



    }
}
