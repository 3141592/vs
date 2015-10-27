using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.enums
{
    public enum Volume
    {
        Low,
        Medium,
        High
    }

    public enum Meat : byte
    {
        Rare = 1,
        Medium,
        WellDone
    }

    [Flags]
    public enum CarOptions
    {
        SunRoof = 0x01,
        Spoiler = 0x02,
        FogLights = 0x04,
        TintedWindows = 0x08
    }

    [Flags]
    public enum CarOptions2
    {
        SunRoof = 1,
        Spoiler = 2,
        FogLights = 3
    }

    class EnumSwitch
    {
        static void Main(string[] args)
        {
            Volume myVolume = Volume.Medium;

            switch (myVolume)
            {
                case Volume.Low:
                    Console.WriteLine("The volume is low.");
                    break;
                case Volume.Medium:
                    Console.WriteLine("The volume is medium.");
                    break;
                case Volume.High:
                    Console.WriteLine("The volume is high.");
                    break;
            }

            Console.WriteLine("Meat.Rare = {0}", Meat.Rare.ToString());
            Console.WriteLine("Meat.Medium = {0}", Meat.Medium);
            Console.WriteLine("Meat.WellDone = {0}", Meat.WellDone);

            EnumTricks enumTricks = new EnumTricks();
            enumTricks.ListEnumByName();
            enumTricks.ListEnumByValue();

            CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;
            Console.WriteLine(options);
            Console.WriteLine((int)options);

            CarOptions2 options2 = CarOptions2.SunRoof | CarOptions2.FogLights;
            Console.WriteLine(options2);
            Console.WriteLine((int)options2);

            Console.ReadKey();
        }
    }

    class EnumTricks
    {
        public void ListEnumByName()
        {
            foreach(string meat in Enum.GetNames(typeof(Meat)))
            {
                Console.WriteLine("Name: {0}, Value: {1}", meat, (byte)Enum.Parse(typeof(Meat), meat));
            }
        }

        public void ListEnumByValue()
        {
            foreach (byte meat in Enum.GetValues(typeof(Meat)))
            {
                Console.WriteLine("Volume Value: {0}\n Member: {1}",
                    meat, Enum.GetName(typeof(Meat), meat));
            }
        }
    }
}
