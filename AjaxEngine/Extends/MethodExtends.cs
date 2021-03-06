﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace AjaxEngine.Extends
{
    public static class MethodExtends
    {
        public static T GetAttribute<T>(this MethodInfo method)
        {
            object[] attributes = method.GetCustomAttributes(true);
            foreach (object att in attributes)
            {
                if (att is T)
                    return (T)att;
            }
            return default(T);
        }
    }
}
