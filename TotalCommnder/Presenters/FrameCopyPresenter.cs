using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder.Presenters
{
    class FrameCopyPresenter
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


    }
}
