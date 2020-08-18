using SiemensGamesa.Model.WeatherRanges;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiemensGamesa.Services.Contracts
{
    public interface IWeatherRangesServices
    {
        IEnumerable<WeatherRangesViewModel> Index();
        WeatherRangesViewModel Get(int id);

        void Edit(WeatherRangesViewModel model);
        void Create(WeatherRangesViewModel model);

        void Delete(int id);
    }
}
