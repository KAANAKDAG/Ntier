using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.Entities
{
    using Core4;
    using Ntier.Core4.Entities;

    public class Category :CoreEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
