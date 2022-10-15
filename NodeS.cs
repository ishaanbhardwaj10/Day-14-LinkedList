using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class NodeS<T> : IComparable where T : IComparable
    {

        public T data;
        public NodeS<T> next;

        public NodeS(T data)
        {
            this.data = data;
        }

        public int CompareTo(Object obj)
        {
            NodeS<T> incomingNode = (NodeS<T>)obj;
            return this.data.CompareTo(incomingNode.data);
        }


    }
}
