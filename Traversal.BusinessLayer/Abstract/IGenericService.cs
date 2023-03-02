﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
