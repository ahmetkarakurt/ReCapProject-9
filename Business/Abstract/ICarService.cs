﻿using Entitiy.Concrete;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarService
    {
        List<Car> GetAll();

        Car GetById(Car car);

        void add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<CarDetails> GetCarDetails();

    }
}
