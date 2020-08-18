using System;
using System.Collections.Generic;

namespace SiemensGamesa.Core.Entity
{
    public partial class WeatherRanges
    {
        public int Id { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Adjective { get; set; }
    }
}
