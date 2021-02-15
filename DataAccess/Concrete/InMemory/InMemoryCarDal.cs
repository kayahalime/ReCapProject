using DataAccess.Abstarct;
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
                new Car{Id=1,BrandId=1,ColorId=5,ModelYear=2017,DailyPrice=100000,Description="1. Araba"  },
                new Car{Id=2,BrandId=5,ColorId=3,ModelYear=2019,DailyPrice=150000,Description="2. Araba"  },
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2010,DailyPrice=90000,Description="3. Araba"  },
                new Car{Id=4,BrandId=2,ColorId=1,ModelYear=2001,DailyPrice=50000,Description="4. Araba"  },
                new Car{Id=5,BrandId=1,ColorId=5,ModelYear=2020,DailyPrice=250000,Description="5. Araba"  },


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
