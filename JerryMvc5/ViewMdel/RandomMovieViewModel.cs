using JerryMvc5.Controllers;
using JerryMvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JerryMvc5.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}