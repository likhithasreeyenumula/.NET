﻿using System;
int eno;
string ename;
double esal;
double epf;
string egrade;
bool ews;
Console.Write("Enter Eno:");
eno = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Ename:");
ename = Console.ReadLine();
Console.Write("Enter Esal:");
esal =Convert.ToDouble( Console.ReadLine());
Console.Write("Enter Epf:");
epf = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Egrade:");
egrade = Convert.ToChar(Console.ReadLine());
Console.Write("Enter E work Status:");
esal = Convert.ToBoolean(Console.ReadLine());
System.Console.Clear();
System.Console.WriteLine("--------------------------------------------");
System.Console.WriteLine("EMPLOYEE DETAILS");
System.Console.WriteLine("--------------------------------------------");
System.Console.WriteLine("Number="+eno);
System.Console.WriteLine("Name=" + ename);
System.Console.WriteLine("Salary=" + esal);
System.Console.WriteLine("Provident fund=" + epf);
System.Console.WriteLine("Grade=" + egrade);
System.Console.WriteLine("Work Status=" + ews);
System.Console.WriteLine("--------------------------------------------");