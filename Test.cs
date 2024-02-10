
int inch = 1;
double cm = 2.54;



double actual = inch * cm;
double expected = 2.54;

void Test(double expected, double actual)
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
Test(expected, actual);






double meters = cm / 100;
double actual2 = inch * meters;
double expected2 = 0.0254;

void Test2(double expected2, double actual2)
{
    if (expected2 == actual2)
    {

        Console.WriteLine("🟢 Test Passed");
    }
    else
    {
        Console.WriteLine($"🔴 Test Failed, expected:{expected2} actual:{actual2}");
    }

}
Test2(expected2, actual2);
