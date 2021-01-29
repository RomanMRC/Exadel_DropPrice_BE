﻿using DAL.DataContext;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TownRepository : Repository<Town>, ITownRepository
    {
        public TownRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Town> GetTowns()
        {
            return GetAll();
        }
    }
}
