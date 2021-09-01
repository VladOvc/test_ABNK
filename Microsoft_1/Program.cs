using System;
using System.Collections.Generic;
// Simple business object. A PartId is used to identify the type of part
// but the part name can change.
public class Part : IEquatable<Part>
{
    public string PartIso { get; set; }

    public int ExchangeRates { get; set; }

    public override string ToString()
    {
        return "ID: " + ExchangeRates + "   Name: " + PartIso;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public override int GetHashCode()
    {
        return ExchangeRates;
    }
    public bool Equals(Part other)
    {
        if (other == null) return false;
        return (this.ExchangeRates.Equals(other.ExchangeRates));
    }
    // Should also override == and != operators.
}
public class Example
{

    public static void Main()
    {
        // Create a list of parts.
        List<Part> parts = new List<Part>();

        // Add parts to the list.
        parts.Add(new Part() { PartIso = "RUB", ExchangeRates = 27 });
        parts.Add(new Part() { PartIso = "USA", ExchangeRates = 30 });
        parts.Add(new Part() { PartIso = "EUR", ExchangeRates = 1 });



        //Console.WriteLine();
        for (int i = 0; i < parts.Count; i++)
        {
            Console.WriteLine(parts[i]);
        }


    }
}