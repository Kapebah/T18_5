using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_5
{
    internal class Program
    {
        enum Action { Add = 1, Output, Exit }
        enum TypeOfItem { Product = 1, Batch, Set, Exit }
        static void Main(string[] args)
        {
            try
            {
                ItemsRepository repository = new ItemsRepository();
                bool flag = true;
                
                while (flag)
                {
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine("Choose an action:\n1 - Add item\n2 - Output all info\n3 - Exit\n");
                    ResetColor();
                    if (Enum.TryParse(ReadLine(), out Action action))
                    {
                        switch (action)
                        {
                            case Action.Add:
                                Clear();
                                ForegroundColor = ConsoleColor.DarkCyan;
                                WriteLine("Choose a type of item:\n1 - Product\n2 - Batch\n3 - Set\n4 - Exit\n");
                                ResetColor();
                                if (Enum.TryParse(ReadLine(), out TypeOfItem type))
                                {
                                    Clear();
                                    switch (type)
                                    {
                                        case TypeOfItem.Product:
                                            repository.AddItem(Product.Input());
                                            break;
                                        case TypeOfItem.Batch:
                                            repository.AddItem(Batch.Input());
                                            break;
                                        case TypeOfItem.Set:
                                            repository.AddItem(Set.Input());
                                            break;
                                        case TypeOfItem.Exit:
                                            Environment.Exit(0);
                                            break;
                                    }
                                }
                                else { WriteLine("Wrong action. Try again!"); }
                                break;
                            case Action.Output:
                                Clear();
                                repository.OutputItem();
                                break;
                            case Action.Exit:
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else { WriteLine("Wrong action. Try again!"); }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
