namespace ComputerTL

{
    public class AsusPrime320 : Motherboard
    {
        public AsusPrime320()
        {
            Model = "ASUS PRIME 320";
            MemorySlots = 2;
            ProcessorSocket = "SocketAM4";
        }
    }
    public class AsusPrimeH410 : Motherboard
    {
        public AsusPrimeH410()
        {
            Model = "ASUS PRIME H410";
            MemorySlots = 2;
            ProcessorSocket = "LGA 1200";
        }
    }
    public class GigabyteB550 : Motherboard
    {
        public GigabyteB550()
        {
            Model = "Gigabyte B550";
            MemorySlots = 4;
            ProcessorSocket = "SocketAM4";
        }
    }
}