using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_FootballBetting.Data.Models
{
    public class Town
    {
        public Town()
        {
            this.Towns = new HashSet<Town>();
        }

        [Key]
        public int TownId { get; set; }

        [Required]
        [MaxLength(85)]
        public string Name { get; set; }


        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
