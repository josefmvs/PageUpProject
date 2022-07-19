using System.ComponentModel.DataAnnotations;

namespace PageUpProject.Models
{
    public class Rule
    {
        [Key]
        public string Key { get; set; }
        public int Order { get; set; }
        public double CostFactor { get; set; } = 0;
    }
}
