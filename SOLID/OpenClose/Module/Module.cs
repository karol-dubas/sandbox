using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Module
{
    public class Module
    {
        public Module()
        {
            var shapes = new List<IShape>
            {
                new Rectangle(6, 9),
                new Circle(3)
            };

            RenderShapes(shapes);
        }

        void RenderShapes(List<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Render();
            }
        }
    }
}
