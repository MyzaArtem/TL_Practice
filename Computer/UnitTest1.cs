using System;
using System.Collections.Generic;
using ComputerTL;
using NUnit.Framework;


namespace ComputerTests
{
    public class MotherboardTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckProcessorCompatibility()
        {
            // Arrange
            List<Motherboard> boardsList = new List<Motherboard>() {
                new AsusPrime320(),
                new AsusPrimeH410(),
                new GigabyteB550() };

            List<CPU> cpuList = new List<CPU>() {
                new IntelcoreI5_10400F(),
                new AmdRyzen5(), 
                new IntelcoreI5_10600KF()};

            // Act & Assert
            foreach (var board in boardsList)
            {
                foreach (var cpu in cpuList)
                {
                    if (board.ProcessorSocket == cpu.SocketType)
                        Assert.IsTrue(board.CheckProcessorCompatibility(cpu));
                    else
                        Assert.IsFalse(board.CheckProcessorCompatibility(cpu));
                }
            }
        }

        [Test]
        public void CheckRamUnitCount_PosTest()
        {
            // Arrange
            List<Motherboard> boardsList = new List<Motherboard>() {
                new AsusPrime320(),
                new AsusPrimeH410(),
                new GigabyteB550() };

            // Act & Assert
            foreach (var board in boardsList)
            {
                for (ushort i = 1; i <= board.ramDieCount; i++)
                {
                    Assert.IsTrue(board.CheckRamUnitCount(i));
                }

            }
        }

        [Test]
        public void CheckRamUnitCount_NegTest()
        {
            // Arrange
            List<Motherboard> boardsList = new List<Motherboard>() {
                new AsusPrime320(),
                new AsusPrimeH410(),
                new GigabyteB550() };

            // Act & Assert
            foreach (var board in boardsList)
            {
                Assert.IsFalse(board.CheckRamUnitCount(0));
                Assert.IsFalse(board.CheckRamUnitCount((ushort)(board.ramDieCount + 1)));
            }
        }
    }

    public class ComputerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Computer_Constructor_CorrectValues()
        {
            Computer comp2 = new Computer(
                new AsusPrimeH410(),
                new IntelcoreI5_10400F(),
                new NvidiaGeForceRTX3060(),
                new List<OperationMemory>() { new CorsairVengeanceLPX(), new CorsairVengeanceLPX() }
                );

            comp2.GetInformation();
        }

        [Test]
        public void NullMotherboard_ThrowsException()
        {
            //Arrange & Act 
            static void act() => new Computer(
                null,
                new IntelcoreI5_10400F(),
                new RadeonRX6700XT(),
                new List<OperationMemory>() { new CorsairVengeanceLPX(), new CorsairVengeanceLPX() }
                );

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Test]
        public void NullCpu_ThrowsException()
        {
            //Arrange & Act 
            static void act() => new Computer(
                new AsusPrimeH410(),
                null,
                new NvidiaGeForceRTX3060(),
                new List<OperationMemory>() { new CorsairVengeanceLPX(), new CorsairVengeanceLPX() }
                );

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Test]
        public void NullVideoCard_ThrowsException()
        {
            //Arrange & Act 
            static void act() => new Computer(
                new AsusPrime320(),
                new IntelcoreI5_10400F(),
                null,
                new List<OperationMemory>() { new AmdRadeonR7(), new AmdRadeonR7() }
                );

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Test]
        public void NullRam_ThrowsException()
        {
            //Arrange & Act 
            static void act() => new Computer(
                new GigabyteB550(),
                new AmdRyzen5(),
                new NvidiaGeForceRTX3060(),
                null
                );

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Test]
        public void EmptyRamList_ThrowsException()
        {
            //Arrange & Act 
            static void act() => new Computer(
                new AsusPrimeH410(),
                new IntelcoreI5_10400F(),
                new RadeonRX6700XT(),
                new List<OperationMemory>()
                );

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Test]
        public void NotCompatibleCpu_ThrowsException()
        {
            //Arrange & Act 
            static void act() => new Computer(
                new AsusPrime320(),
                new IntelcoreI5_10400F(),
                new NvidiaGeForceRTX3060(),
                new List<OperationMemory>() { new AmdRadeonR7(), new AmdRadeonR7() }
                );

            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Test]
        public void IncorrectMemoryUnits_ThrowsException()
        {
            // Arrange
            var ramList = new List<OperationMemory>();
            for (int i = 0; i < 10; i++)
                ramList.Add(new AmdRadeonR7());

            // Act 
            void act() => new Computer(
                new AsusPrimeH410(),
                new IntelcoreI5_10600KF(),
                new RadeonRX6700XT(),
                ramList
                );

            // Assert
            Assert.Throws<ArgumentException>(act);
        }
    }
}