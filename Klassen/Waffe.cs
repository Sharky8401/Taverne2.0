using System;

//Waffe ist eine Klasse für Angriffsmöglichkeiten eines Spielers - also hauptsächlich Waffen, aber auch Fähigkeiten, Zauber usw.

public class Waffe
{
    public String WName; //Name der Waffe
    public int WSchaden; //(Grund-)Schaden der Waffe
    public bool Schadensart; //Normaler Schaden (True - Ruestung zählt) und RuA (False - Schaden ist Ruestungsunabhaengig)
    public bool Staerkeeinfluss;

    public Waffe(String pWName, int pWSchaden, bool pSchadensart, bool pStaerkeeinfluss)
    {
        WName = pWName;
        WSchaden = pWSchaden;
        Schadensart = pSchadensart;
        Staerkeeinfluss = pStaerkeeinfluss;
    }
}
