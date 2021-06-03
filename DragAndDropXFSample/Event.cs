using System;
using System.Drawing;

namespace DragAndDropXFSample
{
    public class Event
    {
        public Event(string title, string location, DateTime time, Color color)
        {
            Title = title;
            Location = location;
            Time = time;
            Color = color;
        }

        public string Title { get; }
        public string Location { get; }
        public DateTime Time { get; }
        public Color Color { get; }
    }
}
