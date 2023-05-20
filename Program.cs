using System;
public class Program{
    static void Main(string[]args){
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        if ((N > 0 && N <= 10000 ) && ( K > 0 && K <= 100)){
            int [] people = new int[N];
            for(int i = 0;i < N;i++){
                people[i] = int.Parse(Console.ReadLine());
                if (people[i] > 500 || people[i] < 0){
                    Console.WriteLine("Please input ({0}) again", i+1);
                    i--;
                }
                }
                int resultsize = N-(K*2);
                int [] result = new int [resultsize];
                for(int i = K;i < N-K;i++){
                    int sum = 0;
                    sum += people[i];
                    for(int j = 0;j < K;j++){
                        sum += people[i+1];
                        sum += people[i-1];
                    }
                    result[i-K] = sum;
                }
                int Result = 0;
                for(int j = 0;j < resultsize-1;j++){
                    Result = Max(result[j],result[j+1]);
                    if(result[j+1] < Result){
                    result[j+1] = Result;      
                    }
                    else{
                    Result = result[j+1];
                    }
                     
                }
              Console.WriteLine("{0}",Result);
            }
            else {

            }
        }
        static int Max(int a, int b){
            if(a > b){
                return a;
            }
            else {
                return b;}
        }
    }
