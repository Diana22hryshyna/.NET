using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziyana_Hryshyna_Zadanie1_.Model
{
    class Model
    {
        public enum AreaType
        {
            Rectangle,
            Trapezoid
        }
        public class SingleCount
        {
            public double X1 { get; set; }
            public double X2 { get; set; }
            public AreaType AreaType { get; set; }
            Func<double, double> function;
            public double Area { get; set; }
            public int CalculationNumber { get; set; }
            public int LowestN { get; set; }
            public double HighestN { get; set; }
            public double Error { get; set; }
            public double MinSquareError { get; set; }

            public int K { get; set; }

            public SingleCount()
            { }

            public SingleCount(double x1, double x2, int calculationNumber,
                int lowestN, double highestN, Func<double, double> function, double area, AreaType areaType, double error)
            {
                X1 = x1;
                X2 = x2;
                CalculationNumber = calculationNumber;
                LowestN = lowestN;
                HighestN = highestN;
                this.function = function;
                Area = area;
                AreaType = areaType;
                Error = error;
            }

            public SingleCount(double x1, double x2,
                int lowestN, double highestN, Func<double, double> function, double area, AreaType areaType, double error)
            {
                X1 = x1;
                X2 = x2;
                LowestN = lowestN;
                HighestN = highestN;
                this.function = function;
                Area = area;
                AreaType = areaType;
                Error = error;
            }

            public SingleCount(double x1, double x2, int k,
                int lowestN, double highestN, Func<double, double> function, double area, AreaType areaType)
            {
                X1 = x1;
                X2 = x2;
                LowestN = lowestN;
                HighestN = highestN;
                this.function = function;
                Area = area;
                AreaType = areaType;
                K = k;
            }

            public SingleCount(
                int lowestN, double highestN, Func<double, double> function, double area, AreaType areaType, double error)
            {
                LowestN = lowestN;
                HighestN = highestN;
                this.function = function;
                Area = area;
                AreaType = areaType;
                Error = error;
            }

            public SingleCount(double x1, double x2, Func<double, double> function, AreaType areaType, double error)
            {
                X1 = x1;
                X2 = x2;
                AreaType = areaType;
                this.function = function;
                Error = error;
            }

            public SingleCount(double area, double x1, double x2, Func<double, double> function, AreaType areaType)
            {
                X1 = x1;
                X2 = x2;
                AreaType = areaType;
                Area = area;
                this.function = function;
            }

            public SingleCount(int x1, int x2, Func<double, double> function, int k, AreaType areaType)
            {
                X1 = x1;
                X2 = x2;
                K = k;
                AreaType = areaType;
                this.function = function;
            }

            public SingleCount(Func<double, double> function, double area, AreaType areaType, double error, int x1, int x2)
            {
                X1 = x1;
                X2 = x2;
                this.function = function;
                Area = area;
                AreaType = areaType;
                Error = error;
            }

            public List<double> Zad1()
            {

                List<double> result = new List<double>();
                var random = new Random();
                for (int i = 0; i < CalculationNumber; ++i)
                {
                    int n = random.Next(LowestN, 100000);
                    double currentArea = CalculateArea(function, n);
                    if ((Math.Abs(Area - currentArea)) * 100 / Area <= Error && (Math.Abs(Area - currentArea)) * 100 / Area >= -Error)
                    {
                        result.Add(currentArea);
                    }
                }
                return result;
            }

            public double Zad2()
            {
                double deviation = 100000000000000;
                double currentArea = 0;
                int n = 0;
                while (deviation >= Math.Abs(Error))
                {
                    currentArea = CalculateArea(function, n);
                    deviation = Math.Abs(Area - currentArea) / Area *100;
                    n++;
                }
                return n;
            }

            public double Zad3()
            {
                int begin = 5, end = 6;
                double msqe = 0;
                for (int i = begin; i <= end; ++i)
                {
                    int n = (int)Math.Pow(10, i);
                    double currentArea = CalculateArea(function, n);
                    msqe += Math.Pow(Area - currentArea, 2);
                }

                msqe /= 2;
                return msqe;
            }

            public double Zad6()
            {
                int n = 0;
                n = (int)Math.Pow(10, K);
                double currentArea = CalculateArea(function, n);
                return currentArea;
            }

            public double Zad7()
            {
                int n = 1;
                do
                {
                    double currentArea = CalculateArea(function, n);
                    if (Math.Truncate(currentArea) % Error == 0)
                    {
                        return n;
                    }
                    ++n;
                }
                while (true);
            }


            public double CalculateArea(Func<double, double> function, int n)
            {

                if (AreaType == AreaType.Rectangle)
                    return CalculateRectangleArea(function, n);
                else
                    return CalculateTrapezoidArea(function, n);
            }

            private double CalculateTrapezoidArea(Func<double, double> function, int n)
            {
                double h;

                h = (X2 - X1) / (double)n;

                double area = 0;
                for (int i = 1; i < n; i++)
                {
                    area += function(X1 + i * h);
                }
                area += function(X1) / 2;
                area += function(X2) / 2;
                area *= h;
                return area;
            }

            private double CalculateRectangleArea(Func<double, double> function, int n)
            {
                double h = (X2 - X1) / (double)n;

                double area = 0;
                for (int i = 1; i <= n; i++)
                {
                    area += function(X1 + i * h) * h;
                }
                return area;
            }
        }

        class Global
        {
            public List<SingleCount> ListOfSingleCount { get; set; }

            public Global()
            {}

            public Global(List<SingleCount> listOfSingleCount)
            {
                ListOfSingleCount = listOfSingleCount;
            }
        }

    }
}










