using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DesignPatterns.Structural
{
    // Component interface its the
    public interface IShape
    {
        void Draw();
        
    }

    // Leaf class representing a simple shape
    // it defines its own behavior 
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
  
    }

    // Another leaf class representing a different shape
    // it defines its own behavior 
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

    // Composite class representing a composite shape
    // this is the entity which the program interacts with
    // it manages the behavior of each leaf class
    public class CompositeShape : IShape
    {
        public List<IShape> components = new List<IShape>();

        public void Draw()
        {
            //Here you decide what do you want to do with the leaf classes
            foreach (IShape component in components)
            {
                component.Draw();
            }
        }
    }
}
