
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_6
{
    internal class IMAXTicket : Ticket , IPrintInfo , ICloneable
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30 : price)
        {
            Is3D = is3D;
        }
        //public override void PrintTicket()
        //{
        //    base.PrintTicket();
        //    Console.WriteLine($"Is3D {Is3D}");
        //}

        public void PrintInfo()
        {
            Console.Write($"TicketID {TicketId} Movie Name {MovieName} price {Price} PriceAfterTax {PriceAfterTax}");
            Console.WriteLine($"Is3D {Is3D}");
        }
        public override void TicketType()
        {
            Console.WriteLine($"TicketId {TicketId} - IMAX");
        }
        public object Clone()
        {
            return new IMAXTicket(MovieName, Price , Is3D);
        }
    }
}
