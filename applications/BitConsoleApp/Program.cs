using System.Runtime.InteropServices;
using bits;

var bits = new List<String>()
{
    "00000000",
    "00000001",
    "00000010",
    "00001111",
    "01111111",
    "10000000",
    "10000001",
    "10000010",
    "10000011",
    "10000101",
    "11111111"
};

var conversion = new Conversion();

System.Console.WriteLine("Unsigned");
foreach (var bit in bits)
{
    System.Console.WriteLine($"{bit,-10} {conversion.ToNumber(bit),-5} {conversion.ToNumber(bit) == Convert.ToByte(bit, 2),-5} ");
}


System.Console.WriteLine("Signed");
foreach (var bit in bits)
{
    System.Console.WriteLine($"{bit,-10} {conversion.ToUNumber(bit),-5} {conversion.ToUNumber(bit) == Convert.ToSByte(bit, 2),-5} ");
}