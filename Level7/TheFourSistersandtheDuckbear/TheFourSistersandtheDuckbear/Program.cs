using System;

Console.WriteLine("How many chocolate eggs were gathered today?");
int numberOfChocolateEggs = Convert.ToInt32(Console.ReadLine());

int duckbearEggs = numberOfChocolateEggs % 3;
numberOfChocolateEggs -= duckbearEggs;
int sisterEggs = numberOfChocolateEggs / 3;

Console.WriteLine("The duckbear gets " + duckbearEggs + " and each sister gets " + sisterEggs);

//3 numbers where duckbear has more is 1,2 and 5