using System;
using System.Collections.Generic;

public class Wuerfel{
	/*
	Würfel, der mit einer Seitenanzahl erzeugt werden muss, und optional eine untere Grenze definieren kann (Standard 1).
	Attribute sind nur lesbar nicht beschreibbar.
	Kann einmal oder mehrmals gewürfelt werden.
	*/
	
	private int _seiten;
	private int _untere_Grenze=1;

	public Wuerfel(int pSeiten){
		_seiten=pSeiten;
	}
	public Wuerfel(int pUntere_Grenze,int pSeiten){
		_seiten=pSeiten;
		_untere_Grenze=pUntere_Grenze;
	}

	public int Seiten{
		get {return _seiten;}
	}
	public int Untere_Grenze{
		get {return _untere_Grenze;}
	}
	
	/*
	wuerfeln kann ohne Parameter aufgerufen werden und returned einen Integer
	wuerfeln kann auch mit einem Anzahl Parameter aufgerufen werden und returned eine Liste von Integers
	*/
	public int wuerfeln()
	{
		Random rnd = new Random();
		int ergebnis=rnd.Next(_untere_Grenze,_seiten+1);
		return ergebnis;
	}
	public List<int> wuerfeln(uint pAnzahl)
	{
		Random rnd = new Random();
		List<int> ergebnisse = new List<int>();
		if(pAnzahl>0)
		{
			for(int j=0;j<pAnzahl+1;j++)
			{
				ergebnisse.Add(rnd.Next(_untere_Grenze,_seiten+1));
			}
		}
		return ergebnisse;
	}
}
