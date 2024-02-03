// Triângulo é uma figura geométrica formada por três retas que se encontram duas a duas e não passam pelo mesmo ponto,
// formando três lados e três ângulos.

// 1. O triângulo pode ser classificado segundo a medida do seu lado
// * Triângulo escaleno: Todos os lados e ângulos são diferentes.
// * Triângulo isósceles: dois lados iguais e os ângulos opostos a esses lados iguais.
// 8 Triângulo equilátero: Todos os lados e ângulos iguais. Concluímos que seus ângulos serão de 60°.

// 2. Restrições para a construção de um triangulo
// * Para construir um triângulo é necessário que a medida de qualquer um dos lados seja menor que a soma dos
// outros dois lados.
// * Caso algum comprimento dos lados do triângulo for inválido, escrever a mensagem “Triangulo Inválido”


//Variáveis
//=======================================================
double lado1, lado2, lado3;
string resposta = "";
//=======================================================



while (resposta != "N")
{
    Console.Clear();
    //Obter os valores dos lados
    //=======================================================
    Console.WriteLine("Digite o valor do lado 1: ");
    lado1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o valor do lado 2: ");
    lado2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do lado 3: ");
    lado3 = double.Parse(Console.ReadLine());
    //=======================================================

    //Verificar se é um triângulo
    //=======================================================
    if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
    {
        //Verificar o tipo de triângulo
        //=======================================================
        
        //Triângulo Equilátero
        //-------------------------------------------------------
        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Triângulo Equilátero /n");
        }
        //-------------------------------------------------------

        //Triângulo Isósceles
        //-------------------------------------------------------
        else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
        {
            Console.WriteLine("Triângulo Isósceles \n");
        }
        //-------------------------------------------------------
        
        //Triângulo Escaleno
        //-------------------------------------------------------
        else
        {
            Console.WriteLine("Triângulo Escaleno \n");
        }
        //-------------------------------------------------------
        //=======================================================
    }
    else
    {
        Console.WriteLine("Triângulo Inválido \n");
    }
    //=======================================================
    
    VerificarContinuidade();
}

void VerificarContinuidade()
{
    Console.WriteLine("Deseja verificar outro triângulo? (S/N)");
    resposta = Console.ReadLine().ToUpper();
}