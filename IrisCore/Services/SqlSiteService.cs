using IrisCore.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Services
{
    public class SqlSiteService
    {
        public SqlSiteService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public IEnumerable<vWaSite> GetWaSites(IrisDbContext context)
        {
            return context.vWaSite.ToList(); // Kan den vara async?
        }
    }
}
 