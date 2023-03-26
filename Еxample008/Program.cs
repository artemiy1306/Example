// See https://aka.ms/new-console-template for more information
int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}

int a1 = 23;
int b1 = 5;
int c1 = 222;
int a2 = 2;
int b2 = 26;
int c2 = 75;
int a3 = 69;
int b3 = 42;
int c3 = 72;

int max = Max(
     Max(a1, b1, c1),
     Max(a2, b2, c2),
     Max(a3, b3, c3));
Console.WriteLine(max);