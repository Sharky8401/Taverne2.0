using System;

public class Waffe
{
    public String WName;
    public int WSchaden;
    public bool Schadensart;
    public bool Staerkeeinfluss;

    public Waffe(String pWName, int pWSchaden, bool pSchadensart, bool pStaerkeeinfluss)
    {
        WName = pWName;
        WSchaden = pWSchaden;
        Schadensart = pSchadensart;
        Staerkeeinfluss = pStaerkeeinfluss;
    }
}
