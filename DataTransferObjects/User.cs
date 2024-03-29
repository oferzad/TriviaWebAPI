﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriviaWebAPI.DataTransferObjects
{
    public class User
    {
        public string   Email { get; set; }
        public string  NickName { get; set; }
        public string Password { get; set; }
        public List<AmericanQuestion> Questions { get; set; }
    }
}
