using ForekBase.Application.Common.Interfaces;
using ForekBase.Domain.Entities;
using ForekBase.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForekBase.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Add(Category survey)
        {
            _db.Categories.Add(survey);
        }

        public void Remove(Category category)
        {
            _db.Categories.Remove(category);
        }

        public void Save(Category survey)
        {
            _db.SaveChanges();
        }

        public void Update(Category survey)
        {
            _db.Categories.Update(survey);
        }
    }
}
