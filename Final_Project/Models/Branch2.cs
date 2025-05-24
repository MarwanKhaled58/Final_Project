using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;

namespace Final_Project.Models
{
    public class Branch2
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, Range(-90, 90)]
        public double Latitude { get; set; }
        [Required, Range(-180, 180)]
        public double Longitude { get; set; }
        public string Address { get; set; }
        public Geometry Location { get; set; }
    }
}