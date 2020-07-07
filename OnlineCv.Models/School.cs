using System;

namespace OnlineCV.Api.Models
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolTitle { get; set; }
        public string SchoolDescription { get; set; }
        public string SchoolClasses { get; set; }
        public DateTime SchoolDate { get; set; }

    }
}
