using ForekBase.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForekBase.Domain.Entities
{
    public class Category : BaseEntityModel
    {
        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }


    }
}
