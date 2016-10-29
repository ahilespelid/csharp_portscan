using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace lkp
{
    class Program
    {
        static void Main(string[] args)
        { string ip;
            int pa, pb;
            Console.Write("Введите ip: ");
            ip=Console.ReadLine();
            Console.Write("Введите начальный порт: ");
            pa =Convert.ToInt32( Console.ReadLine());
            Console.Write("Введите конечный порт: ");
            pb = Convert.ToInt32(Console.ReadLine());
             scan(ip, pa, pb);
            Console.ReadLine();
        }
        static int scan(string ip,int porta,int portb)
        {
            
            TcpClient TcpScan = new TcpClient();
           
            for (int i = porta; i <= portb; i++)
            {

                try
                {

                    TcpScan.Connect(ip, i);

                    Console.WriteLine("Port " + i + " open\r\n");

                }
                catch
                {

                    Console.WriteLine("Port " + i + " CLOSED\r\n");

                }
                


            }
            return portb;
        }
    }
}
