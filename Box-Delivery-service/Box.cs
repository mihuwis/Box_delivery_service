using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Delivery_service
{
    public sealed class Box
    {
        private readonly Double _width;
        private readonly Double _length;
        private readonly Double _height;

        public Box()
        {

        }

        public Box(double width, double length, double height)
        {
            if (width <= 0 || length <= 0 || height <= 0) throw new ArgumentOutOfRangeException("Dimensions need to be greater than Zero");
            if (width > 10 || length > 10 || height > 10) throw new ArgumentOutOfRangeException("Dimensions need to no biger than 10m");
            _width = width;
            _length = length;
            _height = height;
        }
    }
}
