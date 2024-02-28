using Exercise02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {           
            Post p1 = new Post(
               DateTime.Parse("21/06/2018 13:05:44"),
               "Viajando para Nova Zelandia",
               "Eu vou visitar uma cidade maravilhosa",
               12
                );
            Comment c1 = new Comment("Tenha um bom dia");
            p1.AddComment(c1);
            Comment c2 = new Comment("Uau que incrível");
            p1.AddComment(c2);

            Console.WriteLine(p1);
            
        }
    }
}
