using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using NUnit.Framework;

namespace AoC2017
{
    public class CaptchaSum
    {
        public int Sum { get; set; }

        public int AddNumbers(List<int> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == GetNextNumberPart2(i, list))
                {
                    Sum += list[i];
                }
            }

            return Sum;
        }

        private int GetNextNumberPart1(int index, List<int>list)
        {
            if (index == list.Count - 1)
            {
                return list[0];
            }

            return list[index + 1];
        }

        private int GetNextNumberPart2(int index, List<int>list)
        {
            return list[(index + list.Count / 2)% list.Count] ;
        }
    }
}
