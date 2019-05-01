using JerryMvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JerryMvc5.ViewMdel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}