using System;

namespace WebApp.Models
{
    public class VideoGame
    {
        public int Id { get; set; } // 1, 2, 3, 4, ...
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public int PlatformId { get; set; }

        public Platform Platform { get; set; }
    }
}