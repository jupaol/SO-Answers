using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GlobalTests.Model;

namespace GlobalTests.Topics.LinkedLists
{
    [TestClass]
    public class TestingCycledLinkedLists
    {
        [TestMethod]
        public void CanCreateACycledLists()
        {
            var list = new List<LinkedListCustomItem>();
            var current = (LinkedListCustomItem)null;

            for (int i = 0; i < 100; i++)
            {
                var item = new LinkedListCustomItem { Number = i };

                if (current != null)
                {
                    current.Next = item;
                }

                current = item;
                list.Add(item);
            }

            //list[4].Next = list[2];
            var cItem = list[0];
            var count = 0;
            var by4 = 4;
            var by2 = 2;
            LinkedListCustomItem by4Item = null;
            LinkedListCustomItem by2Item = null;

            do
            {
                // do something
                try
                {
                    by4Item = list[by4];
                    by4 += 4;
                }
                catch
                {
                    by4Item = null;
                    by4 -= 4;
                }

                try
                {
                    by2Item = list[by2];
                    by2 += 2;
                }
                catch
                {
                    by2Item = null;
                    by2 -= 2;
                }

                cItem = cItem.Next;
                count++;
            } while (cItem.Next != null && !this.EvaluateCondition(by4Item, by2Item));

            Console.WriteLine(count);
        }

        private bool EvaluateCondition(LinkedListCustomItem by4, LinkedListCustomItem by2)
        {
            var res = false;

            res = ReferenceEquals(by4, by2);

            if (res)
            {
                if (by4 != null)
                {
                    Console.WriteLine(by4.Number);
                }
                if (by2 != null)
                {
                    Console.WriteLine(by2.Number);
                }
            }

            return res;
        }
    }
}
