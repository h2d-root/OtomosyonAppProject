using Microsoft.EntityFrameworkCore;
using Projem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projem
{
    public class OtomasyonContext:DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
    }
}
