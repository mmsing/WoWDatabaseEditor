using WowPacketParser.Proto;
using WowPacketParser.Proto.Processing;

namespace WDE.PacketViewer.Processing.Runners
{
    public abstract class CompoundProcessor<T, R1> : PacketProcessor<T>, ITwoStepPacketProcessor<bool> where R1 : IPacketProcessor<T>
    {
        private readonly R1 r1;

        protected CompoundProcessor(R1 r1)
        {
            this.r1 = r1;
        }

        public bool PreProcess(PacketHolder packet)
        {
            r1.Process(packet);
            return true;
        }
    }
    
    public abstract class CompoundProcessor<T, R1, R2> : PacketProcessor<T>, ITwoStepPacketProcessor<bool> where R1 : IPacketProcessor<T> where R2 : IPacketProcessor<T>
    {
        private readonly R1 r1;
        private readonly R2 r2;

        protected CompoundProcessor(R1 r1, R2 r2)
        {
            this.r1 = r1;
            this.r2 = r2;
        }

        public bool PreProcess(PacketHolder packet)
        {
            r1.Process(packet);
            r2.Process(packet);
            return true;
        }
    }
    public abstract class CompoundProcessor<T, R1, R2, R3> : PacketProcessor<T>, ITwoStepPacketProcessor<bool> where R1 : IPacketProcessor<T> 
        where R2 : IPacketProcessor<T>
        where R3 : IPacketProcessor<T>
    {
        private readonly R1 r1;
        private readonly R2 r2;
        private readonly R3 r3;

        protected CompoundProcessor(R1 r1, R2 r2, R3 r3)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
        }

        public bool PreProcess(PacketHolder packet)
        {
            r1.Process(packet);
            r2.Process(packet);
            r3.Process(packet);
            return true;
        }
    }
}