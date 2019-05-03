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
            this.view.move += Move;
            
        }

        public void Move()
        {
            form_file_path_change form = new form_file_path_change();
            form.ShowDialog();
        }

    }
}
