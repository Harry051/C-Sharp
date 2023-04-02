using System;

namespace Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape shape1 = new Shape();      <---- Will throw up an error message as can't make objects of an abstrac class
            Console.WriteLine("Hello World!");
            Sphere hi = new Sphere(5);
            hi.GetVolume();
            Console.ReadKey();

            Shape[] shapes = { new Cube(3, 2), new Sphere(7) };

            foreach(Shape shape in shapes)
            {
                shape.GetDims(6, 5);
                Console.WriteLine($"{shape.Name} has a volume of {shape.GetVolume()}");

                Cube iceCube = shape as Cube;
                //As keywords allows us to create a new cube AS A SPECIFIC CLASSTYPE / DATATYPE

                if (iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube\n");
                }
                if (shape is Cube)
                {
                    Console.WriteLine("This shape is a cube\n");
                }
                //is keyword allows us to check IF A VARIABLE IS OF A CETRAIN TYPE


                object cube1 = new Cube(2, 3);
                //Every single class, variable, object inherits from type OBJECT in C#
                //can see if type in: "cube1." will provide a bunch of built in methods for all objects in C#
                Cube myCube = (Cube)cube1;
                //Here can see starts as an object OF a cube. But can be cast into a CUBE object
            }
        }
    }
}
