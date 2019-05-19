using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder.Presenters
{
    public class FrameCopyPresenter
    {
        IFrameCopyItem view;
        Model model;
        public static DirectoryElement selectedItem;

        public FrameCopyPresenter(IFrameCopyItem view, Model model)
        {
            this.view = view;
            this.model = model;
            view.Commit += Commit;
        }

        private void Commit()
        {
            selectedItem = view.GetSelectedItem;
        }
        public void showDialog()
        {
            ((form_copy_item)view).ShowDialog();
        }
        public void hideDialog()
        {
            ((form_copy_item)view).Hide();
        }


    }
}
