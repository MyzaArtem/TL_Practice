using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerTL
{
    interface IComputerConfiguration
    {
        public void GetConfiguratonInfo();
    }
    abstract public class Motherboard : IComputerConfiguration
    {
        public string Model { get; protected set; }
        public int MemorySlots { get; protected set; }
        public string ProcessorSocket { get; protected set; }
        public bool CheckProcessorCompatibility(CPU cpu)
        {
            if (cpu.SocketType == ProcessorSocket)
                return true;

            return false;
        }

        public bool CheckRamUnitCount(int ramDieCount)
        {
            if (ramDieCount == 0 || ramDieCount > MemorySlots)
                return false;

            return true;
        }

        public void GetConfiguratonInfo()
        {
            Console.WriteLine("Motherboard info:");
            Console.WriteLine($" Model: {Model}");
            Console.WriteLine($" Memory slots count: {MemorySlots}");
            Console.WriteLine($" Processor socket type: {ProcessorSocket}");
        }
    }
    abstract public class CPU : IComputerConfiguration
    {
        public string model { get; protected set; }
        public int numberOfCores { get; protected set; }
        public int clockFrequencyMHz { get; protected set; }
        public string SocketType { get; protected set; }
        public void GetConfiguratonInfo()
        {
            Console.WriteLine("CPU info:");
            Console.WriteLine($" Model: {model}");
            Console.WriteLine($" Number of cores: {numberOfCores}");
            Console.WriteLine($" Clock frequency, MHz: {clockFrequencyMHz}");
            Console.WriteLine($" Socket type: {SocketType}");
        }
    }
}
