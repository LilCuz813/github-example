// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Main(string[] args)
{

    Console.WriteLine("Please enter a radius.");

    //string result = Console.ReadLine();
    //double num = double.Parse(result);
    double num = double.Parse(Console.ReadLine());
    double area = num * num * Math.PI;
    Console.WriteLine(num);

    //NULL
    string myName = null;
    Console.WriteLine(myName);
    string friend = "Dre";

    if (friend == "Family")
    {
        myName = "Chris";
    }
    else if (friend == "Dre")
    {
        myName = "LilCuz";
    }
    Console.WriteLine(myName);

}
