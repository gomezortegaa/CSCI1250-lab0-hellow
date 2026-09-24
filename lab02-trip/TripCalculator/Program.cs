/*
 * Name:    Andy Gomez
 * Course:  CSCI 1250, Section 001
 * Assignment:  Lab 02, Trip Calculator
 * Date:    September 22, 2026
 * Description: Calculates the fuel, food, and work behind one road trip.
*/

/*
Part 1
*/

using System.Numerics;

Console.Write("How many miles did you travel? ");
int roundTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the mile per gallon for the car you travel on? ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What was the average price per gallon you paid? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTrip / milePerGallon;

double fuelcost = gallonsNeeded * pricePerGallon;

Console.WriteLine ("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine ("Fuel cost: " + fuelcost.ToString("C"));

/*
Part 2
*/

Console.Write ("How many people are going? ");
int attandance = Convert.ToInt32(Console.ReadLine());

Console.Write ("How many pizzas? ");
int pizzaboxes = Convert.ToInt32(Console.ReadLine());

Console.Write ("Price per pizza? ");
double pizzacost = Convert.ToDouble(Console.ReadLine());

const int pizzaslices = 8;

int totalslices = pizzaboxes * pizzaslices;

double slicesPer = totalslices / attandance;

double pizzatotal = pizzaboxes * pizzacost;

Console.WriteLine ("Total slices: " + totalslices);
Console.WriteLine ("Slices Per Person: " + slicesPer.ToString("F1"));
Console.WriteLine ("Pizza Cost:" + pizzatotal.ToString("F2"));

/*
Part 3
*/

Console.Write ("How many hours have you worked? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine()); 

Console.Write("How much do you get paid?");
int payrate = Convert.ToInt32(Console.ReadLine());

const decimal taxrate = 18m;

double paycheck = hoursWorked * payrate;

decimal grosspay = Convert.ToDouble(paycheck * taxrate); 

double taxwitheld = Convert.ToDouble(grosspay * taxrate);
