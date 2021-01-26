using Interfaces04.Model.Enums;

namespace Interfaces04.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
