﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.CustomException
{
    public class NoSutiableDriverFound : Exception
    {   

        public NoSutiableDriverFound(string msg) : base(msg)
        {


        }
    }
}
