using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strucutures_and_algorithms.Stacks
{
    public partial class Stacks
    {
        //https://leetcode.com/problems/online-stock-span/
        public class StockSpanner
        {
            private readonly Stack<(int index, int price)> _stack;
            private int _index;

            public StockSpanner()
            {
                _stack = new();
                _index = -1;
            }

            public int Next(int price)
            {
                _index++;

                while (_stack.Count > 0 && _stack.Peek().price <= price)
                {
                    _stack.Pop();
                }

                int span = _stack.Count == 0 ? _index + 1 : _index - _stack.Peek().index;

                _stack.Push((_index, price));

                return span;
            }
        }
    }
}
