using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder.Presenters
{
    public class FrameNewFolderPresenter : ISubject
    {
        IFrameNewFolder view;
        Model model;
        List<IObserver> observers;
        string msg;

        public FrameNewFolderPresenter(IFrameNewFolder view, Model model)
        {
            observers = new List<IObserver>();
            this.view = view;
            this.model = model;
            this.view.Directories = model.LoadPathfolders("D:\\");
            this.view.call += Call;
        }

        public void showDialog()
        {
            ((form_new_folder)view).ShowDialog();
        }
        public void hideDialog()
        {
            ((form_new_folder)view).Hide();
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

        public void Call()
        {
            msg = $"{view.GetNewFolderDestination}\\{view.GetNewFolderName}";
            notifyAllObservers();
            hideDialog();
        }
    }
}
