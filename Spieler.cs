using System;
public class Spieler : Person
{
    public int Staerkebonus { get; set; }

    //Sachen, die noch nicht da sind (Charakter hat keinen Helm oder so), können einfach ausgelassen werden, also (...Rüstung, ,Schild)
    public Spieler(String pCName, int pLevel, Waffe pWaffe, int pDefR, int pDefH, int pDefS)
    {
        CName = pCName;
        Level = pLevel;
        Waffen.Add(pWaffe);
        DefR = pDefR;
        DefH = pDefH;
        DefS = pDefS;
    }
}