using System;
class Aula23{
    static void Main(){

        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[] vetor4=new int[5]{1,4,3,4,5};
        char[] vetor5=new char[5]{'a','b','c','d','e'};
        int[,] matriz=new int[2,5]{{10,20,30,40,50},{15,25,35,45,55}};


        Random random=new Random();
        for(int i=0;i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);
        }

        Console.WriteLine("\nElementos do vetor1: \n");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        Random random2=new Random();
        for(int i=0;i<vetor2.Length;i++){
            vetor2[i]=random.Next();
        }

        Console.WriteLine("\nElementos do Vetor2: \n");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        Random random3=new Random();
        for(int i=0;i<vetor3.Length;i++){
        vetor3[i]=random.Next(150,200);
        }

        Console.WriteLine("\nElementos do vetor3: \n");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }

        Console.WriteLine("\nBinarySearch\n");
        int procurado=4;
        int pos=Array.BinarySearch(vetor4, procurado);
        Console.WriteLine("\nValor {0} está na posição {1}\n", procurado, pos);

        Console.WriteLine("\nCopy\n");
        Array.Copy(vetor4,vetor3,3);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }

        Console.WriteLine("\nVetor 3 após a copia: \n");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }

        Console.WriteLine("\nCopyTo\n");
        vetor1.CopyTo(vetor2,0);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }


        Console.WriteLine("\nGetLowerBound\n");
        int MenorIndiceDoVetor=vetor1.GetLowerBound(0);
        int MenorIndiceDaMatriz=matriz.GetLowerBound(1);
        Console.WriteLine("O menor indice do vetor1 é: {0}", MenorIndiceDoVetor);
        Console.WriteLine("O menor indice da matriz é: {0}", MenorIndiceDaMatriz);


        Console.WriteLine("\nGetLongLength\n");
        long qtdElementosVetor=vetor1.GetLongLength(0);
        long qtdElementosMatriz=matriz.GetLongLength(1);
        Console.WriteLine("Quantidade de elementos no vetor1 é: {0}", qtdElementosVetor);
        Console.WriteLine("Quantidade de elementos na matriz é: {0}", qtdElementosMatriz);

        Console.WriteLine("\nGetUpperBound\n");
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz=matriz.GetUpperBound(1);
        Console.WriteLine("O maio indice do vetor1 é: {0}", MaiorIndiceVetor);
        Console.WriteLine("O maio indice da matriz é: {0}", MaiorIndiceMatriz);

        Console.WriteLine("\nGetValue\n");
        int ValorVetor=Convert.ToInt32(vetor1.GetValue(2));
        int ValorMatriz=Convert.ToInt32(matriz.GetValue(0,3));
        Console.WriteLine("O valor do indice 2 do vetor1 é: {0}", ValorVetor);
        Console.WriteLine("O valor do indice (0,3) da matriz é: {0}", ValorMatriz);


        Console.WriteLine("\nIndexOf\n");
        int indice1=Array.IndexOf(vetor4, 4);
        Console.WriteLine("Indice do primeiro valor 4: {0}", indice1);

        Console.WriteLine("\nLastIndexOf\n");
        int indice2=Array.LastIndexOf(vetor4, 4);
        Console.WriteLine("O ultimo indice com o valor 4 é: {0}", indice2);

        Console.WriteLine("\nSetValue\n");
        vetor4.SetValue(2, 1);
        for(int i=0;i<vetor1.Length;i++){
            vetor1.SetValue(0,i);
        }

        
        Console.WriteLine("\nReverse\n");
        Array.Reverse(vetor4);
        foreach(int n in vetor4){
            Console.WriteLine(n);
        }

        Console.WriteLine("\nSort\n");
        Array.Sort(vetor4);
        foreach(int n in vetor4){
            Console.WriteLine(n);
        }







    }

       


}