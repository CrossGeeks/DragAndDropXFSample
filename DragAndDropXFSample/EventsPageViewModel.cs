using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DragAndDropXFSample
{
    public class EventsPageViewModel
    {
        public ICommand DragStartingCommand => new Command<Event>((param) =>
         {
             _dragEvent = param;
         });

        public ICommand DropOverCommand => new Command(() =>
        {
            if (Events.Contains(_dragEvent))
                Events.Remove(_dragEvent);
        });

        public ObservableCollection<Event> Events { get; }

        private Event _dragEvent;

        public EventsPageViewModel()
        {
            Events = new ObservableCollection<Event>()
            {
                {new Event("Go for a walk", "Home", DateTime.Now.AddHours(3), Color.OrangeRed) },
                {new Event("Finish PR", "Work", DateTime.Now.AddHours(5), Color.ForestGreen) },
                {new Event("Watch a movie", "Home", DateTime.Now.AddMinutes(40), Color.LightSkyBlue) },
            };
        }
    }
}
