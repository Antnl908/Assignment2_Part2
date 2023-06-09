using System.Threading;
using System.Threading.Tasks;
namespace Assignment2_Part2
{
    class Assignment2P2
    {
        // See https://aka.ms/new-console-template for more information

        static void Main(string[] args)
        {
            bool isRunning = true;

            int numOfClients = 20;
            int numOfSeats = 35;
            SeatManager seatManager = new SeatManager(numOfSeats);
            Thread[] threads = new Thread[numOfClients];

            Console.WriteLine("Hello, World!");

            for (int i = 0; i < threads.Length; i++)
            {
                var c = new Client(seatManager, i);
                threads[i] = new Thread(new ThreadStart(c.Run));
                threads[i].IsBackground = true;
                threads[i].Start();
            }

            while(isRunning)
            {

            }
        }
    }
    
}

