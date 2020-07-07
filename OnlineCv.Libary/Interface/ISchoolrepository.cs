using OnlineCV.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static OnlineCv.Libary.SchoolRepository;

namespace OnlineCv.Libary.Interface
{
    public interface ISchoolrepository
    {
        public SchoolViewModel GetOne(string title);
        public IEnumerable<SchoolViewModel> GetAll();
        public Task<Response> Update(Request request);
    }
}
