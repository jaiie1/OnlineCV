using OnlineCv.Libary.Interface;
using OnlineCV.Api.Models;
using OnlineCV.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCv.Libary
{
    public class JobbRepository : IJobbrepository
    {
        private readonly ApplicationDbContext _contex;
        private static ConcurrentDictionary<string, Jobb> jobbCache;

        public JobbRepository(ApplicationDbContext context)
        {
            this._contex = context;

            if(jobbCache == null)
            {
                jobbCache = new ConcurrentDictionary<string, Jobb>((IEqualityComparer<string>)_contex.jobbs.ToDictionary(c => c.Id));
            }
        }


        public Jobb Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Jobb>>GetAll()
        {
            return Task.Run<IEnumerable<Jobb>>(
                () => jobbCache.Values);
        }
    }
}
