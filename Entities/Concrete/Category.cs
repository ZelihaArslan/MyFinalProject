using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        //Cıplak Class Kalmasın
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
