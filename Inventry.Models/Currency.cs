using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
    }
}
