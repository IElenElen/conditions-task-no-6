namespace conditions_task_no_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C. Task no 6");
            //Napisz program, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            //Dane testowe: 140. Rezultat: Jesteś krasnoludem.

            //&

            Console.WriteLine("Podaj swój wzrost");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out double userHeight))
            {
                Console.WriteLine("Konwersja powiodła się.");
            }
            else
            {
                Console.WriteLine("Nie piernicz głupot tylko wprowadź poprawny wzrost");
            }

                if (userHeight <= 0)
                {
                    Console.WriteLine("Jesteś mikroskopijną bakterią");
                }
                else if ((userHeight > 0) & (userHeight <= 100))
                {
                    Console.WriteLine("Jesteś bajkowym gumisiem");
                }
                else if ((userHeight > 100) & (userHeight <= 140))
                {
                    Console.WriteLine("Jesteś mega niski");
                }
                else if ((userHeight > 140) & (userHeight <= 150))
                {
                    Console.WriteLine("Ujdzie, mogło być jednak lepiej");
                }
                else if ((userHeight > 150) & (userHeight <= 165))
                {
                    Console.WriteLine("Mieścisz się w wzrościanej normie");
                }
                else if ((userHeight > 165) & (userHeight <= 170))
                {
                    Console.WriteLine("Takiego wzrostu to tylko pozazdrościć");
                }
                else if ((userHeight > 170) & (userHeight <= 190))
                {
                    Console.WriteLine("Możesz zostać koszykarzem");
                }
                else if (userHeight > 190)
                {
                    Console.WriteLine("No Tobie to trumnę na specjalne zamówineie bedą robić");
                }
                else
                {
                    Console.WriteLine("Nie piernicz głupot tylko wprowadź poprawny wzrost");
                }
            

        }
    }
}
