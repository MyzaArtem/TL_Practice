namespace ComputerTL
{
    public class AmdRyzen5 : CPU
    {
        public AmdRyzen5()
        {
            model = "Amd Ryzen 5";
            numberOfCores = 6;
            clockFrequencyMHz = 3600;
            SocketType = "SocketAM4";
        }
    }

    public class IntelcoreI5_10400F : CPU
    {
        public IntelcoreI5_10400F()
        {
            model = "Intel Core i5 10400F, BOX";
            numberOfCores = 6;
            clockFrequencyMHz = 2900;
            SocketType = "LGA 1200";
        }
    }

    public class IntelcoreI5_10600KF : CPU
    {
        public IntelcoreI5_10600KF()
        {
            model = "IntelCore i5 10600KF, BOX";
            numberOfCores = 6;
            clockFrequencyMHz = 4100;
            SocketType = "LGA 1200";
        }
    }

}