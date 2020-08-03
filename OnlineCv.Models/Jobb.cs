using System;

namespace OnlineCV.Api.Models
{
    public class Jobb
    {
        public int Id { get; set; }
        public string JobbTitel { get; set; }
        public string JobbDescription { get; set; }
        public DateTime dateTime { get; set; }
    }
}
