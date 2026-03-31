
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_6
{
    public class StandardTicket : Ticket, IPrintInfo, ICloneable
    {
        public string SeatNumber { get; set; }
        public StandardTicket( string movieName, decimal price , string seatNumber) : base( movieName, price)
        {
            SeatNumber = seatNumber;
        }
        //public override void PrintTicket()
        //{
        //    base.PrintTicket();
        //    Console.WriteLine($"SeatNumber {SeatNumber}");
        //}

        public void PrintInfo()
        {
            Console.Write($"TicketID {TicketId} Movie Name {MovieName} price {Price} PriceAfterTax {PriceAfterTax}");
            Console.WriteLine($"SeatNumber {SeatNumber}");
        }
        public object Clone()
        {
            return new StandardTicket(MovieName, Price , SeatNumber);
        }

        public override void TicketType()
        {
            Console.WriteLine($"TicketId {TicketId} - Standard");
        }
    }
}
