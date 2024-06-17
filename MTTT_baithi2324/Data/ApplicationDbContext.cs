using System.Data.Common;
using MTTT_baithi2324.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;

namespace MTTT_baithi2324.Data;

    public class ApplicationDbContext: DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){}
        public DbSet<MTTT651Person> Person { get ; set; }
        }
        