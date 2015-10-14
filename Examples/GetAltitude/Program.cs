using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LibZano;

namespace GetAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            uint zano;
            Library.Initialise("Example-GetAltitude.1.0.0");
            zano = Library.Obtain("192.168.0.1", 10001);

            bool isConnected = false;
            Frame frame = new Frame();

            Library.Connect(zano);

            while (true)
            {
                if (isConnected)
                {
                    Frames.FlightAltitudeGet(zano);
                }

                Library.Tick();

                while (Library.Receive(ref frame) == 1)
                {
                    switch (frame.Reference)
                    {
                        case Symbols.kFlightAltitudeGet:
                        {
                            int altitude = frame.Get(Symbols.kAltitude);
                            Console.WriteLine(String.Format("Altitude is {0} mm", altitude));
                        }
                        break;
                    }
                }

                Library.Status status;

                while ((status = Library.GetStatus()) != Library.Status.None)
                {
                    switch (status)
                    {
                        case Library.Status.DeviceDisconnectionDisconnected:
                        case Library.Status.DeviceConnectionNotConnected:
                        case Library.Status.DeviceConnectionHeldStill:
                        {
                            isConnected = false;
                            Library.Connect(zano);
                        }
                        break;
                        case Library.Status.DeviceConnectionConnected:
                        {
                            isConnected = true;
                        }
                        break;
                    }
                }

                Thread.Sleep(10);
            }

        }
    }
}
