using SiemensGamesa.Core.Entity;
using SiemensGamesa.Core.Infrastructure;
using SiemensGamesa.Model.WeatherRanges;
using SiemensGamesa.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiemensGamesa.Services.Services
{
    public class WeatherRangesServices : IWeatherRangesServices
    {
        private readonly IRepository<WeatherRanges> WeatherRangesRepository;
        private readonly IUnitOfWork UnitofWork;

        public WeatherRangesServices(IRepository<WeatherRanges> weatherRangesRepository,
                                     IUnitOfWork unitofWork)
        {
            WeatherRangesRepository = weatherRangesRepository;
            UnitofWork = unitofWork;
        }

        public void Create(WeatherRangesViewModel model)
        {
            WeatherRanges weatherRanges = new WeatherRanges
            {
                Adjective  = model.Adjective,
                Max = model.Max,
                Min = model.Min, 
            };
            WeatherRangesRepository.Add(weatherRanges);

            SaveChanges();
        }

        public void Delete(int id)
        {
            var item = WeatherRangesRepository.Get(x => x.Id == id);
            WeatherRangesRepository.Delete(item);
            SaveChanges();
        }

        public void Edit(WeatherRangesViewModel model)
        {
            var item = WeatherRangesRepository.Get(x => x.Id == model.Id);
            item.Max = model.Max;
            item.Min = model.Min;
            item.Adjective = model.Adjective;
            SaveChanges(); 
        }

        public WeatherRangesViewModel Get(int id)
        {
            var item = WeatherRangesRepository.Get(x => x.Id == id);
            return new WeatherRangesViewModel { 
            Id = item.Id,
            Adjective = item.Adjective,
            Min = item.Min,
            Max = item.Max,
            };
        }

        public IEnumerable<WeatherRangesViewModel> Index()
        {
            return WeatherRangesRepository.GetAll().Select(x => new WeatherRangesViewModel {
            Adjective = x.Adjective,
            Max = x.Max,
            Id = x.Id,
            Min = x.Min,
            });
        }


        private void SaveChanges()
        {
            UnitofWork.Commit();
        }

    }
}
