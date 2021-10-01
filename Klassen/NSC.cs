using System;

public class NSC : Person
{
    /*
    Ein NSC (Nicht Spieler Charakter) erbt von Person und enthält Lebenspunkte, Werte und Erfahrungspunkte
    */
    public int Max_LP { get; set; }
    public int Mom_LP { get; set; }
    public int Staerke { get; set; }
    public int Geschick { get; set; }
    public int Ki { get; set; }
    public int Xp { get; set; }

    /*
    NSC muss mit Max LP, Stärke, Geschick und KI erstellt werden
    */
    public NSC(string pCName, int pLevel, int pDefR, int DefH, int DefS, int pMax_LP, int pStaerke, int pGeschick, int pKI)
    {
        CName = pName;
        Level = pLevel;
        DefR = pDefR;
        DefH = pDefH;
        DefS = pDefS;
        Max_LP = pMax_LP;
        Mom_LP = pMax_LP;
        Staerke = pStaerke;
        Geschick = pGeschick;
        Ki = pKI;
        Xp = 0;
    }

    /*
    LP Funktionen heilen und schaden
    */
    public void heilen(int pAnzahl)
    {
        if(Mom_LP + pAnzahl > Max_LP)
        {
            Mom_LP = Max_LP;
        }
        else
        {
            Mom_LP += pAnzahl;
        }
    }

    public void schaden(int pAnzahl)
    {
        if(Mom_LP - pAnzahl < 0)
        {
            Mom_LP = 0;
        }
        else
        {
            Mom_LP -= pAnzahl;
        }
    }
}