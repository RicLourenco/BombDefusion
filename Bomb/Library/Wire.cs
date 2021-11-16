using System;
using System.Collections.Generic;
using System.Text;

namespace Bomb.Library
{
    public enum Colors
    {
        white,
        black,
        red,
        green,
        orange,
        purple
    }

    public class Wire
    {
        public Colors Color { get; set; }

        public List<Colors> RelatedColors { get; set; }
    }
}
