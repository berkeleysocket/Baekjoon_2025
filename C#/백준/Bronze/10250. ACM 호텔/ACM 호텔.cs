using static System.Console;

class Program
{
    static void Main() {
        int a=int.Parse(ReadLine());
        for(int i=0;i<a;i++){
        string[] f=ReadLine().Split(' ');
        int h=int.Parse(f[0]);
        int w=int.Parse(f[1]);
        int n=int.Parse(f[2]);
        if(n%h==0){
            WriteLine("{0}",h*100+n/h);
        }
        else{
            WriteLine("{0}",n%h*100+(n/h+1));
        }
        }
}
}