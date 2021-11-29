Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. 
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Entrada
O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, 
quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

Saída
Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. 
No caso do salário, também deve haver um espaço em branco após o $.








using System; 
using System.Globalization;
using System.Threading;

class URI {

    static void Main(string[] args) { 

            int id;
            double num1, num2, resultado;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            
            id = int.Parse(Console.ReadLine());
            
            num1 = Double.Parse(Console.ReadLine());
            num1.ToString(CultureInfo.InvariantCulture);

            num2 = double.Parse(Console.ReadLine());
            num2.ToString(CultureInfo.InvariantCulture);

            resultado = num1 * num2;
            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = U$ " + resultado.ToString("0.00"));
            Console.ReadKey();

    }

}
