using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay15
{
    public class UC1<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public UC1<T> leftTree { get; set; }

        public UC1<T> rightTree { get; set; }

        public UC1(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;

        public void Insert(T item)
        {
            T CurrNodeVal = this.nodeData;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new UC1<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new UC1<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);
                }
            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

    }
}