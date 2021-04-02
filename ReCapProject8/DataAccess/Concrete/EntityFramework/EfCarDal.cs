using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var result = (from car in context.Cars
                             join c in context.Colors on car.ColorId equals c.Id
                             join b in context.Brands on car.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 ColorName = c.ColorName,
                                 BrandName = b.BrandName,
                                 Description = car.Description
                             });

                return result.ToList();
            }
        }
    }
}
