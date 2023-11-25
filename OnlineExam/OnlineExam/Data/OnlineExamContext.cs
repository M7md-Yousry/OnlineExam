using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineExam.Models;

namespace OnlineExam.Data
{
    public class OnlineExamContext : DbContext
    {
        public OnlineExamContext (DbContextOptions<OnlineExamContext> options)
            : base(options)
        {
        }
        
        public DbSet<OnlineExam.Models.Exams> Exams { get; set; } = default!;
    }
}
