using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            var points = new List<Point>();
            var point1 = new Point(1, 2, iconFactory.GetPointIcon(PointType.CAFE));
            var point2 = new Point(10, 20, iconFactory.GetPointIcon(PointType.RESTAURANT));
            points.Add(point1);
            points.Add(point2);

            return points;
        }
    }
}
