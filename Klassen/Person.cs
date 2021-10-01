using System;
using System.Collections.Generic;

public abstract class Person
{
    public String CName { get; set; }
    public int Level { get; set; } = 0;
    public List<Waffe> Waffen; //Liste an Waffen
    public int aktuelleWaffe { get; set; } = 0;//Index der Waffe in der Liste der Waffen
    public int DefR { get; set; } = 1;//Rüstungswerte (R = (Körper-)Rüstung,
    public int DefH { get; set; } = 1;//H = Helm
    public int DefS { get; set; } //S = Schild

    public void erhoeheLevel()
    {
        Level++;
    }

    public void reduziereLevel()
    {
        Level--;
    }

    public void waffeHinzufuegen(Waffe pWaffe)
    {
        Waffen.Add(pWaffe);
    }

    public void waffeEntfernen(int pIndex)
    {
        Waffen.Remove(Waffen[pIndex]);
    }

    public void waffeSetzen(int pIndex)
    {
        aktuelleWaffe = pIndex;
    }

    public List<Waffe> getWaffenliste()
    {
        return Waffen;
    }
}
