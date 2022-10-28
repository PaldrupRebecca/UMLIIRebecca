// See https://aka.ms/new-console-template for more information


#region pizza
using UML2Rebecca;

PizzaRepository pizzaRepository = new PizzaRepository();

Console.WriteLine("Test af AddPizza");
Pizza p1 = new Pizza(3, "Capricciosa", 80, "tomato, cheese, ham & mushrooms");
Console.WriteLine($"Antal pizza inden add af pizza {pizzaRepository.Count}");
pizzaRepository.AddPizza(p1);
Pizza p2 = new Pizza(11, "Naples", 79, "tomato, cheese, anchovies & olives");
Pizza p3 = new Pizza(9, "Gorgonzola", 85, "tomato, gorgonzola, onion & mushroom");
pizzaRepository.AddPizza(p2);
pizzaRepository.AddPizza(p3);
Console.WriteLine($"Antal pizza efter add af 3 pizzaer: {pizzaRepository.Count}");

Console.WriteLine("\n");

Console.WriteLine("Test af LookupPizza");
Pizza foundPizza = pizzaRepository.LookupPizza(3);
if (foundPizza != null)
{
    //Udskriv foundPizza
    Console.WriteLine($"Pizza fundet {foundPizza.ToString()}");
}
else
{
    //Udskriv pizza ikke fundet
    Console.WriteLine("Pizza ikke fundet");
}

Console.WriteLine("\n");

//Console.WriteLine("Test af DeletePizza");
//pizzaRepository.DeletePizza(11);
//Console.WriteLine($"Antal pizza efter delete af 1 pizza: {pizzaRepository.Count}");

Console.WriteLine("\n");

//Console.WriteLine("Test af UpdatePizza");
//Console.WriteLine("Pizzaer før ændring:");
//pizzaRepository.PrintPizzas();
//Pizza upDatedPizza = new Pizza(9, "Gorgonzola", 90, "tomato, gorgonzola, onion, beef & mushroom");
//pizzaRepository.UpdatePizza(9, upDatedPizza);
//Console.WriteLine("Pizzaer efter ændring:");
//pizzaRepository.PrintPizzas();

Console.WriteLine("\n\n");
#endregion

#region customer
CustomerRepository customerRepository = new CustomerRepository();

Console.WriteLine("Test af AddCustomer");
Customer c1 = new Customer("Børge Hansen", "bh@gmail.com", "Børgevej 23");
Customer c2 = new Customer("Hans Frederiksen", "hans.fr@hotmail.com", "Rosengade 7");
Customer c3 = new Customer("Lene Mogensen", "lene@mogensen.dk", "Poppelvænget 29");
Console.WriteLine($"Antal customers inden add af customer {customerRepository.Count}");
customerRepository.AddCustomer(c1);
customerRepository.AddCustomer(c2);
customerRepository.AddCustomer(c3);
Console.WriteLine($"Antal customers efter add af 3 customers: {customerRepository.Count}");

Console.WriteLine("\n");

Console.WriteLine("Test af LookupCustomer");
Customer foundCustomer = customerRepository.LookupCustomer("Børge Hansen");
if (foundCustomer != null)
{
    Console.WriteLine($"Customer fundet: \n{foundCustomer.ToString()}");
}
else
{
    Console.WriteLine("Customer ikke fundet");
}

Console.WriteLine("\n");

Console.WriteLine("Test af DeleteCustomer");
customerRepository.DeleteCustomer("Lene Mogensen");
Console.WriteLine($"Antal customers efter delete af 1 customer: {customerRepository.Count}");

Console.WriteLine("\n");

Console.WriteLine("Test af UpdateCustomer");
Console.WriteLine("Customers før ændring:");
customerRepository.PrintCustomers();
Customer upDatedCustomer = new Customer("Børge Hansen", "bh@gmail.com", "Poppelvænget 31");
customerRepository.UpdateCustomer("Børge Hansen", upDatedCustomer);
Console.WriteLine("Customers efter ændring:");
customerRepository.PrintCustomers();
#endregion

PizzaMenu pizzaMenu = new PizzaMenu(pizzaRepository);
pizzaMenu.Run();
Console.ReadLine();