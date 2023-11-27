// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
Console.WriteLine(500);

for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

int y = 4;
Console.WriteLine(y);

string name = "Hi there, I am good";

Console.WriteLine(name);

Console.WriteLine(name.Contains("Good"));
name = name.ToUpper();
Console.WriteLine(name.Contains("good"));

for (int i = 0; i < name.Length; i++){
    Console.WriteLine(name[i]);
}
*/

Console.WriteLine("Here is your calculator  ");
Console.Write("Number 1  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("\nNumber 2  ");
int other_Number =  Convert.ToInt32(Console.ReadLine());
Console.Write("\nOperation  ");
char sign = '-';
// try{
sign = Convert.ToChar(Console.ReadLine());
// }except(e){

// };

// Console.WriteLine(sign);

if( sign == '*'){
        Console.WriteLine("OutPut  {0}", other_Number * number);
}
if( sign == '/'){
        Console.WriteLine("OutPut  {0}", number / other_Number );
}
if( sign == '+'){
        Console.WriteLine("OutPut  {0}", other_Number + number);
}
if( sign == '-'){
        Console.WriteLine("OutPut  {0}", other_Number - number);
}else{
    break;
}

switch( sign )
{
    case '*':
        Console.WriteLine("OutPut  {0}", other_Number * number);
            break;
    case '/':
        Console.WriteLine("OutPut  {0}", other_Number / number);
            break;
    case '+':
        Console.WriteLine("OutPut  {0}", other_Number + number);
            break;
    case '-':
        Console.WriteLine("OutPut  {0}", other_Number - number);
            break;
    default:
        break;
}

