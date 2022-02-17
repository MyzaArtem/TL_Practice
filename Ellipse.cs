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

        public Ellipse(Point centralPoint, int semiMinorAxis, int semiMajorAxis)
        {
            if (SemiMajorAxis < SemiMinorAxis)
            {
                throw new ArgumentException(" The Major semi-axis must be greater than the Minor semi-axis ");
            }

            if (semiMinorAxis <= 0)
            {
                throw new ArgumentException(" The Minor semi-axis cannot be less than 0 ");
            }

            if (semiMajorAxis <= 0)
            {
                throw new ArgumentException(" The Major semi-axis cannot be less than 0 ");
            }

            CentralPoint = centralPoint;
            SemiMinorAxis = semiMinorAxis;
            SemiMajorAxis = semiMajorAxis;
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

            SemiMajorAxis = (rightBottomPoint.X -  leftTopPoint.X) / 2;
            SemiMinorAxis = (leftTopPoint.Y - rightBottomPoint.Y) / 2;

            CentralPoint.X = leftTopPoint.X + SemiMajorAxis;
            CentralPoint.Y = rightBottomPoint.Y + SemiMinorAxis;
        }


        public double GetSquare()
        {
            return SemiMinorAxis * SemiMajorAxis * Math.PI;
        }

        public double GetPerimeter()
        {
            double result = 2 * Math.PI * Math.Sqrt(Math.Pow(SemiMajorAxis, 2) + Math.Pow(SemiMinorAxis, 2) / 2);
            return result;
        }
    }
}