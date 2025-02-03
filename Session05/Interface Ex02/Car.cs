using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05.Interface_Ex02
{
    internal class Car : Vehicle, IMoveOnGround
    {
        void IMoveOnGround.Backward()
        {
            Console.WriteLine("Car Move Backward");
        }

        void IMoveOnGround.Forward()
        {
            Console.WriteLine("Car Move Forward");
        }

        void IMoveOnGround.Left()
        {
            Console.WriteLine("Car Move Left");
        }

        void IMoveOnGround.Right()
        {
            Console.WriteLine("Car Move Left");
        }
    }
}
