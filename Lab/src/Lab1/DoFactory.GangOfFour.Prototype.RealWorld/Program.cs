// Prototype pattern -- Real World example

using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Prototype.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Prototype Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            ColorManager colorManager = new ColorManager();

            // Initialize with standard colors
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colorManager["angry"] = new Color(255, 54, 0);
            colorManager["peace"] = new Color(128, 211, 128);
            colorManager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color? color1 = colorManager["red"].Clone() as Color;
            Color? color2 = colorManager["peace"].Clone() as Color;
            Color? color3 = colorManager["flame"].Clone() as Color;

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", _red, _green, _blue);
            return (ColorPrototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// Prototype manager
    /// </summary>
    class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();
        
        // Indexer
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}