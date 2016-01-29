using System;
 using System.ComponentModel;

namespace Exemple.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        protected ViewModelBase()
        {
        }
        public event PropertyChangedEventHandler PropertyChanged;        
        protected virtual void onPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler!=null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public void Dispose()
        {
            this.onDispose();
        }
        protected virtual void onDispose()
        {

        }
    }
}
