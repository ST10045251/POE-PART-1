//Abigail Finnis
//ST10045251
//Group 2
//References:   Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6. Apress.
//              https://www.allrecipes.com/recipes/
//              https://www.c-sharpcorner.com/
//              https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements

namespace ST10045251_PROG_PART_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Recipe Journal!");
            //*********************************************************************************************************   
            //user interaction is made clear in program class
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. View an existing recipe");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddANewRecipe();
                        break;
                    case "2":
                        ViewExistingRecipe();
                        break;
                    case "3":
                        //user is leaving the recipe app
                        Console.WriteLine("Exiting Recipe Journal. Goodbye!");
                        return;
                    default:
                        //error check to see if user enters invalid choice
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
            //*********************************************************************************************************
            ///If user wishes to add a new recipe, this screen will show
            static void AddANewRecipe()
            {
                Console.WriteLine("\nAdding a new recipe");

                //let user enter the amount of ingredients
                int numIngredients = (int)GetValidDoubleInput("Please enter the amount of ingredients:");

                // Create a new instance of the Recipes class
                Recipes recipes = new Recipes(numIngredients, 5);

                // Add ingredients to the recipe
                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"\nEnter details for ingredient {i + 1}:");
                    string name = GetInput("Name:");

                    double quantity = GetValidDoubleInput("Quantity:");
                    string unit = GetInput("Unit:");

                    recipes.AddIngredients(i, name, quantity, unit);
                }

                //letting the user enter the amount of steps
                int numSteps = (int)GetValidDoubleInput("Please enter the amount of steps for the recipe:");

                //Add steps to the recipe
                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"\nEnter description for step {i + 1}:");
                    string description = Console.ReadLine();

                    recipes.AddSteps(i, description);
                }

                //Display entered recipe details
                recipes.DisplayRecipes();

                //Offer options to the user: clear the recipe or add it
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Clear the current recipe and start over");
                Console.WriteLine("2. Add the current recipe to an array");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        recipes.ClearRecipe();
                        Console.WriteLine("Recipe cleared. You can now add a new recipe.");
                        break;
                    case "2":
                        //Add the current recipe to an array
                        Console.WriteLine("Recipe added!.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Recipe not cleared or added.");
                        break;
                }
            }
            static string GetInput(string prompt)
            {
                Console.WriteLine(prompt + "");
                return Console.ReadLine();
            }

            static double GetValidDoubleInput(string prompt)
            {
                double result;
                while (true)
                {
                    Console.Write(prompt + "");
                    if (double.TryParse(Console.ReadLine(), out result) && result > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter the proper digit!");
                }
                return result;
            }
            
            //*********************************************************************************************************
            //user is viewing a recipe already stored in memory
            static void ViewExistingRecipe()
            {
                Console.WriteLine("\nViewing a recipe");
                //Example with 3 ingredients and 5 steps
                Recipes recipes = new Recipes(3, 5);
                recipes.AddIngredients(0, "Sugar", 1, "tablespoon");
                recipes.AddIngredients(1, "Flour", 2, "cups");
                recipes.AddIngredients(2, "Eggs", 3, "units");

                recipes.AddSteps(0, "Preheat oven to 180°C.");
                recipes.AddSteps(1, "Mix sugar and flour in a bowl.");
                recipes.AddSteps(2, "Add eggs to the mixture and stir well.");
                recipes.AddSteps(3, "Pour the batter into a greased pan.");
                recipes.AddSteps(4, "Bake for 30 minutes or until golden brown.");

                recipes.DisplayRecipes();

                //Clear the existing recipe data
                recipes.ClearRecipe();
            }
        }
    }
}
//******************************************END OF PROGRAM***************************************************************