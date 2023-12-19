namespace HomeWork_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Введены нулевые аргументы");
            }
            else if(args.Length == 3) 
            {
                if(float.TryParse(args[0], out float firstNumber) && float.TryParse(args[2], out float secondNumber))
                {
                    if (char.TryParse(args[1], out char mathSym))
                    {
                        switch (mathSym)
                        {
                            case '+':
                                Console.WriteLine($"{firstNumber + secondNumber:f2}");
                                break;
                            case '-':
                                Console.WriteLine($"{firstNumber - secondNumber:f2}");
                                break;
                            case '/':
                                Console.WriteLine($"{firstNumber / secondNumber:f2}");
                                break;
                            case '*':
                                Console.WriteLine($"{firstNumber * secondNumber:f2}");
                                break;
                            default:
                                Console.WriteLine("Некорректный арифметический символ\nДопустимые символы: + - * /");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Арифметический знак не может быть длинее одного символа");
                    }
                }
                else
                {
                    Console.WriteLine("Один или оба аргументы не являются числом");
                }
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов");
                Console.WriteLine("Введите 3 аргумента, где\n1-й аргумент - первое число\n2-й аргумент - арифметический знак\n3-й аргумент - второе число");
            }
            Console.ReadLine();
        }
    }
}
