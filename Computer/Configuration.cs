using System;

namespace ComputerTL
{
    abstract public class VideoCard : IComputerConfiguration
    {
        public string Model { get; protected set; }
        public int VideoMemorySize { get; protected set; }
        public bool RayTracingTecnology { get; protected set; }
        public void GetConfiguratonInfo()
        {
            Console.WriteLine("Video card info:");
            Console.WriteLine($" Model: {Model}");
            Console.WriteLine($" Video Memory Size, MB: {VideoMemorySize}");
            Console.WriteLine($" Ray tracing support: {RayTracingTecnology}");
        }
    }
    abstract public class OperationMemory : IComputerConfiguration
    {
        public string Model { get; protected set; }

        public int MemorySize { get; protected set; }

        public string MemoryType { get; protected set; }
        public void GetConfiguratonInfo()
        {
            Console.WriteLine("Operation Memory info:");
            Console.WriteLine($" model: {Model}");
            Console.WriteLine($" memory Size, Gb: {MemorySize}");
            Console.WriteLine($" memory Type: {MemoryType}");
        }
    }
}
