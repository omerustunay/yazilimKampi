using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RecapDbContext>, ICarImageDal
    {
        public List<CarImageDetailDto> GetCarImageDetails()
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var result = from c in context.CarImages
                             join car in context.Cars on c.CarId equals car.Id
                             join b in context.Brands on car.BrandId equals b.Id
                             join co in context.Colors on car.ColorId equals co.Id
                             select new CarImageDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = car.Description,
                                 ColorName = co.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Date = c.Date,
                                 ImagePath = c.ImagePath,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
