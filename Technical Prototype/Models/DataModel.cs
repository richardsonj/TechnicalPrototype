using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace Technical_Prototype.Models
{
    public class DataModel
    {
        [Key]
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set;}
    }

    public class DataDBContext : DbContext
    {
        public DbSet<DataModel> Data { get; set; }
    }
}

