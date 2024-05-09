using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Delivery_service
{
    public sealed class Box : IEnumerable<double>, IEquatable<Box>
    {
        private readonly Double _width;
        private readonly Double _length;
        private readonly Double _height;
        private readonly UnitOfMeasure unitOfMeasure;

        public enum UnitOfMeasure
        {
            MILIMETER,
            CENTIMETER,
            METER
        }

        public Box()
        {

        }

        public Box(double width, double length, double height, UnitOfMeasure unit = UnitOfMeasure.METER)
        {
            if (width <= 0 || length <= 0 || height <= 0) throw new ArgumentOutOfRangeException("Dimensions need to be greater than Zero");
            if (width > 10 || length > 10 || height > 10) throw new ArgumentOutOfRangeException("Dimensions need to no biger than 10m");
            _width = width;
            _length = length;
            _height = height;
        }

        public IEnumerator<double> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool IEquatable<Box>.Equals(Box? other)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
