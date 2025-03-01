using System;
class Aula23{
    static void Main(){

        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[] vetor4=new int[5]{1,2,3,4,5};
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
        int procurado=6;
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










    }


}