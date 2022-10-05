using Demo_Net2.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Net2.Data {

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOpitons<ApplicationDbcontext>opitons) : base(opitons)
        {

        }
        public DbSet<Student>Student{get;set;}
    }
}