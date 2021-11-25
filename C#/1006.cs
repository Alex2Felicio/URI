Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

Saída
Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".



using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, c, r;
        a= double.Parse(Console.ReadLine());
        b= double.Parse(Console.ReadLine());
        c= double.Parse(Console.ReadLine());
        
        
        if(a < 11 && b < 11 && c<11){
            
            r = (a/10*2)+(b/10*3)+(c/10*5);
            Console.WriteLine("MEDIA = " + r.ToString("0.0"));
            Console.ReadKey();
        }

    }

}
