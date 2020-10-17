using System;
using System.Threading;
namespace PR08_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex oneMutex = null;
            const String MutexName = "RUNMEONCE";
            try 
            {
                oneMutex = Mutex.OpenExisting(MutexName);
            }
            catch (WaitHandleCannotBeOpenedException)
            {
            }
            if(oneMutex == null)
            {
                oneMutex = new Mutex(true, MutexName);
            }
            else
            {

                oneMutex.Close();
                return;
            }
            Console.WriteLine("Our Application");
            Console.Read();
        }
    }
}
