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
            //this.view.selectedDriveChange += setUpListView;

        }

        public void driveChanged()
        {
            //DirectoryElement[] elements =
            //{
            //    new DirectoryElement(DirectoryElementType.DIRECTORY, "folder"),
            //    new DirectoryElement(DirectoryElementType.FILE, "niefolder"),
            //};
            //view.DirectoryElements = elements;

            view.CurrentPath = "";
            view.ClearListBoxItems();
            view.CurrentPath = view.GetCurrentDrive;
            view.DirectoryElements =  model.LoadPathFiles(view.CurrentPath);

            //string[] files = System.IO.Directory.GetFiles(view.GetCurrentDrive.ToString());
            //string[] dirs = System.IO.Directory.GetDirectories(view.GetCurrentDrive.ToString());

            //foreach (string file in files)
            //{
            //    view.AddListBoxItem(file);
            //}
            //foreach (string dir in dirs)
            //{
            //    view.AddListBoxItem(dir);
            //}
        }
        public void setUpListView()
        {

        }


    }
}
