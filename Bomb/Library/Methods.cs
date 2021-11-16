namespace Bomb.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public enum Colors
    {
        white,
        black,
        red,
        green,
        orange,
        purple
    }


    public class Methods
    {
        public bool IsValidArray(string[] wiresInput)
        {
            return wiresInput.All(w => Enum.IsDefined(typeof(Colors), w.Trim()));
        }


        public List<Wire> PopulateListOfWires(string[] wiresInput)
        {
            List<Wire> wires = new List<Wire>();

            foreach(var wire in wiresInput)
            {
                switch (wire.Trim())
                {
                    case "white":
                        wires.Add(new Wire
                        {
                            Color = Colors.white,
                            RelatedColors = new List<Colors> { Colors.red, Colors.green, Colors.orange, Colors.purple }
                        });
                        break;
                    case "black":
                        wires.Add(new Wire
                        {
                            Color = Colors.black,
                            RelatedColors = new List<Colors> { Colors.black, Colors.orange, Colors.purple }
                        });
                        break;
                    case "red":
                        wires.Add(new Wire
                        {
                            Color = Colors.red,
                            RelatedColors = new List<Colors> { Colors.green }
                        });
                        break;
                    case "green":
                        wires.Add(new Wire
                        {
                            Color = Colors.green,
                            RelatedColors = new List<Colors> { Colors.orange, Colors.white }
                        });
                        break;
                    case "orange":
                        wires.Add(new Wire
                        {
                            Color = Colors.orange,
                            RelatedColors = new List<Colors> { Colors.red, Colors.black }
                        });
                        break;
                    case "purple":
                        wires.Add(new Wire
                        {
                            Color = Colors.purple,
                            RelatedColors = new List<Colors> { Colors.black, Colors.red }
                        });
                        break;
                }
            }

            return wires;
        }
    }
}
