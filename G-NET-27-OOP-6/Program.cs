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
            #endregion
        }
    }
}
