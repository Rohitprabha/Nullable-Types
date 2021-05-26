using System;

namespace Nullable_Types_1
{
    class Null_Coalescing_Operator
    {
        static void Main(string[] args)
        {
            int AvailableTickets;
            int? TicketsOnSale = null;

            AvailableTickets = TicketsOnSale ?? 0;              // with Null coalescing operator ??


            //if (TicketsOnSale == null)              //without using Null coalescing operator
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = (int)TicketsOnSale;
            //}
            Console.WriteLine("Available Tickets = {0}", AvailableTickets);
        }
    }
}
