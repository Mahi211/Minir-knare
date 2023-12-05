using Miniräknare;
using System.ComponentModel.Design;

Console.WriteLine("Välkommen till miniräknaren. Tryck vart som helst för att börja");
Console.ReadLine();
Console.WriteLine("Välj en siffra");
string firstInput = Console.ReadLine();

while (!int.TryParse(firstInput, out int number))
{
    Console.WriteLine("Välj en siffra som är ett hel tal");
    firstInput = Console.ReadLine();
}

int firstNumber = Convert.ToInt32(firstInput);

Console.WriteLine("välj sätt att beräkna");
string tecken = Console.ReadLine();
while (tecken != "+" && tecken != "-" && tecken != "*" && tecken != "/")
{
    Console.WriteLine("Var vänlig och välj något utav dom här tecknen: +, -, *, /");
    tecken = Console.ReadLine();
}

Console.WriteLine("Välj din andra siffra");
string secondInput = Console.ReadLine();


while (!int.TryParse(secondInput, out int number))
{
    Console.WriteLine("Välj en siffra som är ett hel tal");
    secondInput = Console.ReadLine();
}

int secondNumber = Convert.ToInt32(secondInput);


Operation operation = new Operation();


operation.Result = operation.NumberOperation(firstNumber, secondNumber, tecken);

Console.WriteLine("Ditt svar är " + operation.Result);





