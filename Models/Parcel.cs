using System.ComponentModel.DataAnnotations;

namespace PageUpProject.Models
{
    public class Parcel
    {

        //[Key]
        //public int Id { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double Width { get; set; }

    }
}

