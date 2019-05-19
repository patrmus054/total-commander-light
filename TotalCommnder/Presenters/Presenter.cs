using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalCommnder.Presenters;

namespace TotalCommnder
{
    class Presenter
    {
        public Model model;
        public IView view;
        PanelPresenter leftPanelPresenter, rightPanelPresenter;
        FrameCopyPresenter frameCopy;
        FrameMovePresenter frameMove;
        FrameNewFolderPresenter frameNewFolder;

        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;

            leftPanelPresenter = new PanelPresenter(this.view.PanelLeft, model);
            rightPanelPresenter = new PanelPresenter(this.view.PanelRight, model);
            frameCopy = new FrameCopyPresenter(new form_copy_item(), model);
            frameMove = new FrameMovePresenter(new form_move_item(), model);
            frameNewFolder = new FrameNewFolderPresenter(new form_new_folder(), model);

            this.view.Move += Move;
            this.view.ShowDialog += ShowDialog;
            this.view.Delete += Delete;
            this.view.Copy += Copy;
            this.view.NewFolder += NewFolder;
        }

        public void Move()
        {
            frameMove.showDialog();
            //model.Move(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.getSeletedItem());
        }
        public void Delete()
        {
            //model.Delete(leftPanelPresenter.getSeletedItem());
        }

        public void Copy()
        {
            //if(rightPanelPresenter.getSeletedItem() == null)
            //    model.Copy(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.currentPath);
            //else
            //    model.Copy(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.getSeletedItem().Name);
            frameCopy.showDialog();
        }
        public void NewFolder()
        {
            frameNewFolder.showDialog();
            model.NewFolder(new DirectoryElement(DirectoryElementType.DIRECTORY,"uu"), leftPanelPresenter.currentPath);
        }

        public void ShowDialog()
        {
        }

    }
}
