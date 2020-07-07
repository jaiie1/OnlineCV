using OnlineCv.Libary.Interface;
using OnlineCV.Api.Models;
using OnlineCV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCv.Libary
{
    public class SchoolRepository : ISchoolrepository
    {
        private readonly ApplicationDbContext _context;

        public SchoolRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       //Do when we update. And  gets the list after.     
       public async Task<Response> Update(Request request)
        {
            var schools = new List<School>();
            foreach (var item in request.Schools)
            {
                schools.Add(new School
                {
                    Id = item.Id,
                    SchoolTitle = item.SchoolTitle,
                    SchoolDescription = item.SchoolDescription,
                    SchoolClasses = item.SchoolClasses,
                    SchoolDate = item.SchoolDate
                });
            }

            _context.Schools.UpdateRange(schools);
            await _context.SaveChangesAsync();

            return new Response
            {
                Schools = request.Schools
            };
        }

        //Get all Schools
        public IEnumerable<SchoolViewModel> GetAll()
        {
            var schools = _context.Schools.Select(x => new SchoolViewModel
            {
                Id = x.Id,
                SchoolTitle = x.SchoolTitle,
                SchoolDescription = x.SchoolDescription,
                SchoolClasses = x.SchoolClasses,
                SchoolDate = x.SchoolDate

            }).ToList();

            return schools;
        }

        //Get one School
        public SchoolViewModel GetOne(string title) =>
        
            _context.Schools.Where(x => x.SchoolTitle == title)
                .Select(x => new SchoolViewModel
                {
                    Id = x.Id,
                    SchoolTitle = x.SchoolTitle,
                    SchoolDescription = x.SchoolDescription,
                    SchoolClasses = x.SchoolClasses,
                    SchoolDate = x.SchoolDate
                }).FirstOrDefault();
        

        public class SchoolViewModel
        {
            public int Id { get; set; }
            public string SchoolTitle { get; set; }
            public string SchoolDescription { get; set; }
            public string SchoolClasses { get; set; }
            public DateTime SchoolDate { get; set; }
        }

        public class Request
        {
            public IEnumerable<SchoolViewModel> Schools { get; set; }
        }

        public class Response
        {
            public IEnumerable<SchoolViewModel> Schools { get; set; }
        }

    }
    
}
