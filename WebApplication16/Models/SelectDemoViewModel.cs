using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class SelectDemoViewModel
    {
        public List<Color> Colors { get; set; }
    }

    public class Color
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
