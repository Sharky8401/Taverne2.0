using System;
using System.Collections.Generic;

public abstract class Person
{
    private String CName { get; set; }
    private int Level { get; set; }
    private List<Waffe> Waffen; //Liste an Waffen
    private int aktuelleWaffe { get; set; } = 0; //Index der Waffe in der Liste der Waffen
    private int DefR { get; set; } = 1; //Rüstungswerte (R = (Körper-)Rüstung,
    private int DefH { get; set; } = 1; //H = Helm
    private int DefS { get; set; } //S = Schild

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
