using Microsoft.EntityFrameworkCore;
using Task1Doamin.Models;

namespace Task1utilizes.Models
{
    public class EFAccess : DbContext
    {

        public EFAccess(DbContextOptions<EFAccess> options): base(options)
        {
        }
        public DbSet<Employees> _employees { get; set; }
        public DbSet<Skill> _skill { get; set; }
        public DbSet<SkillMap> _skillMap { get; set; }
        public DbSet<Users> _users { get; set; }
        public DbSet<SoftLock> _softLock { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SkillMap>(
                    eb =>
                    {
                        eb.HasNoKey();
                    });



            modelBuilder
                .Entity<Users>(
                    eb =>
                    {
                        eb.HasNoKey();
                    });
        }




    
}
    //{
    //          Employees _employees = new Employees();
    //    Skill _skill = new Skill();
    //    SkillMap _skillMap = new SkillMap();
    //    Users _users = new Users();
    //    SoftLock _softLock = new SoftLock();

    //}
}
