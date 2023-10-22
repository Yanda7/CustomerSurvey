using ForekBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForekBase.Application.Common.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Save(Category survey);

        void Remove(Category category);

        void Update(Category category);
    }
}
