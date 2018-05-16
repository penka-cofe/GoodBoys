using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBoys.Models
{
    public class MySqlContext : DbContext
    {
    public MySqlContext(DbContextOptions options)
        : base(options)
    { 

    }

    public DbSet<PendingApprove> PendingApprove { get; set; }
    }
}