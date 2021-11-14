using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DemoMVC.Data;
using System;
using System.Linq;

namespace DemoMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDBContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        StudentID = "001",
                        StudentName = "Nguyễn Văn A",
                        Address = "Hà Nội"
                        
                    },

                    new Student
                    {
                        StudentID = "002",
                        StudentName = "Lê Văn B",
                        Address = "Hải Phòng"
                        
                    },

                    new Student
                    {
                        StudentID = "003",
                        StudentName = "Phùng Văn C",
                        Address = "Quảng Ninh"
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}