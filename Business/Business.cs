using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business
{
    public class Business
    {
        private CarContext carContext;
        public List<Car> GetAll()
        {
            using (carContext = new CarContext())
            {
                return carContext.Car.ToList();
            }
        }
        public Car Get(int id)
        {
            using (carContext = new CarContext())
            {
                return carContext.Car.Find(id);
            }
        }
        public void Update(Car car)
        {
            var item = carContext.Car.Find(car.ID);
            using (carContext = new CarContext())
            {
                if (item != null)
                {
                    carContext.Entry(item).CurrentValues.SetValues(car);
                    carContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            var item = carContext.Car.Find(id);
            using (carContext = new CarContext())
            {
                if (item != null)
                {
                    carContext.Car.Remove(item);
                    carContext.SaveChanges();
                }
            }
        }
    }
}
