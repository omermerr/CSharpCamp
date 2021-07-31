using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarID=1, BrandID=1, ColorID=1, ModelYear=2021, DailyPrice=200000, Description="Mercedes AMG 2021 White"},
                new Car {CarID=2, BrandID=2, ColorID=2, ModelYear=2020, DailyPrice=150000, Description="BMW M4 2020 Black"},
                new Car {CarID=3, BrandID=3, ColorID=2, ModelYear=2019, DailyPrice=125000, Description="AUDİ A8 2019 Black"},
                new Car {CarID=4, BrandID=4, ColorID=1, ModelYear=2018, DailyPrice=120000, Description="HONDA S200 2018 White"},
                
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarID == car.CarID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(int CarID)
        {
            return _cars.Where(c => c.CarID == CarID).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            carToUpdate.CarID = car.CarID;
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
