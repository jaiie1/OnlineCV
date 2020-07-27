using OnlineCV.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCv.Libary.Interface
{
    public interface IJobbrepository
    {
        public IEnumerable<Jobb> GetAll();
        Jobb Get(int id);

    }
}
