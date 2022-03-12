namespace ComputerTL
{
    public class NvidiaGeForceRTX3060 : VideoCard
    {
        public NvidiaGeForceRTX3060()
        {
            Model = "NVIDIA_GeForce_RTX_3060";
            VideoMemorySize = 12000;
            RayTracingTecnology = true;
        }
    }

    public class RadeonRX6700XT : VideoCard
    {
        public RadeonRX6700XT()
        {
            Model = "Radeon RX 6700XT";
            VideoMemorySize = 12222;
            RayTracingTecnology = false;
        }
    }
}