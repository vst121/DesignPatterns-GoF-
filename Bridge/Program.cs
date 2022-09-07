using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl1 = new RemoteControl(new SonyTV());
            remoteControl1.TurnOn();

            var remoteControl2 = new AdvancedRemoteControl(new SonyTV());
            remoteControl2.TurnOn();

            var remoteControl3 = new RemoteControl(new SamsungTV());
            remoteControl3.TurnOn();

            var remoteControl4 = new AdvancedRemoteControl(new SamsungTV());
            remoteControl4.SetChannel(4);

            Console.ReadLine();
        }
    }
}
