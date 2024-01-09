using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebApi.Models
{
    public class dbContext : DbContext //контекст для взаимодействия с базой данных
    {
        public DbSet<QSelectOutOfFour> QSelectOutOfFours { get; set; }
        public DbSet<QSelectOutOfThreePic> QSelectOutOfThreePics { get; set; }
        public DbSet<QWriteRightAnswer> QWriteRightAnswers { get; set; }
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }
        public DbSet<QSelectOutOfFourDTO> QSelectOutOfFourDTO { get; set; }
    }
}
