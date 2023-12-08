using System.Drawing;


public class Tester
{ 
    public static void Test<I, O>(TestInfo<I, O> testInfo)
    {
        string prefix = testInfo.hidden ? "Hidden " : "";

        if (EqualityComparer<O>.Default.Equals(testInfo.output, testInfo.expectedOutput))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{prefix}Test passed ;)");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{prefix}Test failed :/");
        }
        Console.ResetColor();

        if (!testInfo.hidden)
        {
            Console.WriteLine("Input: " + (testInfo.input is IEnumerable<I> enumerableInput ? string.Join(", ", enumerableInput) : testInfo.input.ToString()));
            Console.WriteLine($"Output: {testInfo.output}");
            Console.WriteLine($"Expected Output: {testInfo.expectedOutput}");
        }
        else
        {
            Console.WriteLine("Hidden Test");
        }

        Console.WriteLine();
        Console.WriteLine("<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//");
        Console.WriteLine();
    }
    public static void Test<I1, I2, O>(TestInfo<I1, I2, O> testInfo)
    {
        string prefix = testInfo.hidden ? "Hidden " : "";

        if (EqualityComparer<O>.Default.Equals(testInfo.output, testInfo.expectedOutput))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{prefix}Test passed ;)");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{prefix}Test failed :/");
        }
        Console.ResetColor();

        if (!testInfo.hidden)
        {
            Console.WriteLine("Input 1: " + (testInfo.input1 is IEnumerable<I1> enumerableInput1 ? string.Join(", ", enumerableInput1) : testInfo.input1.ToString()));
            Console.WriteLine("Input 2: " + (testInfo.input2 is IEnumerable<I2> enumerableInput2 ? string.Join(", ", enumerableInput2) : testInfo.input2.ToString()));
            Console.WriteLine($"Output: {testInfo.output}");
            Console.WriteLine($"Expected Output: {testInfo.expectedOutput}");
        }
        else
        {
            Console.WriteLine("Hidden Test");
        }

        Console.WriteLine();
        Console.WriteLine("<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//<>//");
        Console.WriteLine();
    }
}
public class TestInfo<I, O>
{
    public bool hidden;
    public I input;
    public O output;
    public O expectedOutput;
}
public class TestInfo<I1, I2, O>
{
    public bool hidden;
    public I1 input1;
    public I2 input2;
    public O output;
    public O expectedOutput;
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welche Aufgabe willst du Testen? (1-16)");
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
            case "8":
                Aufgabe8Test();
                break;
            case "9":
                Aufgabe9Test();
                break;
            case "10":
                Aufgabe10Test();
                break;
            case "11":
                Aufgabe11Test();
                break;
            case "12":
                Aufgabe12Test();
                break;
            case "13":
                Aufgabe13Test();
                break;
            case "14":
                Aufgabe14Test();
                break;
            case "15":
                Aufgabe15Test();
                break;
            case "16":
                Aufgabe16Test();
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
        TestInfo<int, int>[] AufgabeEinsTests =
         {
            new TestInfo<int,int> { input = 1, output = Aufgaben.Aufgabe1(1), expectedOutput = 2, hidden = false },
            new TestInfo<int, int> { input = 4, output = Aufgaben.Aufgabe1(4), expectedOutput = 5, hidden = false },
            new TestInfo<int, int> { input = -1, output = Aufgaben.Aufgabe1(-1), expectedOutput = 0, hidden = true },
            new TestInfo<int, int> { input = 21, output = Aufgaben.Aufgabe1(21), expectedOutput = 22, hidden = false },
            new TestInfo<int, int> { input = 420, output = Aufgaben.Aufgabe1(420), expectedOutput = 421, hidden = false }
        };
        foreach (TestInfo<int, int> item in AufgabeEinsTests)
        {
            Tester.Test<int, int>(item);
        }
    }
    public static void Aufgabe2Test()
    {
        TestInfo<int, int, int>[] AufgabeZweiTest =
        {
            new TestInfo<int,int,int> { input1 = 1, input2 = 2, output = Aufgaben.Aufgabe2(1,2), expectedOutput = 3, hidden = false },
            new TestInfo<int,int,int> { input1 = 4, input2 = 4, output = Aufgaben.Aufgabe2(4,4), expectedOutput = 8, hidden = false },
            new TestInfo<int,int,int> { input1 = -1, input2 = 1, output = Aufgaben.Aufgabe2(-1,1), expectedOutput = 0, hidden = true },
            new TestInfo<int,int,int> { input1 = 21, input2 = 21, output = Aufgaben.Aufgabe2(21,21), expectedOutput = 42, hidden = false },
            new TestInfo<int,int,int> { input1 = 420, input2 = 420, output = Aufgaben.Aufgabe2(420,420), expectedOutput = 840, hidden = false },
            new TestInfo<int,int,int> { input1 = 9, input2 = 10, output = Aufgaben.Aufgabe2(9,10), expectedOutput = 19, hidden = false }
        };
        foreach (TestInfo<int, int, int> item in AufgabeZweiTest)
        {
            Tester.Test<int, int, int>(item);
        }
    }
    public static void Aufgabe3Test()
    {
        TestInfo<int[], int>[] Aufgabe3Tests =
        {
            new TestInfo<int[],int> { input = new int[]{1,2,3,4,5}, output = Aufgaben.Aufgabe3(new int[]{1,2,3,4,5}), expectedOutput = 15, hidden = false },
            new TestInfo<int[],int> { input = new int[]{4,4,4,4,4}, output = Aufgaben.Aufgabe3(new int[]{4,4,4,4,4}), expectedOutput = 20, hidden = false },
            new TestInfo<int[],int> { input = new int[]{-1,1,1,1,1}, output = Aufgaben.Aufgabe3(new int[]{-1,1,1,1,1}), expectedOutput = 3, hidden = true },
            new TestInfo<int[],int> { input = new int[]{21,21,21,21,21}, output = Aufgaben.Aufgabe3(new int[]{21,21,21,21,21}), expectedOutput = 105, hidden = false },
            new TestInfo<int[],int> { input = new int[]{420,420,420,420,420}, output = Aufgaben.Aufgabe3(new int[]{420,420,420,420,420}), expectedOutput = 2100, hidden = false },
            new TestInfo<int[],int> { input = new int[]{9,10,11,12,13}, output = Aufgaben.Aufgabe3(new int[]{9,10,11,12,13}), expectedOutput = 55, hidden = false }
        };
        foreach (var item in Aufgabe3Tests)
        {
            Tester.Test<int[], int>(item);
        }
    }
    public static void Aufgabe4Test()
    {
        TestInfo<int, bool>[] AufgabeVierTests = {
                   new TestInfo<int,bool> { input = 5, output = Aufgaben.Aufgabe4(5), expectedOutput = false},
                   new TestInfo<int,bool> { input = 10, output = Aufgaben.Aufgabe4(10), expectedOutput = false,hidden = true },
                   new TestInfo<int,bool> { input = 11, output = Aufgaben.Aufgabe4(11), expectedOutput = true,hidden = true },
                   new TestInfo<int,bool> { input = 20, output = Aufgaben.Aufgabe4(20), expectedOutput = true },
                   new TestInfo<int,bool> { input = 21, output = Aufgaben.Aufgabe4(21), expectedOutput = true },
               };
        foreach (var item in AufgabeVierTests)
        {
            Tester.Test<int, bool>(item);
        }
    }
    public static void Aufgabe5Test()
    {
        TestInfo<int, bool>[] AufgabeFünfTests = {
                   new TestInfo<int,bool> { input = 7, output =  Aufgaben.Aufgabe5(5), expectedOutput = false,hidden = true },
                   new TestInfo<int,bool> { input = 11, output = Aufgaben.Aufgabe5(10), expectedOutput = false },
                   new TestInfo<int,bool> { input = 10, output = Aufgaben.Aufgabe5(11), expectedOutput = true },
                   new TestInfo<int,bool> { input = 20, output = Aufgaben.Aufgabe5(20), expectedOutput = false,hidden = true },
                   new TestInfo<int,bool> { input = 24, output = Aufgaben.Aufgabe5(21), expectedOutput = false , hidden = true},
               };
        foreach (var item in AufgabeFünfTests)
        {
            Tester.Test<int, bool>(item);
        }
    }
    public static void Aufgabe6Test()
    {
        TestInfo<string[], bool>[] AufgabeSechsTests = {
                   new TestInfo<string[],bool> { input = new string[]{"Deine Mom", "Dein Opa", "Deine Oma", "Deine Schwester", "Dein Urgroßvater" }, output = Aufgaben.Aufgabe6(new string[]{"Deine Mom", "Dein Opa", "Deine Oma", "Deine Schwester", "Dein Urgroßvater" }), expectedOutput = false,hidden = true },
                   new TestInfo<string[],bool> { input = new string[]{"Naturensohn", "Hungerlohn", "Downsyndrom", "Mindestlohn", "Wer bist du denn schon" },output = Aufgaben.Aufgabe6(new string[]{"Naturensohn", "Hungerlohn", "Downsyndrom", "Mindestlohn", "Wer bist du denn schon" }), expectedOutput = false },
                   new TestInfo<string[],bool> { input = new string[]{"Never","Gonna","Give","You","Up","Never","Gonna","Let","You","Down","Hurensohn"}, output = Aufgaben.Aufgabe6(new string[]{"Never","Gonna","Give","You","Up","Never","Gonna","Let","You","Down","Hurensohn"}), expectedOutput = true },
                   new TestInfo<string[],bool> { input = new string[]{"Photoshop","war","ein","Joke","ich","war","da","nicht","mal","ein","Hurensohn"}, output = Aufgaben.Aufgabe6(new string[]{"Never","Gonna","Give","You","Up","Never","Gonna","Let","You","Down","Hurensohn"}), expectedOutput = true }

               };
        foreach (var item in AufgabeSechsTests)
        {
            Tester.Test<string[], bool>(item);
        }
    }
    public static void Aufgabe7Test()
    {
        TestInfo<int, int>[] AufgabeSechsTests =
        {
            new TestInfo<int,int> {input = 999, output = Aufgaben.Aufgabe7(999), expectedOutput = 27, hidden = false},
            new TestInfo<int,int> {input = 123, output = Aufgaben.Aufgabe7(123), expectedOutput = 6, hidden = false},
            new TestInfo<int,int> {input = 420, output = Aufgaben.Aufgabe7(420), expectedOutput = 6, hidden = false},
            new TestInfo<int,int> {input = 69, output = Aufgaben.Aufgabe7(69), expectedOutput = 15, hidden = true},
            new TestInfo<int,int> {input = 666, output = Aufgaben.Aufgabe7(666), expectedOutput = 18, hidden = true},
        };
        foreach (var item in AufgabeSechsTests)
        {
            Tester.Test<int, int>(item);
        }
    }
    public static void Aufgabe8Test()
    {
        TestInfo<double[], double>[] testInfo =
        {
            new TestInfo<double[],double> {input = new double[]{1,2,3,4,5}, output = Aufgaben.Aufgabe8(new double[]{1,2,3,4,5}), expectedOutput = 3, hidden = false},
            new TestInfo<double[],double> {input = new double[]{4,4,4,4,4}, output = Aufgaben.Aufgabe8(new double[]{4,4,4,4,4}), expectedOutput = 4, hidden = false},
            new TestInfo<double[],double> {input = new double[]{-1,1,1,1,1}, output = Aufgaben.Aufgabe8(new double[]{-1,1,1,1,1}), expectedOutput = 0.6, hidden = true},
            new TestInfo<double[],double> {input = new double[]{21,21,21,21,21}, output = Aufgaben.Aufgabe8(new double[]{21,21,21,21,21}), expectedOutput = 21, hidden = false},
            new TestInfo<double[],double> {input = new double[]{420,420,420,420,420}, output = Aufgaben.Aufgabe8(new double[]{420,420,420,420,420}), expectedOutput = 420, hidden = false},
            new TestInfo<double[],double> {input = new double[]{9,10,11,12,13}, output = Aufgaben.Aufgabe8(new double[]{9,10,11,12,13}), expectedOutput = 11, hidden = false}
        };
        foreach (var item in testInfo)
        {
            Tester.Test<double[], double>(item);
        }
    }
    public static void Aufgabe9Test()
    {
        // Aufgabe 9
        // Schreibe ein Programm, das prüft, ob ein übergebener Text (string) das Wort "Programmieren" enthält.
        TestInfo<string, bool>[] testInfo = {

            new TestInfo<string, bool> {input = "Hallo", output = Aufgaben.Aufgabe9("Hallo"), expectedOutput = false, hidden = false},
            new TestInfo<string, bool> {input = "Programmieren", output = Aufgaben.Aufgabe9("Programmieren"), expectedOutput = true, hidden = false},
            new TestInfo<string, bool> {input = "Programmieren ist toll", output = Aufgaben.Aufgabe9("Programmieren ist toll"), expectedOutput = true, hidden = false},
            new TestInfo<string, bool> {input = "Ich liebe Programmieren", output = Aufgaben.Aufgabe9("Ich liebe Programmieren"), expectedOutput = true, hidden = false},
            new TestInfo<string, bool> {input = "Das hast du toll programmiert", output = Aufgaben.Aufgabe9("Das hast du toll programmiert"), expectedOutput = false, hidden = false},
            new TestInfo<string, bool> {input = "Programmieren ist ein tolles Hobby", output = Aufgaben.Aufgabe9("Programmieren ist ein tolles Hobby"), expectedOutput = true, hidden = false},
            new TestInfo<string, bool> {input = "dfsffsdlöfjksd fsfhsfkuhfgjkhfjdkgProgrammierenhdskfhjdsfksdhufhdsifhuiheiwhfjksdfsd", output = Aufgaben.Aufgabe9("dfsffsdlöfjksd fsfhsfkuhfgjkhfjdkgProgrammierenhdskfhjdsfksdhufhdsifhuiheiwhfjksdfsd"), expectedOutput = true, hidden = false}

        };
        foreach (var item in testInfo)
        {
            Tester.Test<string, bool>(item);
        }
    }
    public static void Aufgabe10Test()
    {
        TestInfo<int, bool>[] testInfo =
        {
            new TestInfo<int, bool> {input = 1, output = Aufgaben.Aufgabe10(1), expectedOutput = true, hidden = false},
            new TestInfo<int, bool> {input = 2, output = Aufgaben.Aufgabe10(2), expectedOutput = true, hidden = false},
            new TestInfo<int, bool> {input = 3, output = Aufgaben.Aufgabe10(3), expectedOutput = true, hidden = false},
            new TestInfo<int, bool> {input = 4, output = Aufgaben.Aufgabe10(4), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 5, output = Aufgaben.Aufgabe10(5), expectedOutput = true, hidden = false},
            new TestInfo<int, bool> {input = 6, output = Aufgaben.Aufgabe10(6), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 7, output = Aufgaben.Aufgabe10(7), expectedOutput = true, hidden = false},
            new TestInfo<int, bool> {input = 8, output = Aufgaben.Aufgabe10(8), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 9, output = Aufgaben.Aufgabe10(9), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 10, output = Aufgaben.Aufgabe10(10), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 11, output = Aufgaben.Aufgabe10(11), expectedOutput = true, hidden = false},
            new TestInfo<int, bool> {input = 12, output = Aufgaben.Aufgabe10(12), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 13, output = Aufgaben.Aufgabe10(13), expectedOutput = true, hidden = false},
            new TestInfo<int, bool> {input = 14, output = Aufgaben.Aufgabe10(14), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 4212, output = Aufgaben.Aufgabe10(4212), expectedOutput = false, hidden = false},
            new TestInfo<int, bool> {input = 23297, output = Aufgaben.Aufgabe10(23297), expectedOutput = true, hidden = true},
        };
        foreach (var item in testInfo)
        {
            Tester.Test<int, bool>(item);
        }
    }
    public static void Aufgabe11Test()
    {
        TestInfo<int, int>[] testInfo =
        {
            new TestInfo<int, int> { input = 1, output = Aufgaben.Aufgabe11(1), expectedOutput = 1, hidden = false },
            new TestInfo<int, int> { input = 2, output = Aufgaben.Aufgabe11(2), expectedOutput = 2, hidden = false },
            new TestInfo<int, int> { input = 3, output = Aufgaben.Aufgabe11(3), expectedOutput = 6, hidden = false },
            new TestInfo<int, int> { input = 4, output = Aufgaben.Aufgabe11(4), expectedOutput = 24, hidden = false },
            new TestInfo<int, int> { input = 5, output = Aufgaben.Aufgabe11(5), expectedOutput = 120, hidden = false },
            new TestInfo<int, int> { input = 6, output = Aufgaben.Aufgabe11(6), expectedOutput = 720, hidden = false },
            new TestInfo<int, int> { input = 7, output = Aufgaben.Aufgabe11(7), expectedOutput = 5040, hidden = false },
            new TestInfo<int, int> { input = 8, output = Aufgaben.Aufgabe11(8), expectedOutput = 40320, hidden = false },
            new TestInfo<int, int> { input = 9, output = Aufgaben.Aufgabe11(9), expectedOutput = 362880, hidden = false },
            new TestInfo<int, int> { input = 10, output = Aufgaben.Aufgabe11(10), expectedOutput = 3628800, hidden = false },
            new TestInfo<int, int> { input = 11, output = Aufgaben.Aufgabe11(11), expectedOutput = 39916800, hidden = false },
            new TestInfo<int, int> { input = 12, output = Aufgaben.Aufgabe11(12), expectedOutput = 479001600, hidden = false }
        };
        foreach(var item in testInfo)
        {
              Tester.Test<int, int>(item); 
        }

    }
    public static void Aufgabe12Test()
    {
        TestInfo<int, int[]>[] testInfo =
        {
            new TestInfo<int, int[]> { input = 0, output = Aufgaben.Aufgabe12(0), expectedOutput = new int[] { 0 }, hidden = false },
            new TestInfo<int, int[]> { input = 1, output = Aufgaben.Aufgabe12(1), expectedOutput = new int[] { 0, 1 }, hidden = false },
            new TestInfo<int, int[]> { input = 2, output = Aufgaben.Aufgabe12(2), expectedOutput = new int[] { 0, 1, 1 }, hidden = false },
            new TestInfo<int, int[]> { input = 3, output = Aufgaben.Aufgabe12(3), expectedOutput = new int[] { 0, 1, 1, 2 }, hidden = false },
            new TestInfo<int, int[]> { input = 4, output = Aufgaben.Aufgabe12(4), expectedOutput = new int[] { 0, 1, 1, 2, 3 }, hidden = false },
            new TestInfo<int, int[]> { input = 5, output = Aufgaben.Aufgabe12(5), expectedOutput = new int[] { 0, 1, 1, 2, 3, 5 }, hidden = false },
            new TestInfo<int, int[]> { input = 6, output = Aufgaben.Aufgabe12(6), expectedOutput = new int[] { 0, 1, 1, 2, 3, 5, 8 }, hidden = false },
            new TestInfo<int, int[]> { input = 7, output = Aufgaben.Aufgabe12(7), expectedOutput = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 }, hidden = false },
            new TestInfo<int, int[]> { input = 8, output = Aufgaben.Aufgabe12(8), expectedOutput = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 }, hidden = false },
            new TestInfo<int, int[]> { input = 9, output = Aufgaben.Aufgabe12(9), expectedOutput = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, hidden = false }

        };
        foreach (var item in testInfo)
        {
            Tester.Test<int, int[]>(item);
        }
    }
    public static void Aufgabe13Test()
    {
        TestInfo<int[], int>[] testInfo =
        {
            new TestInfo<int[], int> { input = new int[] { 1, 2, 3, 4, 5 }, output = Aufgaben.Aufgabe13(new int[] { 1, 2, 3, 4, 5 }), expectedOutput = 5, hidden = false },
            new TestInfo<int[], int> { input = new int[] { 4, 4, 4, 4, 4 }, output = Aufgaben.Aufgabe13(new int[] { 4, 4, 4, 4, 4 }), expectedOutput = 4, hidden = false },
            new TestInfo<int[], int> { input = new int[] { -1, 1, 1, 1, 1 }, output = Aufgaben.Aufgabe13(new int[] { -1, 1, 1, 1, 1 }), expectedOutput = 1, hidden = true },
            new TestInfo<int[], int> { input = new int[] { 21, 21, 21, 21, 21 }, output = Aufgaben.Aufgabe13(new int[] { 21, 21, 21, 21, 21 }), expectedOutput = 21, hidden = false },
            new TestInfo<int[], int> { input = new int[] { 420, 420, 420, 420, 420 }, output = Aufgaben.Aufgabe13(new int[] { 420, 420, 420, 420, 420 }), expectedOutput = 420, hidden = false },
            new TestInfo<int[], int> { input = new int[] { 9, 10, 11, 12, 13 }, output = Aufgaben.Aufgabe13(new int[] { 9, 10, 11, 12, 13 }), expectedOutput = 13, hidden = false }
        };
        foreach (var item in testInfo)
        {
            Tester.Test<int[], int>(item);
        }
    }
    public static void Aufgabe14Test()
    {
        TestInfo<int[], int>[] testInfo =
        {
            new TestInfo<int[], int> { input = new int[] { 1, 2, 3, 4, 5 }, output = Aufgaben.Aufgabe14(new int[] { 1, 2, 3, 4, 5 }), expectedOutput = 1, hidden = false },
            new TestInfo<int[], int> { input = new int[] { 4, 4, 4, 4, 4 }, output = Aufgaben.Aufgabe14(new int[] { 4, 4, 4, 4, 4 }), expectedOutput = 4, hidden = false },
            new TestInfo<int[], int> { input = new int[] { -1, 1, 1, 1, 1 }, output = Aufgaben.Aufgabe14(new int[] { -1, 1, 1, 1, 1 }), expectedOutput = -1, hidden = true },
            new TestInfo<int[], int> { input = new int[] { 21, 21, 21, 21, 21 }, output = Aufgaben.Aufgabe14(new int[] { 21, 21, 21, 21, 21 }), expectedOutput = 21, hidden = false },
            new TestInfo<int[], int> { input = new int[] { 420, 420, 420, 420, 420 }, output = Aufgaben.Aufgabe14(new int[] { 420, 420, 420, 420, 420 }), expectedOutput = 420, hidden = false },
            new TestInfo<int[], int> { input = new int[] { 9, 10, 11, 12, 13 }, output = Aufgaben.Aufgabe14(new int[] { 9, 10, 11, 12, 13 }), expectedOutput = 9, hidden = false }
        };
        foreach (var item in testInfo)
        {
            Tester.Test<int[], int>(item);
        }
    }
    public static void Aufgabe15Test()
    {
        TestInfo<int, int>[] testInfo =
        {
            new TestInfo<int, int> { input = 1, output = Aufgaben.Aufgabe15(1), expectedOutput = 1, hidden = false },
            new TestInfo<int, int> { input = 2, output = Aufgaben.Aufgabe15(2), expectedOutput = 3, hidden = false },
            new TestInfo<int, int> { input = 3, output = Aufgaben.Aufgabe15(3), expectedOutput = 6, hidden = false },
            new TestInfo<int, int> { input = 4, output = Aufgaben.Aufgabe15(4), expectedOutput = 10, hidden = false },
            new TestInfo<int, int> { input = 5, output = Aufgaben.Aufgabe15(5), expectedOutput = 15, hidden = false },
            new TestInfo<int, int> { input = 6, output = Aufgaben.Aufgabe15(6), expectedOutput = 21, hidden = false },
            new TestInfo<int, int> { input = 7, output = Aufgaben.Aufgabe15(7), expectedOutput = 28, hidden = false },
            new TestInfo<int, int> { input = 8, output = Aufgaben.Aufgabe15(8), expectedOutput = 36, hidden = false },
            new TestInfo<int, int> { input = 9, output = Aufgaben.Aufgabe15(9), expectedOutput = 45, hidden = false },
            new TestInfo<int, int> { input = 10, output = Aufgaben.Aufgabe15(10), expectedOutput = 55, hidden = false },
            new TestInfo<int, int> { input = 11, output = Aufgaben.Aufgabe15(11), expectedOutput = 66, hidden = false },
            new TestInfo<int, int> { input = 12, output = Aufgaben.Aufgabe15(12), expectedOutput = 78, hidden = false },
            new TestInfo<int, int> { input = 13, output = Aufgaben.Aufgabe15(13), expectedOutput = 91, hidden = false }

        };
        foreach(var item in testInfo)
        {
            Tester.Test<int, int>(item);
        }
    }
    public static void Aufgabe16Test()
    {
        TestInfo<int, int>[] testInfo =
        {
            new TestInfo<int, int> { input = 1, output = Aufgaben.Aufgabe16(1), expectedOutput = 1, hidden = false },
            new TestInfo<int, int> { input = 2, output = Aufgaben.Aufgabe16(2), expectedOutput = 3, hidden = false },
            new TestInfo<int, int> { input = 3, output = Aufgaben.Aufgabe16(3), expectedOutput = 6, hidden = false },
            new TestInfo<int, int> { input = 4, output = Aufgaben.Aufgabe16(4), expectedOutput = 10, hidden = false },
            new TestInfo<int, int> { input = 5, output = Aufgaben.Aufgabe16(5), expectedOutput = 15, hidden = false },
            new TestInfo<int, int> { input = 6, output = Aufgaben.Aufgabe16(6), expectedOutput = 21, hidden = false },
            new TestInfo<int, int> { input = 7, output = Aufgaben.Aufgabe16(7), expectedOutput = 28, hidden = false },
            new TestInfo<int, int> { input = 8, output = Aufgaben.Aufgabe16(8), expectedOutput = 36, hidden = false },
            new TestInfo<int, int> { input = 9, output = Aufgaben.Aufgabe16(9), expectedOutput = 45, hidden = false },
            new TestInfo<int, int> { input = 10, output = Aufgaben.Aufgabe16(10), expectedOutput = 55, hidden = false },
            new TestInfo<int, int> { input = 11, output = Aufgaben.Aufgabe16(11), expectedOutput = 66, hidden = false },
            new TestInfo<int, int> { input = 12, output = Aufgaben.Aufgabe16(12), expectedOutput = 78, hidden = false },
            new TestInfo<int, int> { input = 13, output = Aufgaben.Aufgabe16(13), expectedOutput = 91, hidden = false }
        };
        foreach(var item in testInfo)
        {
            Tester.Test<int, int>(item);
        }
    }
}