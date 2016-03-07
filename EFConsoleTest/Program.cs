using AutoLotDAL.Repos;
using static System.Console;

namespace EFConsoleTest
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            PrintAllInventory();

            return 0;
        }


        private static void PrintAllInventory()
        {
            using (var repo = new InventoryRepo())
            {
                foreach (var c in repo.GetAll())
                {
                    WriteLine(c);
                }
            }
        }
    }
}