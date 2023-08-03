int number=0;
try
{
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number);

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

finally
{
    Console.WriteLine("Result {0}", number);
}