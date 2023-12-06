using System;
/*
    //DatenTypen
    int ganzeZahl = 5;
    double kommaZahl = 5.5;
    string text = "Hallo Welt";
    bool wahrheitswert = true;
    char zeichen = 'a';
    float kommaZahl2 = 5.5f;

     //Ausgabe
    Console.WriteLine("Hallo Welt");  --> Hallo Welt mit Zeilenumbruch
    Console.Write("Hallo Welt"); --> Hallo Welt ohne Zeilenumbruch
    Console.WriteLine("Hallo Welt" + "Hallo Welt"); --> Hallo WeltHallo Welt (Kombination von Strings)
    Console.WriteLine("Hallo Welt" + 5); --> Hallo Welt5 (Kombination von String und Zahl)


     //Eingabe
    Console.ReadLine(); --> Wartet auf Eingabe und speichert diese in einer Variable

    string text = Console.ReadLine(); --> Speichert die Eingabe in der Variable text

    int zahl = Convert.ToInt32(Console.ReadLine()); --> Wandelt die Eingabe in eine Zahl um

     //Rechnen
    int zahl1 = 5;
    int zahl2 = 10;

    int ergebnis = zahl1 + zahl2; --> 15 (Addition)
    int ergebnis = zahl1 - zahl2; --> -5 (Subtraktion)
    int ergebnis = zahl1 * zahl2; --> 50 (Multiplikation)
    int ergebnis = zahl1 / zahl2; --> 0 (Division)
    int ergebnis = zahl1 % zahl2; --> 5 (Modulo)


     //Bedingungen
    if(zahl1 == zahl2) --> Prüft ob zahl1 gleich zahl2 ist
    if(zahl1 != zahl2) --> Prüft ob zahl1 ungleich zahl2 ist
    if(zahl1 > zahl2) --> Prüft ob zahl1 größer zahl2 ist
    if(zahl1 < zahl2) --> Prüft ob zahl1 kleiner zahl2 ist


     //Schleifen
    for(int i = 0; i < 10; i++) --> Zählt von 0 bis 9
    for(int i = 10; i > 0; i--) --> Zählt von 10 bis 1
    for(int i = 0; i < 10; i+=2) --> Zählt von 0 bis 9 in 2er Schritten

    while(zahl1 < zahl2) --> Wiederholt den Code solange zahl1 kleiner zahl2 ist

    do{ }while(zahl1 < zahl2) --> Wiederholt den Code solange zahl1 kleiner zahl2 ist, mindestens einmal

    foreach(int zahl in zahlen) --> Wiederholt den Code für jedes Element in zahlen

    //Methoden
    public static void MeineMethode() --> Methode ohne Rückgabewert
    public static int MeineMethode() --> Methode mit Rückgabewert
    public static int MeineMethode(int zahl) --> Methode mit Rückgabewert und Parameter
    public static void MeineMethode(int zahl) --> Methode ohne Rückgabewert und mit Parameter
    public static void MeineMethode(int zahl, string text) --> Methode ohne Rückgabewert und mit mehreren Parametern

    //Nutzen von Methoden
    MeineMethode(); --> Aufruf der Methode
    int ergebnis = MeineMethode(); --> Aufruf der Methode und speichern des Rückgabewertes in der Variable ergebnis
    MeineMethode(5); --> Aufruf der Methode mit Parameter
    MeineMethode(5, "Hallo Welt"); --> Aufruf der Methode mit mehreren Parametern
     */



//Achte bei den Aufgaben darauf, dass die Methoden einen "Returntype" erwarten. Wenn du glaubst du hast den richtigen und gefragten Wert in einer Variabel
//gespeichert, Gib sie mit "return {variabelname} zurück. Den Rückgabe Typen findest du in der Deklarierung der Methode
//Beispiel:
//          RückgabeTyp     Parameter
//               |              |
//public static int Aufgabe1(int n){
//
//Also kannt du hier auf den Parameter int n zugreifen, der gegeben ist und
//Du musst einen int mit return {variabelname für ein int}; zurückgegeben.
class Aufgaben
{
    //Schreibe ein Program, dass den eingebenen Parameter 'n' um +1 erhöht und dann wieder ausgibt
    public static int Aufgabe1(int n)
    {
        return 0;
    }
    //Schreibe ein Programm, das die beiden eingegebenen Paramater 'a' und 'b' addiert und die summe dann wieder ausgibt
    public static int Aufgabe2(int a, int b)
    {
        return 0;
    }
    //Schreibe ein Programm, dass alle int Zahlenwerte in dem eingegebenen int array parameter zusammen addiert und dann die summe wieder ausgibt
    public static int Aufgabe3(int[] a)
    {
        return 0;
    }
    public static bool Aufgabe4(int zahl)
    {
        bool wahrheitswert = false;
        return wahrheitswert; //Gib hier den Wahrheitswert zurück
    }
    //Aufgabe 5
    //Schreibe ein Programm, welches einen Wahrheitswert zurückgibt, der wahr ist wenn die Zahl größer als 10 ist und kleiner als 20.
    //Benutze dafür nur ein if statement
    public static bool Aufgabe5(int zahl)
    {
        bool wahrheitswert = false;
        return wahrheitswert; //Gib hier den Wahrheitswert zurück
    }
    //Aufgabe 6
    //Schreibe ein Programm, welches einen Wahrheitswert zurückgibt,der wahr ist wenn in dem String Array das Wort "Hurensohn" enthalten ist.
    public static bool Aufgabe6(string[] array)
    {
        bool wahrheitswert = false;
        return wahrheitswert; //Gib hier den Wahrheitswert zurück
    }
    //Aufgabe 7
    //Schreibe ein Programm, welches die Quersumme der gegeben Zahl zurückgibt
    public static int Aufgabe7(int zahl)
    {
        return 0;
    }
}

