using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using OnlineCV.Api.Models;

namespace OnlineCV.Data
{
    public class MockData
    {
        public static void FillIfEmpty(ApplicationDbContext contex)
        {        

            if (!contex.jobbs.Any())
            {
                var jobbList = new List<Jobb>();
                var onejobb = new Jobb
                {
                    JobbTitel = "Arbetsledare",
                    JobbDescription = "Jobbar med människor",
                    Id = 1
                };

                jobbList.Add(onejobb);
                contex.SaveChanges();
            }
        }
    }
}
