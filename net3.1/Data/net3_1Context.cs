using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using net3._1.Models;

namespace net3._1.Data
{
    public class net3_1Context : DbContext
    {
        public net3_1Context (DbContextOptions<net3_1Context> options)
            : base(options)
        {
        }

    }
}
