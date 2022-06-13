using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace File_Manager
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Protected Methods
        protected virtual void OnPropetryChanged([CallerMemberName] string propetryName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetryName));
        }
        #endregion
    }

}
