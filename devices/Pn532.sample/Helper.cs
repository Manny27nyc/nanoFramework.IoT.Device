﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    public static class Helper
    {
        /// <summary>
        /// Compare the elements of 2 different byte arrays
        /// </summary>
        /// <param name="first">First array to compare</param>
        /// <param name="second">Second array to compare</param>
        /// <returns>True if all elements are equa</returns>
        public static bool SequenceEqual(this SpanByte first, SpanByte second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
