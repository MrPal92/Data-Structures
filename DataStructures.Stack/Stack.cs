using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment.Exception;

namespace DataStructures.Stack
{
    public class Stack
    {
        int?[] stack;

        private int Top { get; set; }

        private int elementCount;

        public int Length { get; }

        public Stack()
        {
            stack = new int?[Length = 10];
            elementCount = 0;
        }

        public Stack( int size)
        {
            stack = new int?[Length = size];
            elementCount = 0;
        }

        public void Push( int element)
        {
            if ( elementCount == 0 )
            {
                Top = 0;
                stack[Top] = element;
                elementCount++;
            }
            else if( elementCount == Length - 1)
            {
                throw new Custom_StackOverflowException();
            }
            else
            {
                stack[++Top] = element;
                elementCount++;
            }
        }

        public int Pop()
        {
            int temp;
            if ( elementCount == 0 )
            {
                throw new Custom_StackUnderflowException();
            }
            else
            {
                temp = (int)stack[Top];
                stack[Top--] = null;
                elementCount--;

                return temp;
            }
        }
    }
}
