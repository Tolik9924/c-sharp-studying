using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
