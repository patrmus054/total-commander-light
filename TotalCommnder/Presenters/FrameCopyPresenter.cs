using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder.Presenters
{
    public class FrameCopyPresenter: ISubject
    {
        IFrameCopyItem view;
        Model model;
        //public static DirectoryElement selectedItem;
        List<IObserver> observers;
        string msg;

        public FrameCopyPresenter(IFrameCopyItem view, Model model)
        {
            observers = new List<IObserver>();
            this.view = view;
            this.model = model;
            view.Commit += Commit;
            view.Directories = model.LoadPathfolders("D:\\");
        }

        private void Commit()
        {
            msg = view.GetSelectedItem.Name;
            notifyAllObservers();
        }
        public void showDialog()
        {
            ((form_copy_item)view).ShowDialog();
        }
        public void hideDialog()
        {
            ((form_copy_item)view).Hide();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyAllObservers()
        {
            foreach(var observer in observers)
            {
                observer.callMe(msg);
            }
        }
    }
}
