using System.Windows.Controls;

namespace OpenSilverXamlBinding
{
    public partial class MainPage : Page
    {
        public string CustomText { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            CustomText = "This text is set via Binding";

            DataContext = this;

            // Enter construction logic here...
        }
    }
}
