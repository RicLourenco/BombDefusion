using System;
using System.Collections.Generic;
using Bomb.Library;

namespace Bomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wires;
            string[] wiresArray;
            Wire previousWire;
            List<Wire> wiresList;
            bool isValidWireArray = true;
            Methods methods = new Methods();

            do
            {
                if (isValidWireArray)
                {
                    Console.WriteLine("Provide a list of wires to cut with the following colors:");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The list of wires you provided wasn't valid, insert again:");
                }

                Console.WriteLine($"{Colors.white}, {Colors.red}, {Colors.black}, {Colors.green}, {Colors.orange}, {Colors.purple}");

                wires = Console.ReadLine();

                wiresArray = wires.ToLower().Split(',');

                isValidWireArray = methods.IsValidArray(wiresArray);

            } while (!isValidWireArray);

            wiresList = methods.PopulateListOfWires(wiresArray);

            for (int i = 1; i < wiresList.Count; i++)
            {
                previousWire = wiresList[i - 1];

                if (!previousWire.RelatedColors.Contains(wiresList[i].Color))
                {
                    Console.WriteLine("The bomb exploded");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("The bomb was defused");
            Console.ReadKey();
        }
    }
}
