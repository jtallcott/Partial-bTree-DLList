using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InterviewTest
{
    public class BTree
    {
        private int? _value = null;
        private BTree _left = null;
        private BTree _right = null;

        //Public ReadOnly Properties used in UnitTests
        public int?     Value   { get { return _value; } }
        public BTree    Left    { get { return _left; } }
        public BTree    Right   { get { return _right; } }

        public void Insert(int newValue) 
        {
            if (_value == null)
            {
                _value = newValue;
                _left = new BTree();     //left and right nodes created when value becomes NOT null. 
                _right = new BTree();    //no other null reference checks required in Insert(int)
                return;
            }

            if (newValue < _value)
                _left.Insert(newValue);
            else
                _right.Insert(newValue);
        }
    }
}
