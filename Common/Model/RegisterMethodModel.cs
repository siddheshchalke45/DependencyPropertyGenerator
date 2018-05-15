﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class RegisterMethodModel
    {
        public RegisterMethodOverload SelectedOverload { set; get; }
        public string NameOfProperty { set; get; }
        public string TypeOfProperty { set; get; }
        public string OwnerOfProperty { set; get; }
    }
}
