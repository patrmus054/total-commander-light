using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    class Presenter
    {
        public Model model;
        public IView view;
        PanelPresenter leftPanelPresenter, rightPanelPresenter;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            leftPanelPresenter = new PanelPresenter(this.view.PanelLeft, model);
            rightPanelPresenter = new PanelPresenter(this.view.PanelRight, model);
            this.view.Move += Move;
            this.view.ShowDialog += ShowDialog;
            this.view.Delete += Delete;
            this.view.Copy += Copy;
            this.view.NewFolder += NewFolder;
        }

        public void Move()
        {
            model.Move(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.getSeletedItem());
        }
        public void Delete()
        {
            model.Delete(leftPanelPresenter.getSeletedItem());
        }

        public void Copy()
        {
            if(rightPanelPresenter.getSeletedItem() == null)
                model.Copy(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.currentPath);
            else
                model.Copy(leftPanelPresenter.getSeletedItem(), rightPanelPresenter.getSeletedItem().Name);
        }
        public void NewFolder()
        {
            model.NewFolder(new DirectoryElement(DirectoryElementType.DIRECTORY,"uu"), leftPanelPresenter.currentPath);
        }

        public void ShowDialog()
        {
        }

    }
}
