using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder.Presenters
{
    public class FrameNewFolderPresenter
    {
        IFrameNewFolder view;
        Model model;
        public FrameNewFolderPresenter(IFrameNewFolder view, Model model)
        {
            this.view = view;
            this.model = model;
        }

        public void showDialog()
        {
            ((form_new_folder)view).ShowDialog();
        }
        public void hideDialog()
        {
            ((form_new_folder)view).Hide();
        }
    }
}
