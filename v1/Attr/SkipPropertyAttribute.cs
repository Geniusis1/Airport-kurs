﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Airport_kurs.Attr
{
    public class SkipPropertyAttribute : Attribute
    {
    }

    public static class TypeExtensions
    {
        public static PropertyInfo[] GetFilteredProperties(this Type type)
        {
            return type.GetProperties()
                  .Where(pi => !Attribute.IsDefined(pi, typeof(Attr.SkipPropertyAttribute)))
                  .ToArray();
        }
    }
}
