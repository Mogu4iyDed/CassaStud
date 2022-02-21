using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassaStud.BL
{
    public class MyDbContext : DbContext
    {
        protected MyDbContext()
        {
        }
    }
}
