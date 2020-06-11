using System;
using System.Collections.Generic;

namespace Izpitna_tema_8_Algoritmi_i_str_ot_danni
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; private set; }
        public  List<Tree<T>> Children { get; private set; }
        public Tree(T value)
        {
            this.Value = value;
        }
        public void AddChild(Tree<T> newChild)
        {
            Children.Add(newChild);
        }
        public void SetParent(Tree<T> newParent)
        {
            this.Parent = newParent;
        }
    }
}
