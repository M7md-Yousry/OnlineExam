using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineExam.Data;
using OnlineExam.Models;
using System;
using System.Linq;

namespace OnlineExam.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new OnlineExamContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<OnlineExamContext>>()))
        {
            // Look for any movies.
            if (context.Exams.Any())
            {
                return;   // DB has been seeded
            }
            context.Exams.AddRange(
                new Exams
                {
                    Question = "What is your first Question ?",
                    Answer1 = "Your First Option",
                    Answer2 = "Your Second Option",
                    Answer3 = "Your Third Option",
                    Answer4 = "Your Fourth Option",
                    Answer5 = "Your Fifth Option",
                    Score = 0,
                }
            );
            context.SaveChanges();
        }
    }
}