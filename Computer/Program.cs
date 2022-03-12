using ComputerTL;
using System.Collections.Generic;

namespace ComputerTL
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer PC = new Computer( new AsusPrimeH410(), new IntelcoreI5_10400F(), new RadeonRX6700XT(),
                                          new List<OperationMemory>() { new CorsairVengeanceLPX(), new CorsairVengeanceLPX() } );
            PC.GetInformation();
        }
    }
}