using System.Windows;
using System.Windows.Input;

namespace LabelClick
{
    public class MyViewModel : ObservableObject
    {
        private ICommand labelClicked { get; set; }

        public ICommand LabelClicked
        {
            get
            {
                if (labelClicked == null)
                {
                    labelClicked = new RelayCommand(
                        param => TakeAction()
                        );
                }
                return labelClicked;
            }
        }

        private void TakeAction()
        {
            MessageBox.Show("Clicked from ViewModel");
        }
    }
}
