using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Commun
{
    public class UserModelReset
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Id { get; set; }
    }
}
