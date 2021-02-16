using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;

        }

        public void add(Car car)
        {
            if (car.Description.Length>=2 && car.DailyPrice>0 )         
                _CarDal.Add(car);
            
          
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
          return  _CarDal.GetAll();
        }

        public Car GetById(Car car)
        {
          return  _CarDal.Get(c=>c.Id==car.Id);
        }

        public List<CarDetails> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}
