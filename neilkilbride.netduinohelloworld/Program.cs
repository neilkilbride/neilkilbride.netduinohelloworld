using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace neilkilbride.netduinohelloworld
{
    public class Program
    {
        public static void Main()
        {
            var led = new OutputPort(Pins.ONBOARD_LED, false);

            while (true)
            {
                led.Write(!led.Read());

                Thread.Sleep(1000);
            }
        }

    }
}
