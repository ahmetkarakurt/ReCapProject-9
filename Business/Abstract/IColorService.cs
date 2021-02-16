using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IColorService
    {
        List<Color> GetAll();

        Color GetById(Color color);


        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);

    }
}
