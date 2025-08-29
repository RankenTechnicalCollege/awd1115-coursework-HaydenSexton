using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Turning_objects
{
    public class Pancake : ITurnable
    {
        public string Turn()
        {
            return "Pancake - slide flat part of spatula over and flip the pancake";
        }
    }
}
