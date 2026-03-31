using System.ComponentModel;

namespace G_NET_27_OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1
            // Abstract class is process of exposing only what user needs and hide how it is implemented
            // encapsulation is procees of hiding data and only exposing neccesary data to user and abstract is process 0f hiding implements and only exposing what user needs
            // example Employee 
            // can make salary private and cant change it directly make method to get salary => encapsulation
            // make every employee what he do but hide how do it => abstract 

            #endregion

            #region Q2
            // abstract => 1- can have abstract method 2-can have constructor 3- can have fields 4- can have access modifier 5- cant have multiple inheritance 
            // interface => 1- can not have abstract method 2-can not have constructor 3- can not have fields 4- can not have access modifier 5- cant have multiple inheritance only have method signature and properties signature
            // choose abstract if i have 1- common logic between classes 2- i want to share code 3- classes are closely related 
            // choose interface if i 1- want to define role 2- want multiaple inhertance
            // 
            #endregion

            #region Q3
            //a- cant take object from abstract class
            //b- PowerConsumption() => abstract class =>Must be overridden in every derived class Because power consumption differs per device
            //, Status() => virtual class => Can be overridden but not required,because some device may need special behavior
            // and Label() => Cannot be overridden => Because label standard and identical for all devices.
            //c- will return "Standby" , because the method is virtual and not overridden in the derived class, so it will use the implementation from the base class which returns "Standby".
            #endregion

            #region Q4

            #endregion
            #endregion


            #region Part 02 : Practical (Extending the Movie Ticket Booking System)

       //     //     //Ticket t = new Ticket("Test", 25); // => error because we cant create object from abstract class
       //     Console.WriteLine("=== Cinema Opened ===");
       //     Cinema cinema01 = new Cinema("CinemaMax");
       //     cinema01.OpenCinema();
       //     Console.WriteLine();
       //     Console.WriteLine();
       //     Ticket ticket01 = new StandardTicket("Avatar", 120, "2A");
       //     ticket01.PrintInfo();
       //     ticket01.BookTicket();

       //     Ticket ticket02 = new VIPTicket("Taken", 150, true);
       //     ticket02.PrintInfo();
       //     ticket02.BookTicket();

       //     Ticket ticket03 = new IMAXTicket("Avengers", 200, true);
       //     ticket03.PrintInfo();
       //     ticket03.BookTicket();
       //     Console.WriteLine(" --- Polymorphism: Final Price per Ticket ---");
       //     Ticket[] tickets = new Ticket[]
       //{
       //           new VIPTicket("Taken" , 150 , true),
       //          new StandardTicket("Avatar", 120, "2A"),
       //          new IMAXTicket("Avengers" , 200 , true)
       //};
       //     foreach (Ticket t in tickets)
       //     {
       //         Console.WriteLine($"  {t.MovieName}    =>   {TicketType.prices(t)}");
       //     }
            
       //     Console.WriteLine(" ========== RECEIPT ==========");
       //     TicketType.Recipes(ticket01);
       //     Console.WriteLine(" =============================");
       //     ////Console.WriteLine(TicketType.prices(ticket02));

       //     Console.WriteLine(" --- Extension Method: Total Revenue ---");
       //      decimal totalRevenue = 0;
       //     foreach (Ticket t in tickets)
       //     {
       //         totalRevenue += TicketType.prices(t);
       //     }
       //         Console.WriteLine($"TotalRevenue {totalRevenue} ");

       //     Console.WriteLine();
       //     Console.WriteLine();
       //     Console.WriteLine(" === Cinema Closed ===");

       //     cinema01.CloseCinema();

            #endregion


        }


    }
    #region Extension method
    //public static class TicketType
    //{
    //    public static void Recipes(this Ticket ticket)
    //    {
    //        Console.WriteLine($"Movie : {ticket.MovieName} \n Type : {ticket.GetType().Name} \n Price :{ticket.Price} \n Final : {ticket.PriceAfterTax + ticket.Price} \n Status : {ticket.BookTicket()} ");
    //    }
    //    public static decimal prices(this Ticket ticket)
    //    {
    //        return ticket.PriceAfterTax ;
    //    }

    //} 
    #endregion
}
