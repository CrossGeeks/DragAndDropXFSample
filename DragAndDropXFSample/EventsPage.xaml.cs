using Xamarin.Forms;

namespace DragAndDropXFSample
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();
            BindingContext = new EventsPageViewModel();
        }
    }
}
