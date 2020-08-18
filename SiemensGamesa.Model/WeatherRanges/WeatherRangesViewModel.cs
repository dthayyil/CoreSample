using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiemensGamesa.Model.WeatherRanges
{
    public class WeatherRangesViewModel
    {
        public int Id { get; set; }
        [Required]
        public int Min { get; set; }
        [Required]
        public int Max { get; set; }
        [Required]
        public string Adjective { get; set; }
    }
}
