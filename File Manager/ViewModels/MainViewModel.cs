using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace File_Manager
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        #region Public Properties
        public string MainDiskName { get; set; }
        #endregion

        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Constructor
        public MainViewModel()
        {
            MainDiskName = Environment.SystemDirectory;
        }
        #endregion

        #region Protected Methods
        protected virtual void OnPropetryChanged([CallerMemberName] string propetryName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetryName));
        }
        #endregion
    }
}
