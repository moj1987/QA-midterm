using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Midterm
{
    public static class TriangleSolver
    {
        private static string triangleType;
        private const string IS_NOT_A_TRIANGLE = "The numbers do not form a triangle.";
        private const string IS_A_TRIANGLE = "The numbers form a triangle.\n";
        private const string IS_EQUILATERAL = "The trianlge is equilateral.";
        private const string IS_ISOSCELES = "The trianlge is isosceles.";
        private const string IS_SCALENE = "The trianlge is scalene.";

        public static string Analyze(int dimensionA, int dimensionB, int dimensionC)
        {
            if (!IsTriangle(dimensionA, dimensionB, dimensionC))
            {
                return IS_NOT_A_TRIANGLE;
            }

            triangleType = AnalyzeTriangleType(dimensionA, dimensionB, dimensionC);

            return IS_A_TRIANGLE + triangleType;
        }

        private static bool IsTriangle(int dimensionA, int dimensionB, int dimensionC)
        {
            int AB = dimensionA + dimensionB;
            int BC = dimensionB + dimensionC;
            int CA = dimensionC + dimensionA;

            if (AB < dimensionC || BC < dimensionA || CA < dimensionB)
            {
                return false;
            }

            return true;
        }

        private static string AnalyzeTriangleType(int dimensionA, int dimensionB, int dimensionC)
        {
            if (dimensionA == dimensionB && dimensionB == dimensionC)
            {
                return IS_EQUILATERAL;
            }

            if (dimensionA == dimensionB || dimensionB == dimensionC)
            {
                return IS_ISOSCELES;
            }

            return IS_SCALENE;
        }
    }
}