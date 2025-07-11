﻿using myshop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myshop.Models.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        void update(Category category);
    }
}
