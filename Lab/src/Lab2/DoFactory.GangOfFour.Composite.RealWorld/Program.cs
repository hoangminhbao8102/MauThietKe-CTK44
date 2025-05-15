// Composite pattern -- Real World example

using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Composite.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Composite Design Pattern.
    /// </summary>
    class MainApp
    {
        /// /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create a tree structure
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new Primitive("Red Line"));
            root.Add(new Primitive("Blue Circle"));
            root.Add(new Primitive("Green Box"));

            // Create a branch
            CompositeElement comp = new CompositeElement("Two Circle");
            comp.Add(new Primitive("Black Circle"));
            comp.Add(new Primitive("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            Primitive pe = new Primitive("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    abstract class DrawingElement
    {
        protected string _name;

        // Constructor
        public DrawingElement(string name)
        {
            this._name = name;
        }

        public abstract void Add(DrawingElement c);
        public abstract void Remove(DrawingElement c);
        public abstract void Display(int indent);
    }

    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class Primitive : DrawingElement
    {
        // Constructor
        public Primitive(string name) : base(name)
        {
        }

        public override void Add(DrawingElement component)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(DrawingElement component)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _name);
        }
    }

    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();

        // Constructor
        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + _name);

            // Display each child element on this node
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}