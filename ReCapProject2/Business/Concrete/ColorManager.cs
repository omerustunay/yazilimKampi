using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
             _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(c => c.Id == id);
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
