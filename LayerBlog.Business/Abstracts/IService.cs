﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Abstracts
{
    public interface IService
    {
        //herhangi zmanda instance ın bi servic olup olmadığını kontrol etmek istediğimizde (typeof) işimize yarar byk projelerde özellikle
        //if(typeof(instance) == typeof(IService)) ...
    }
}
