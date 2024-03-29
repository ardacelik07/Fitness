﻿using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBlogPostService
    {
        IDataResult <List<BlogPost>> GetAll();
        IDataResult<BlogPost> getById(int id);
    }
}
