﻿using System.ComponentModel.DataAnnotations;

namespace InclusiveCity.Domain.Entities
{
    public class OsmRating
    {
        [Key]
        public int Id { get; set; }
    
        public long OsmId { get; set; }

        public double Rating { get; set; }
    }
}
