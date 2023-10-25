using dependency_injection_examples;
class Program
{
    public static void Main()
    {

        CoffeeMachine coffeeMachine = new CoffeeMachine();
        MilkshakeMachine milkshakeMachine = new MilkshakeMachine();

        // Without Dependency Injection
        Console.WriteLine("Without dependency injection");
        CafeWorkerWithoutInjection barista = new CafeWorkerWithoutInjection();
        string coffee = barista.ServeDrink("latte");
        Console.WriteLine(coffee);

        // Constructor Injection
        Console.WriteLine("Constructor injection:");
        CafeWorkerCtorInjection barista1 = new CafeWorkerCtorInjection(coffeeMachine);
        CafeWorkerCtorInjection milkshakeMachineOperator1 = new CafeWorkerCtorInjection(milkshakeMachine);
        string coffee1 = barista1.ServeDrink("latte");
        string milkshake1 = milkshakeMachineOperator1.ServeDrink("vanilla");
        Console.WriteLine(coffee1);
        Console.WriteLine(milkshake1);

        // Method Injection
        Console.WriteLine("Method injection:");
        CafeWorkerMethodInjection barista2 = new CafeWorkerMethodInjection();
        CafeWorkerMethodInjection milkshakeMachineOperator2 = new CafeWorkerMethodInjection();
        string coffee2 = barista2.ServeDrink(coffeeMachine, "latte");
        string milkshake2 = milkshakeMachineOperator2.ServeDrink(milkshakeMachine, "vanilla");
        Console.WriteLine(coffee2);
        Console.WriteLine(milkshake2);

        // Property Injection
        Console.WriteLine("Property injection:");
        CafeWorkerPropertyInjection barista3 = new CafeWorkerPropertyInjection();
        CafeWorkerPropertyInjection milkshakeMachineOperator3 = new CafeWorkerPropertyInjection();
        barista3.DrinkMachine = coffeeMachine;
        milkshakeMachineOperator3.DrinkMachine = milkshakeMachine;
        string coffee3 = barista3.ServeDrink("latte");
        string milkshake3 = milkshakeMachineOperator3.ServeDrink("vanilla");
        Console.WriteLine(coffee3);
        Console.WriteLine(milkshake3);
    }
}