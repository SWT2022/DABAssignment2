using System;
using System.Linq;
using System.Collections.Generic;
using DABAssignment2;
//using DABAssignment2.QueryHelpers;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Welcome to the Municipalicy's building administration\n");
//bool flag = true;
//QueryHelper queryHelper = new QueryHelper();

//using (var context = new MuniDbContext())
//{
//    Console.WriteLine("Here you can query the database for information\n" +
//                      "Get all the rooms and their addresses 'R/r' | \n" +
//                      "Get all the societies and their information and sort them by activity 'S/s' | \n" +
//                      "Get a list of booked rooms, with the booking society and the times it's booked 'B/b' | \n" +
//                      "Terminate the program 'Q/q'");
//    while (flag)
//    {
//        Console.WriteLine("Type command");
//        string input = Console.ReadLine().ToLower();

//        switch (input)
//        {
//            case "r":
//                queryHelper.ListRoomsNAddresses(context);
//                break;
//            case "s":
//                queryHelper.ListSocietiesByActivity(context);
//                break;
//            case "b":
//                queryHelper.ListBookings(context);
//                break;
//            case "q":
//                flag = false;
//                break;
//            default:
//                Console.WriteLine(input + " is an invalid input - try again");
//                break;
//        }

//        Console.WriteLine("Type any key to continue");
//        Console.ReadKey();
//    }

//}

//Console.WriteLine("\nThe program is terminating...");