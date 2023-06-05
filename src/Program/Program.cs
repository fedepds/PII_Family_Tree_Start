using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Node n1 = new Node(new Persona("Javier",12));
            Node n2 = new Node(new Persona("Federico",21));
            Node n3 = new Node(new Persona("Pancho", 31));
            Node n4 = new Node(new Persona("Cristian", 90));
            Node n5 = new Node(new Persona("Alfo",45));
            Node n6 = new Node(new Persona("Kira",34));
            Node n7 = new Node(new Persona("Santi",3));
            Node n8 = new Node(new Persona("Joaco", 15));


            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n2.AddChildren(n8);

        }
    }
}
