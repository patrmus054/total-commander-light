using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotalCommnder.Presenters;

namespace TotalCommnder
{
    class Presenter : IObserver
    {
        public Model model;
        public IView view;
        PanelPresenter leftPanelPresenter, rightPanelPresenter;
        FrameCopyPresenter frameCopy;
        FrameMovePresenter frameMove;
        FrameNewFolderPresenter frameNewFolder;
        string msg;

        public Presenter(Model model, IView view)
        {
            
            this.model = model;
            this.view = view;

            leftPanelPresenter = new PanelPresenter(this.view.PanelLeft, model);
            rightPanelPresenter = new PanelPresenter(this.view.PanelRight, model);
            frameCopy = new FrameCopyPresenter(new form_copy_item(), model);
            frameMove = new FrameMovePresenter(new form_move_item(), model);
            frameNewFolder = new FrameNewFolderPresenter(new form_new_folder(), model);
            frameCopy.registerObserver(this);
            frameMove.registerObserver(this);
            frameNewFolder.registerObserver(this);

            this.view.Move += Move;
            this.view.Delete += Delete;
            this.view.Copy += Copy;
            this.view.NewFolder += NewFolder;
        }

        public void Move()
        {
            if(leftPanelPresenter.getSeletedItem() == null)
            {
                MessageBox.Show("no file has been selected");

            }else if(rightPanelPresenter.getSeletedItem() == null)
            {
                frameMove.showDialog();
                model.Move(leftPanelPresenter.getSeletedItem(), msg);

            }
            else
            {
                model.Move(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.getSeletedItem());
            }
        }


        public void Copy()
        {
            if(leftPanelPresenter.getSeletedItem() == null) { MessageBox.Show("no file has been selected"); }
            else if (rightPanelPresenter.getSeletedItem() == null)
            {
                frameCopy.showDialog();
                model.Copy(leftPanelPresenter.getSeletedItem(), msg);
            }
            else
            {
                model.Copy(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.getSeletedItem().Name);
            }
        }
        public void NewFolder()
        {
            frameNewFolder.showDialog();
            model.NewFolder(msg);
        }

        public void Delete()
        {
            model.Delete(leftPanelPresenter.getSeletedItem() ?? rightPanelPresenter.getSeletedItem());
        }

        public void callMe(string msg)
        {
            this.msg = msg;
        }
    }
}
