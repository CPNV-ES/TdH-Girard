﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace TdH_2.Utils
{
    public class SessionUtils
    {
        static HttpSessionState Session
        {
            get
            {
                if (HttpContext.Current == null)
                    throw new ApplicationException("No Http Context, No Session to Get!");

                return HttpContext.Current.Session;
            }
        }

        public static T Get<T>(string key)
        {
            if (Session[key] == null)
                return default(T);
            else
                return (T)Session[key];
        }

        public static void Set<T>(string key, T value)
        {
            Session[key] = value;
        }
    }
}