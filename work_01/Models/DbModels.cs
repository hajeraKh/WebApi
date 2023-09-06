using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace work_01.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        [Required, StringLength(50)]
        public string DeviceName { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
        [Required, Column(TypeName = "money")]
        public decimal Price { get; set; }
        public bool OnSales { get; set; }
        [Required, StringLength(200)]
        public string Picture { get; set; }
        //nev
        public ICollection<Spec> Specs { get; set; } = new List<Spec>();

    }
    public class Spec
    {
        public int SpecId { get; set; }
        public string SpecName { get; set; }
        public string Value { get; set; }
        [ForeignKey("Device")]
        public int DeviceId { get; set; }
        //nev
        public Device Device { get; set; }
    }
    public class DeviceDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Spec> Specs { get; set; }
    }
}