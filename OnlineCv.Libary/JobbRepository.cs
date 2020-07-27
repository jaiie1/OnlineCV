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

        public JobbRepository(ApplicationDbContext context)
        {
            this._contex = context;           
        }


        public Jobb Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jobb>GetAll()
        {
            return _contex.jobbs;
        }
    }
}
