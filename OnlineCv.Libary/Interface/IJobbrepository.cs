using OnlineCV.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCv.Libary.Interface
{
    public interface IJobbrepository
    {
        public Task<IEnumerable<Jobb>> GetAll();
        Jobb Get(int id);

    }
}
