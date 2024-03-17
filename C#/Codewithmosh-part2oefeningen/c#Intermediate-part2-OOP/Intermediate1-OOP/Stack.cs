using System;
using System.Collections;
using System.Collections.Generic;

namespace Intermediate1_OOP
{

    public class Stack
    {
        private readonly List<object> _amountOfObject = new List<object>();

        public void push(object obj)
        {
            if (obj == null) { throw new InvalidOperationException("Code is null"); }
            _amountOfObject.Add(obj);
        }

        public object pop()
        {
            var index = _amountOfObject.Count - 1;
            var toReturn = _amountOfObject[index];
            _amountOfObject.RemoveAt(index);
            return toReturn;
        }

        public void Clear()
        {
            _amountOfObject.Clear();
        }
    }
}
