using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL1
{
    public class Ellipse
    {
        public Point CentralPoint { get; private set; }
        public int SemiMinorAxis { get; private set; }
        public int SemiMajorAxis { get; private set; }
        public Ellipse(Point Centralpoint, Point leftTopPoint, Point rightBottomPoint, int Semiminoraxis, int Semimajoraxis)
        {
            if (SemiMajorAxis < SemiMinorAxis)
            {
                throw new ArgumentException(" The Major semi-axis must be greater than the Minor semi-axis ");
            }

            if (Semiminoraxis < 0)
            {
                throw new ArgumentException(" The Minor semi-axis cannot be less than 0 ");
            }

            if (Semimajoraxis < 0)
            {
                throw new ArgumentException(" The Major semi-axis cannot be less than 0 ");
            }

            Centralpoint = CentralPoint;
            Semimajoraxis = SemiMajorAxis;
            Semiminoraxis = SemiMinorAxis;
        }
        public Ellipse(Point leftTopPoint, Point rightBottomPoint)
        {
            if (leftTopPoint.X > rightBottomPoint.X)
            {
                throw new ArgumentException(" Left Top Point must be less or equal to Right Bottom Point ");
            }
            if (leftTopPoint.Y < rightBottomPoint.Y)
            {
                throw new ArgumentException(" Left Top Point must be greater or equal to Right Bottom Point ");
            }

            SemiMajorAxis = (leftTopPoint.Y - rightBottomPoint.Y) / 2;
            SemiMinorAxis = (rightBottomPoint.X - leftTopPoint.X) / 2;

            CentralPoint.X = leftTopPoint.X + SemiMinorAxis;
            CentralPoint.Y = rightBottomPoint.Y + SemiMajorAxis;
        }

        public Ellipse(Point centralPoint, int semiMinorAxis, int semiMajorAxis)
        {
            CentralPoint = centralPoint;
            SemiMinorAxis = semiMinorAxis;
            SemiMajorAxis = semiMajorAxis;
        }

        public double GetSquare()
        {
            return SemiMinorAxis * SemiMajorAxis * Math.PI;
        }
        public double GetPerimeter()
        {
            double result = SemiMinorAxis * SemiMinorAxis + SemiMajorAxis * SemiMinorAxis;
            result = Math.PI * Math.Sqrt(2 * result);
            return result;
        }
    }
}