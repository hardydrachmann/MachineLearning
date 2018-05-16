using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsML.BE
{
    public class Prediction
    {
        public Dictionary<string, List<Dictionary<string, string>>> prediction { get; set; }
    }
}
