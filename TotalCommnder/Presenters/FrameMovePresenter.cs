using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder.Presenters
{
    public class FrameMovePresenter
    {
        IFrameMoveItem view;
        Model model;
        public FrameMovePresenter(IFrameMoveItem view, Model model)
        {
            this.view = view;
            this.model = model;
        }

        public void showDialog()
        {
            ((form_move_item)view).ShowDialog();
        }
        public void hideDialog()
        {
            ((form_move_item)view).Hide();
        }
    }
}
