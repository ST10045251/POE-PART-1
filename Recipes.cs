//Abigail Finnis
//ST10045251
//Group 2
//References:   Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6. Apress.
//              https://www.allrecipes.com/recipes/
//              https://www.c-sharpcorner.com/
//              https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements

namespace ST10045251_PROG_PART_1
{
    internal class Recipes
    {
        private Ingredients[] ingredients;
        private Ingredients[] initialQuantities;
        private Steps[] steps;
        //*********************************************************************************************************
        //Variables and constructors are being declared
        public Recipes(int numIngredients, int numSteps)
        {
            ingredients = new Ingredients[numIngredients];
            initialQuantities = new Ingredients[numIngredients];
            steps = new Steps[numSteps];
        }
        //*********************************************************************************************************
        public void AddRecipe(int numIngredients, int numSteps)
        {
            ingredients = new Ingredients[numIngredients];
            initialQuantities = new Ingredients[numIngredients];
            steps = new Steps[numSteps];

            
        }

        //*********************************************************************************************************
        //AddIngredients method added to class
        public void AddIngredients(int index, string name, double quantity, string unit)
        {
            ingredients[index] = new Ingredients(name, quantity, unit);
            initialQuantities[index] = new Ingredients(name, quantity, unit);
        }
        //*********************************************************************************************************
        //RemoveIngredients method added to class
        public void RemoveIngredients(int index)
        {
            ingredients[index] = null;
        }
        //*********************************************************************************************************
        //AddSteps method added to class
        public void AddSteps(int index, string description)
        {
            steps[index] = new Steps(description);
        }
        //*********************************************************************************************************
        //RemoveSteps method added to class
        public void RemoveSteps(int index)
        {
            steps[index] = null;
        }
        //*********************************************************************************************************
        //DisplayRecipes method added to class
        public void DisplayRecipes()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                if (ingredient != null)
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                //a null check is added in method to handle null ingredient and steps entries
                if (steps[i] != null)
                    Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
        }
        //*********************************************************************************************************
        //ScaleRecipe method added to class
        public void ScaleRecipe(double factor)
        {
            if (factor <= 0)
            {
                Console.WriteLine("Error! /nMust be greater than 0!");
                return;
            }

            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
        //*********************************************************************************************************
        //ResetQuantities method added to class
        public void ResetQuantities()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i].Quantity = initialQuantities[i].Quantity;
            }
        }
        //*********************************************************************************************************
        //ClearRecipe method added to class
        public void ClearRecipe()
        {
            //Array.Clear is added instead of manually setting arrays to null
            Array.Clear(ingredients, 0, ingredients.Length);
            Array.Clear(initialQuantities, 0, initialQuantities.Length);
            Array.Clear(steps, 0, steps.Length);
            ingredients = new Ingredients[ingredients.Length];
            initialQuantities = new Ingredients[initialQuantities.Length];
            steps = new Steps[steps.Length];

        }
    }
}
//******************************************END OF PROGRAM***************************************************************
