using System;
class C{
    static void Main(string[] args){
        int n=Convert.ToInt32(Console.ReadLine());
        int sum=0,rem=0,temp=n;
        while(n>0){
            rem=n%10;
            sum=(sum*10)+rem;
            n=n/10;
        }
        if(sum==temp)
          Console.WriteLine("Palindrome");
        else
          Console.WriteLine("Not a Palindrome");
    }
}
