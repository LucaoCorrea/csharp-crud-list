namespace Program {
internal class Program
{
    private static void Main(string[] args)
    {
            // create a list of double for salary
            List<double> salary = new List<double>();

            // create option for menu
            int option = 0;


            // menu loop
            while (true)
            {
                // options of menu
                Console.Clear();
                Console.WriteLine("---LISTA DE SALÁRIOS---");
                Console.WriteLine("1- Inserir salário na lista");
                Console.WriteLine("2- Exibir todos os salários");
                Console.WriteLine("3- Calcular a soma e a média dos salários");
                Console.WriteLine("4- Remover salário da lista");
                Console.WriteLine("5- Ordenar salários(em ordem crescente)");
                Console.WriteLine("0- Sair");

                string input = Console.ReadLine();


                // validate if input is a number equals the option
                if (!int.TryParse(input, out option)){
                    Console.WriteLine("Opção inválida, digite um número.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("opção escolhida: " + option);
                Console.Clear();


                // switch expression
                switch (option)
                {
                    // case 1: to insert salary in the list, must be between 1 and 1000
                    case 1:
                        {
                            Console.WriteLine("Digite o Salário: ");
                            var sal = double.Parse(Console.ReadLine());
                            if (sal >= 1 && sal <= 1000)
                            {
                                salary.Add(sal);
                                Console.WriteLine("Salário adicionado com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Salário inválido, deve ser entre 1 e 1000");
                            }
                            break;
                        }
                    // case 2: to display all salaries in the list
                    case 2:
                        {
                            Console.WriteLine("Lista de salários: ");
                            foreach (var sal in salary)
                            {
                                Console.WriteLine(sal);
                            }
                            break;
                        }
                    // case 3: to calculate the sum and the average
                    case 3:
                        {
                            var sum = salary.Sum();
                            var medium = salary.Average();
                            Console.WriteLine("Soma dos salários: " + sum);
                            Console.WriteLine("//////////////////////////");
                            Console.WriteLine("Média dos salários: " + medium);
                            break;
                        }
                    // case 4: to remove a salary
                    case 4:
                        {
                            Console.WriteLine("Digite o salário a ser removido: ");
                            var sal = double.Parse(Console.ReadLine());
                            if (salary.Contains(sal))
                            {
                                salary.Remove(sal);
                                Console.WriteLine("Salário removido com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Salário não encontrado na lista.");
                            }
                            break;
                        }
                    // case 5: to order in ascending order
                    case 5:
                        {
                            var sal = salary.OrderBy(s => s).ToList();
                            Console.WriteLine("Salários em ordem crescente: ");
                            Console.WriteLine(string.Join(", ", sal));
                            break;
                        }
                    // case 0: to exit the console app
                    case 0:
                        {
                            Console.WriteLine("Saindo...");
                            Environment.Exit(0);
                            break;
                        }
                    // default: to invalid insert option
                    default:
                        {
                            Console.WriteLine("Opção inválida");
                            break;
                        }
                }

                // wait for user to press any key to continue 
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    } }
