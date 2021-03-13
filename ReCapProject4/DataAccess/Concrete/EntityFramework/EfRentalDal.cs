using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var result = (from r in context.Rentals
                             join car in context.Cars on r.CarId equals car.Id
                             join c in context.Customers on r.CustomerId equals c.Id
                             join u in context.Users on c.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 CarName = car.Description,
                                 CustomerName = u.FirstName + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             });
                return result.ToList();
            }
        }
    }
}
