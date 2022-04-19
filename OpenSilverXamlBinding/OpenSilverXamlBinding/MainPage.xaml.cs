using System.ComponentModel;
using System.Windows.Controls;

namespace OpenSilverXamlBinding
{
    public class Model : INotifyPropertyChanged
    {
        private string _customText = "";

        public string CustomText
        {
            get => _customText;
            set
            {
                _customText = value;
                OnPropertyChanged("CustomText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class MainPage : Page
    {
        private readonly Model _model = new Model
        {
            CustomText = "This text is set via Binding"
        };

        public MainPage()
        {
            this.InitializeComponent();

            DataContext = _model;

            // Enter construction logic here...
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _model.CustomText = "Text Changed";
        }
    }
}
