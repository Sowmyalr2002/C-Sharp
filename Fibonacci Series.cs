using System;
class C{
    static void Main(string[] args){
        int a=0,b=1,sum=0;
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
        Console.WriteLine(b);
        for(int i=1;i<=n;i++){
            sum=a+b;
            Console.WriteLine(sum+" ");
            a=b;
            b=sum;
        }
    }
}
