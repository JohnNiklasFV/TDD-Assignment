   
int inch = 1;
double cm = 2.54;

double actual = inch * cm;
double expected = 2.54;

void Test (double expected, double actual)
{
    if (expected == actual)
    {
        
        Console.WriteLine("🟢 Test Passed");
    }   
    else
    {
        Console.WriteLine("🔴 Test Failed");
    }
    
}
Test( expected, actual);





