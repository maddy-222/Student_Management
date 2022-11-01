using EFMVC_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMVC_CRUD.Context
{
    public class MVCContext: DbContext
    {
        public MVCContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
