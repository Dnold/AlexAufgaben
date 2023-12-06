using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class Tester
{
    //A method Tester that expects the given input and the expected output to then check if the Method is doing its Job

    public static void TestIntBool(IntBoolTest intBool)
    {
        string prefix = "";
        if (intBool.hidden)
        {
            prefix = "Hidden ";
        }
        if (intBool.output == intBool.expectedOutput)
        {
            Console.WriteLine(prefix + "Test passed ;)", Color.Green);
        }
        else
        {
            Console.WriteLine(prefix + "Test failed :/", Color.Red);
        }
        if (intBool.hidden)
        {
            Console.WriteLine("Hidden Test");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Input: " + intBool.input);
            Console.WriteLine("Output: " + intBool.output);
            Console.WriteLine("Expected Output: " + intBool.expectedOutput);
        }
        Console.WriteLine();
        Console.WriteLine("<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//");
        Console.WriteLine();
    }

    public static void TestStringArrayBool(StringArrayBoolTest test)
    {
        string prefix = "";
        if (test.hidden)
        {
            prefix = "Hidden ";
        }
        if (test.output == test.expectedOutput)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(prefix + "Test passed ;)", Color.Green);
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(prefix + "Test failed :/", Color.Red);
            Console.ResetColor();
        }


        if (!test.hidden)
        {
            Console.WriteLine("Input: ");
            foreach (string i in test.input)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("Output: " + test.output);
            Console.WriteLine("Expected Output: " + test.expectedOutput);
        }
        else
        {
            Console.WriteLine("Hidden Test");
        }
    }
    public static void TestIntInIntOut(IntInIntOutTest intIn)
    {
        string prefix = "";
        if (intIn.hidden)
        {
            prefix = "Hidden ";
        }
        if (intIn.output == intIn.expectedOutput)
        {
            Console.WriteLine(prefix + "Test passed ;)", Color.Green);
        }
        else
        {
            Console.WriteLine(prefix + "Test failed :/", Color.Red);
        }
        if (intIn.hidden)
        {
            Console.WriteLine("Hidden Test");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Input: " + intIn.input);
            Console.WriteLine("Output: " + intIn.output);
            Console.WriteLine("Expected Output: " + intIn.expectedOutput);
        }
        Console.WriteLine();
        Console.WriteLine("<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//");
        Console.WriteLine();
    }
    public static void TestIntIntInIntOut(IntIntInIntOutTest intintIn)
    {
        string prefix = "";
        if (intintIn.hidden)
        {
            prefix = "Hidden ";
        }
        if (intintIn.output == intintIn.expectedOutput)
        {
            Console.WriteLine(prefix + "Test passed ;)", Color.Green);
        }
        else
        {
            Console.WriteLine(prefix + "Test failed :/", Color.Red);
        }
        if (intintIn.hidden)
        {
            Console.WriteLine("Hidden Test");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Input1: " + intintIn.input1);
            Console.WriteLine("Input2: " + intintIn.input2);
            Console.WriteLine("Output: " + intintIn.output);
            Console.WriteLine("Expected Output: " + intintIn.expectedOutput);
        }
        Console.WriteLine();
        Console.WriteLine("<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//");
        Console.WriteLine();
    }
    public static void TestIntArrayInt(IntArrayIntTest intArray)
    {
        string prefix = "";
        if (intArray.hidden)
        {
            prefix = "Hidden ";
        }
        if (intArray.output == intArray.expectedOutput)
        {
            Console.WriteLine(prefix + "Test passed ;)", Color.Green);
        }
        else
        {
            Console.WriteLine(prefix + "Test failed :/", Color.Red);
        }
        if (intArray.hidden)
        {
            Console.WriteLine("Hidden Test");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Input: ");
            foreach (int i in intArray.input)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Output: " + intArray.output);
            Console.WriteLine("Expected Output: " + intArray.expectedOutput);
        }
        Console.WriteLine();
        Console.WriteLine("<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//");
        Console.WriteLine();
    }
}
public class IntBoolTest
{
    public int input;
    public bool output;
    public bool expectedOutput;
    public bool hidden = false;
}
public class IntInIntOutTest
{
    public int input;
    public int output;
    public int expectedOutput;
    public bool hidden = false;
}
public class IntIntInIntOutTest
{
    public int input1;
    public int input2;
    public int output;
    public int expectedOutput;
    public bool hidden = false;
}
public class StringArrayBoolTest
{
    public string[] input = new string[0];
    public bool output;
    public bool expectedOutput;
    public bool hidden = false;
}
public class IntArrayIntTest
{
    public int[] input = new int[0];
    public int output;
    public int expectedOutput;
    public bool hidden = false;
}


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welche Aufgabe willst du Testen? (1-6)");
        string input = Console.ReadLine();
        Console.Clear();
        switch (input)
        {
            case "1":
                Aufgabe1Test();
                break;
            case "2":
                Aufgabe2Test();
                break;
            case "3":
                Aufgabe3Test();
                break;
            case "4":
                Aufgabe4Test();
                break;
            case "5":
                Aufgabe5Test();
                break;
            case "6":
                Aufgabe6Test();
                break;
            case "7":
                Aufgabe7Test();
                break;
            default:
                Console.WriteLine("Falsche Eingabe");
                break;
        }
        Console.WriteLine("Drücke Enter um einen anderen Test zu starten");
        Console.ReadLine();
        Console.Clear(); 
        Main(null);

    }
    public static void Aufgabe1Test()
    {
        IntInIntOutTest[] AufgabeEinsTests =
        {
            new IntInIntOutTest { input = 1, output = Aufgaben.Aufgabe1(1), expectedOutput = 2, hidden = false },
            new IntInIntOutTest { input = 4, output = Aufgaben.Aufgabe1(4), expectedOutput = 4, hidden = false },
            new IntInIntOutTest { input = -1, output = Aufgaben.Aufgabe1(-1), expectedOutput = 0, hidden = true },
            new IntInIntOutTest { input = 21, output = Aufgaben.Aufgabe1(21), expectedOutput = 22, hidden = false },
            new IntInIntOutTest { input = 420, output = Aufgaben.Aufgabe1(420), expectedOutput = 421, hidden = false }
        };
        foreach (IntInIntOutTest item in AufgabeEinsTests)
        {
            Tester.TestIntInIntOut(item);
        }
    }
    public static void Aufgabe2Test()
    {
        IntIntInIntOutTest[] AufgabeZweiTest =
        {
            new IntIntInIntOutTest { input1 = 1, input2 = 2, output = Aufgaben.Aufgabe2(1,2), expectedOutput = 3, hidden = false },
            new IntIntInIntOutTest { input1 = 4, input2 = 4, output = Aufgaben.Aufgabe2(4,4), expectedOutput = 8, hidden = false },
            new IntIntInIntOutTest { input1 = -1, input2 = 1, output = Aufgaben.Aufgabe2(-1,1), expectedOutput = 0, hidden = true },
            new IntIntInIntOutTest { input1 = 21, input2 = 21, output = Aufgaben.Aufgabe2(21,21), expectedOutput = 42, hidden = false },
            new IntIntInIntOutTest { input1 = 420, input2 = 420, output = Aufgaben.Aufgabe2(420,420), expectedOutput = 840, hidden = false },
            new IntIntInIntOutTest { input1 = 9, input2 = 10, output = Aufgaben.Aufgabe2(9,10), expectedOutput = 19, hidden = false }
        };
    }
    public static void Aufgabe3Test()
    {
        IntArrayIntTest[] Aufgabe3Tests =
        {
            new IntArrayIntTest { input = new int[]{1,2,3,4,5}, output = Aufgaben.Aufgabe3(new int[]{1,2,3,4,5}), expectedOutput = 15, hidden = false },
            new IntArrayIntTest { input = new int[]{4,4,4,4,4}, output = Aufgaben.Aufgabe3(new int[]{4,4,4,4,4}), expectedOutput = 20, hidden = false },
            new IntArrayIntTest { input = new int[]{-1,1,1,1,1}, output = Aufgaben.Aufgabe3(new int[]{-1,1,1,1,1}), expectedOutput = 3, hidden = true },
            new IntArrayIntTest { input = new int[]{21,21,21,21,21}, output = Aufgaben.Aufgabe3(new int[]{21,21,21,21,21}), expectedOutput = 105, hidden = false },
            new IntArrayIntTest { input = new int[]{420,420,420,420,420}, output = Aufgaben.Aufgabe3(new int[]{420,420,420,420,420}), expectedOutput = 2100, hidden = false },
            new IntArrayIntTest { input = new int[]{9,10,11,12,13}, output = Aufgaben.Aufgabe3(new int[]{9,10,11,12,13}), expectedOutput = 55, hidden = false }
        };
        foreach(var item in Aufgabe3Tests)
        {
            Tester.TestIntArrayInt(item);
        }
    }
    public static void Aufgabe4Test()
    {
        IntBoolTest[] AufgabeVierTests = {
                   new IntBoolTest { input = 5, output = Aufgaben.Aufgabe4(5), expectedOutput = false},
                   new IntBoolTest { input = 10, output = Aufgaben.Aufgabe4(10), expectedOutput = false,hidden = true },
                   new IntBoolTest { input = 11, output = Aufgaben.Aufgabe4(11), expectedOutput = true,hidden = true },
                   new IntBoolTest { input = 20, output = Aufgaben.Aufgabe4(20), expectedOutput = true },
                   new IntBoolTest { input = 21, output = Aufgaben.Aufgabe4(21), expectedOutput = true },
               };
        foreach (IntBoolTest item in AufgabeVierTests)
        {
            Tester.TestIntBool(item);
        }
    }
    public static void Aufgabe5Test()
    {
        IntBoolTest[] AufgabeFünfTests = {
                   new IntBoolTest { input = 7, output =  Aufgaben.Aufgabe5(5), expectedOutput = false,hidden = true },
                   new IntBoolTest { input = 11, output = Aufgaben.Aufgabe5(10), expectedOutput = false },
                   new IntBoolTest { input = 10, output = Aufgaben.Aufgabe5(11), expectedOutput = true },
                   new IntBoolTest { input = 20, output = Aufgaben.Aufgabe5(20), expectedOutput = false,hidden = true },
                   new IntBoolTest { input = 24, output = Aufgaben.Aufgabe5(21), expectedOutput = false , hidden = true},
               };
        foreach (IntBoolTest item in AufgabeFünfTests)
        {
            Tester.TestIntBool(item);
        }
    }
    public static void Aufgabe6Test()
    {
        StringArrayBoolTest[] AufgabeSechsTests = {
                   new StringArrayBoolTest { input = new string[]{"Deine Mom", "Dein Opa", "Deine Oma", "Deine Schwester", "Dein Urgroßvater" }, output = Aufgaben.Aufgabe6(new string[]{"Deine Mom", "Dein Opa", "Deine Oma", "Deine Schwester", "Dein Urgroßvater" }), expectedOutput = false,hidden = true },
                   new StringArrayBoolTest { input = new string[]{"Naturensohn", "Hungerlohn", "Downsyndrom", "Mindestlohn", "Wer bist du denn schon" },output = Aufgaben.Aufgabe6(new string[]{"Naturensohn", "Hungerlohn", "Downsyndrom", "Mindestlohn", "Wer bist du denn schon" }), expectedOutput = false },
                   new StringArrayBoolTest { input = new string[]{"Never","Gonna","Give","You","Up","Never","Gonna","Let","You","Down","Hurensohn"}, output = Aufgaben.Aufgabe6(new string[]{"Never","Gonna","Give","You","Up","Never","Gonna","Let","You","Down","Hurensohn"}), expectedOutput = true },
                   new StringArrayBoolTest { input = new string[]{"Photoshop","war","ein","Joke","ich","war","da","nicht","mal","ein","Hurensohn"}, output = Aufgaben.Aufgabe6(new string[]{"Never","Gonna","Give","You","Up","Never","Gonna","Let","You","Down","Hurensohn"}), expectedOutput = true }

               };
        foreach (var item in AufgabeSechsTests)
        {
            Tester.TestStringArrayBool(item);
        }
    }
    public static void Aufgabe7Test()
    {
        IntInIntOutTest[] AufgabeSechsTests =
        {
            new IntInIntOutTest {input = 999, output = Aufgaben.Aufgabe7(999), expectedOutput = 27, hidden = false},
            new IntInIntOutTest {input = 123, output = Aufgaben.Aufgabe7(123), expectedOutput = 6, hidden = false},
            new IntInIntOutTest {input = 420, output = Aufgaben.Aufgabe7(420), expectedOutput = 6, hidden = false},
            new IntInIntOutTest {input = 69, output = Aufgaben.Aufgabe7(69), expectedOutput = 15, hidden = true},
            new IntInIntOutTest {input = 666, output = Aufgaben.Aufgabe7(666), expectedOutput = 18, hidden = true},
        };
    }
    

}