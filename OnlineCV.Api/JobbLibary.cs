using OnlineCV.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCV.Api
{
    public class JobbLibary
    {
        private readonly List<Jobb> _Jobbs;

        public JobbLibary()
        {
            _Jobbs = new List<Jobb>();
        }

        public IEnumerable<Jobb> GetAll => _Jobbs;

        public void Add(Jobb jobb)
        {
            jobb.Id = _Jobbs.Count + 1;
            _Jobbs.Add(jobb);
        }
    }
}
