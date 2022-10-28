using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Rebecca
{
    public class PizzaMenu
    {
        private PizzaRepository _pizzaRepository;
        public PizzaMenu(PizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------CRUD Operations--------------------");
            Console.WriteLine("\t1.\tAdd pizza to PizzaRepository");
            Console.WriteLine("\t2.\tSee list of pizzas");
            Console.WriteLine("\t3.\tLook for a pizza in PizzaRepository based on PizzaNo");
            Console.WriteLine("\t4.\tRemove pizza from PizzaRepository");
            Console.WriteLine("\t5.\tUpdate pizza in PizzaRepository");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tType 0 to exit");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tType your choice:");
            return ReadUserChoice();
        }

        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        AddPizzaToDictionary();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Print pizzas");
                        _pizzaRepository.PrintPizzas();
                        break;
                    case 3:
                        Console.Clear();
                        SearchPizzas();
                        break;
                    case 4:
                        Console.Clear();
                        DeletePizzaFromDictionary();
                        break;
                    case 5:
                        Console.Clear();
                        UpdatePizzaInDictionary();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("input error");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();

            }

        }



        private void AddPizzaToDictionary()
        {
            Console.WriteLine("Add pizza");
            Console.WriteLine("Write PizzaNo (int)");
            int pizzano = int.Parse(Console.ReadLine());
            Console.WriteLine("Write PizzaName (string)");
            string pizzaname = Console.ReadLine();
            Console.WriteLine("Write Price (int)");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Ingredients (string)");
            string ingredients = (Console.ReadLine());
            Pizza p = new Pizza(pizzano, pizzaname, price, ingredients);
            _pizzaRepository.AddPizza(p);
        }

        private void SearchPizzas()
        {
            Console.WriteLine("Search pizza");
            Console.WriteLine("Write PizzaNo (int)");
            int pizzano = int.Parse(Console.ReadLine());
            Pizza pizza = _pizzaRepository.LookupPizza(pizzano);
            if (pizza == null)
            {
                Console.WriteLine("The pizza you are looking for does not exist");
            }
            else
            {
                Console.WriteLine(pizza);
            }
            Console.ReadLine();
        }
        private void DeletePizzaFromDictionary()
        {
            Console.WriteLine("Delete pizza");
            Console.WriteLine("Write PizzaNo (int)");
            int pizzano = int.Parse(Console.ReadLine());
            _pizzaRepository.DeletePizza(pizzano);
        }


        private void UpdatePizzaInDictionary()
        {
            Console.WriteLine("Update pizza");
            Console.WriteLine("Write the PizzaNo of the pizza to be updated (int)");
            int pizzanoOld = int.Parse(Console.ReadLine());
            Pizza pizza = _pizzaRepository.LookupPizza(pizzanoOld);
            if (pizza == null)
            {
                Console.WriteLine("The pizza you are looking for does not exist");
            }
            else
            {
                Console.WriteLine("Update pizza");
                Console.WriteLine("Write PizzaNo (int)");
                int pizzano = int.Parse(Console.ReadLine());
                Console.WriteLine("Write PizzaName (string)");
                string pizzaname = Console.ReadLine();
                Console.WriteLine("Write Price (int)");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Write Ingredients (string)");
                string ingredients = (Console.ReadLine());

                Pizza updatedPizza = new Pizza(pizzano, pizzaname, price, ingredients);

                _pizzaRepository.UpdatePizza(pizzanoOld, updatedPizza);
                Console.WriteLine("The pizza has been updated");
                Console.ReadLine();
            }
        }
    }
}
