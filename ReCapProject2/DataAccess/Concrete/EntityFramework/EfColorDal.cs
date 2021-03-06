using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var addedentity = context.Entry(entity);
                addedentity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var deletedentity = context.Entry(entity);
                deletedentity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var updatedentity = context.Entry(entity);
                updatedentity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
