using System;
using System.Collections.Generic;

namespace ComputerTL
{
    public class Computer
    {
        public Computer(Motherboard motherBoard, CPU cpu, VideoCard videoCard, List<OperationMemory> ramDie)
        {
            if (motherBoard is null)
                throw new ArgumentNullException("the computer cannot work without the motherboard");
            if (cpu is null)
                throw new ArgumentNullException("the computer cannot work without a processor");
            if (videoCard is null)
                throw new ArgumentNullException("The videocard is not inserted");
            if (ramDie is null)
                throw new ArgumentNullException("there is no RAM");
            if (ramDie.Count == 0)
                throw new ArgumentNullException("there is no RAM");

            if (motherBoard.CheckProcessorCompatibility(cpu) == false)
                throw new ArgumentNullException("processor is not compatible with motherboard");

            if (motherBoard.CheckRamUnitCount(ramDie.Count) == false)
                throw new ArgumentException("not enough ram slots");

            Motherboard = motherBoard;
            Cpu = cpu;
            VideoCard = videoCard;
            RamDie = ramDie;

            _PCcomponents = new List<IComputerConfiguration>
                {
                    motherBoard,
                    cpu,
                    videoCard,
                };
            _PCcomponents.AddRange(ramDie);
        }

        public Motherboard Motherboard { get; }

        public CPU Cpu { get; }

        public VideoCard VideoCard { get; }

        public List<OperationMemory> RamDie { get; }
   
        private List<IComputerConfiguration> _PCcomponents;

        public void GetInformation()
        {
            foreach (var computerConfiguration in _PCcomponents)
            {
                computerConfiguration.GetConfiguratonInfo();
            }

        }
    }
}