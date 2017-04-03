using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sauna.Models
{
    public class AppDbContect:DbContext
    {
        public IDbSet<OurService> OurServices { get; set; }
 public IDbSet<Team> Teams { get; set; }
    }
}