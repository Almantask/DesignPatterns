using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Core
{
    public static class NumbersComparer
    {
        private const float Tolerance = 0.0001f;

        public static bool AreEqual(float num1, float num2)
        {
            var diff = Math.Abs(num1 - num2);
            return diff < Tolerance;
        }
    }
}
