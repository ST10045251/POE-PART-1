using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abigail Finnis
//ST10045251
//Group 2
//References:   Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6. Apress.
//              https://www.allrecipes.com/recipes/
//              https://www.c-sharpcorner.com/
//              https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements

namespace ST10045251_PROG_PART_1
{
    internal class Ingredients
    {
        //Variables and constructors are being declared
        public string Name { get; set; }
         
        public double Quantity {  get; set; }
        public string Unit {  get; set; }

        //*********************************************************************************************************
       //Properties and constructor is added 
        public Ingredients(string name, double quantity, string unit) 
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
//******************************************END OF PROGRAM***************************************************************
