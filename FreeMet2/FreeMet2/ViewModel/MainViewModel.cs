using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace FreeMet2.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        #region Dependency Properties

        private int _wMinWidth;

        public int wMinWidth
        {
            get => _wMinWidth;
            set
            {
                _wMinWidth = value;
                this.Set(nameof(wMinWidth), ref value);
            }
        }

        private int _wMinHeight;

        public int wMinHeight
        {
            get => _wMinHeight;
            set
            {
                _wMinHeight = value;
                this.Set(nameof(wMinHeight), ref value);
            }
        }

        #endregion

        #region Command

        public RelayCommand _loadedCommand;

        public RelayCommand LoadedCommand
        {
            get
            {
                if (_loadedCommand == null)
                {
                    _loadedCommand = new RelayCommand(Loaded);
                }

                return _loadedCommand;
            }
        }

        #endregion

        #region Method

        private void Loaded()
        {
            this.wMinHeight = (int)SystemParameters.PrimaryScreenHeight / 2;
            this.wMinWidth = (int)SystemParameters.PrimaryScreenWidth / 2;
        }

        #endregion
    }
}