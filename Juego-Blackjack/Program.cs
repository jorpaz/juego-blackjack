int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int coins = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

System.Random random = new System.Random();//Esto para generar un numero aleatorio

//Blackjack, juntar 21 pidiendo cartar o en caso de que sea menos  tener mayor puntuacion que el dealer
//Si te pasas de 21 pierdes

while (true)
{

    Console.WriteLine("Bienvenido al C A S I N O");
    Console.WriteLine("Cuantos Coins deseas?\n" +
            "Recuerda que necesitas una por ronda \n");
    coins = int.Parse(Console.ReadLine()); //Esto es para convertir el string a un numero entero

    for (int i = 0; i < coins; i++)
    {

        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba '21' para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":

                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma una carta");
                    Console.WriteLine($"Te salio el numero: {num} ");
                    if (num > 0) { Console.WriteLine($"Numero total: {totalJugador} "); }
                    Console.WriteLine("Deseas otra carta? (Si o No)");
                    controlOtraCarta = Console.ReadLine().ToLower();

                } while (controlOtraCarta == "si");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades! \n";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs el dealer, te pasaste de 21. \n";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el dealer, lo siento \n";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condicion no valida. \n";
                    switchControl = "menu";
                }

                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor ingresado no valido en el C A S I N O");
                break;
        }
    }
}
