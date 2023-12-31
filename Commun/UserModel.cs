﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Commun
{
    public class UserModel
    {
        [JsonIgnore]
        public string Username { get; set; }

        [JsonIgnore]
        public string Email { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Id { get; set; }
    }
}
