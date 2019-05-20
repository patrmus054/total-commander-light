using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder.Presenters
{
    public class FrameMovePresenter:ISubject
    {
        IFrameMoveItem view;
        Model model;
        List<IObserver> observers;
        string destinationPath;

        public FrameMovePresenter(IFrameMoveItem view, Model model)
        {
            observers = new List<IObserver>();
            this.view = view;
            this.model = model;
            this.view.call += Call;
            view.Directories = model.LoadPathfolders("D:\\");
        }

        public void showDialog()
        {
            ((form_move_item)view).ShowDialog();
        }

        public void hideDialog()
        {
            ((form_move_item)view).Hide();
        }

        public void Call()
        {
            destinationPath = view.getCurrentElement;
            notifyAllObservers();
            hideDialog();
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
                observer.callMe(destinationPath);
            }
        }
    }
}
