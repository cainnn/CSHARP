using System;

namespace MobileDevicePractice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MobileDisk md = new MobileDisk();
            MP3 mp3 = new MP3();
            Udisk udisk = new Udisk();
            Computer cpu = new Computer();
            // cpu.MS = mp3; //将MP3插到电脑上
            cpu.MS = udisk; //将MP3插到电脑上
            cpu.CpuRead();
            cpu.CpuWrite();
            mp3.PlayMusic();
        }
    }

    abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据"); 
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据"); 
        }
    }

    class Udisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }

    class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }

        public void PlayMusic()
        {
            Console.WriteLine("MP3可以自己播放音乐");
        }
    }

    class Computer
    {
        public MobileStorage MS
        {
            get;
            set;
        }
        public void CpuRead()
        {
           this.MS.Read();
        }

        public void CpuWrite()
        {
           this.MS.Write();
        }
    }
}