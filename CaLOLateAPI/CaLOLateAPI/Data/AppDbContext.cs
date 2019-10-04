using CaLOLateAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=ChampionsBb")
        {

        }
        /*public AppDbContext() : base("name=ItemsBb")
        {

        }*/

        public DbSet<Champion> Champions { get; set; }
    }
}