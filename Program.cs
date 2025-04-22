using System;
using System.Threading.Tasks;

namespace Interview
{
class Meal{
string Name {get;set;}
int Calories {get;set;}
bool IsVegetarian {get;set;}


public Meal (string name, int calories, bool isVegetarian){
    Name=name;
    Calories=calories;
    isVegetarian=IsVegetarian;
}
}
class MealService {
static async Task<Meal> GetMealAsync(string name){ 
await Task.Delay(2000);
return new Meal(name,1000,true);

}


}
class Program {
static async Task Main(Meal Meal){ 
Console.WriteLine("Hey, welcome to the game, can you please enter the name of the meal");
string mealname=Console.ReadLine();
MealService ourMealService=await MealService.GetMealAsync(mealname);;
Console.WriteLine("The meal details are:");
Console.WriteLine($"Name:{ourMealService.Name}");
Console.WriteLine($"Calories:{ourMealService.calories}");
Console.WriteLine($"isVegetarian:{ourMealService.isVegetarian}");
}
}
}

