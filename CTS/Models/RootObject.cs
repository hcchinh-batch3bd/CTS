using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Models
{
    class RootObject : Object
    {
            public List<Session> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
    }
}
