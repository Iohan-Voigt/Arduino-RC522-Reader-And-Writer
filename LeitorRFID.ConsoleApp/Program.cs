using System.IO.Ports;

namespace LeitorRFID.ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            SerialPort sPort = new SerialPort();
            foreach (string name in SerialPort.GetPortNames())
            {
                Console.WriteLine(name + "\n");
            }
            Console.ReadLine();

            if (sPort.IsOpen)
            {
                sPort.Close();
            }

            ConnectToPort(sPort);

            if(sPort.IsOpen)
                Console.WriteLine(sPort.ToString() + " Is Open!\n");
            else
                Console.WriteLine(sPort.ToString() + " In Closed!\n");

            sPort.Write("Olá Mundo!");

            Console.ReadLine();

            sPort.Close();
        }

        private static void ConnectToPort(this SerialPort sPort)
        {
            sPort.PortName = "COM4";
            sPort.BaudRate = 9600;

            try
            {
                sPort.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }

    }

}