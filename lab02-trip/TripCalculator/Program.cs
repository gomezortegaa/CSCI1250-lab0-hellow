/*
 * Name:    Andy Gomez
 * Course:  CSCI 1250, Section 001
 * Assignment:  Lab 02, Trip Calculator
 * Date:    September 22, 2026
 * Description: Calculates the fuel, food, and work behind one road trip.
*/

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

Console.Write ("How many people are going? ");