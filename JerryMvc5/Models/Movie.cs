﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JerryMvc5.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime RealeaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        public byte NumberInStock { get; set; }
    }
}