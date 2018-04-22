﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

abstract class Purchasable : Field
{
    string Name;
    int Price;
    int MortagagePrice;
    bool ISMortagaged;
    Player Owner;
    bool Owned;

    public Purchasable():base()
    {
        Name = " ";
        Price = 0;
        MortagagePrice = 0;
        Owned = false;
    }
    public Purchasable(int fieldnumber, Point fieldpostion,string name, int price, int mortagagedprice):base(fieldnumber,fieldpostion)
    {
        Name = name;
        Price = price;
        MortagagePrice = mortagagedprice;
        ISMortagaged = false;
        Owned = false;
    }
    public void Set_Owner(Player player)
    {
        Owner = player;
    }
    public Player Get_Owner()
    {
        return Owner;
    }
    public void Set_Owned()
    {
        Owned = true;
    }
    public bool Get_Owned()
    {
        return Owned;
    }
    public void Set_Name(string name)
    {
        Name = name;
    }
    public string Get_Name()
    {
        return Name;
    }
    public void Set_Price(int price)
    {
        Price = price;
    }
    public int Get_Price()
    {
        return Price;
    }
    public void Set_MortagagePrice(int price)
    {
        MortagagePrice = price;
    }
    public int Get_MortagagePrice()
    {
        return MortagagePrice;
    }
    public  bool Get_ISMortagaged()
    {
        return ISMortagaged;
    }
    public void Set_ISMortagaged()
    {
        ISMortagaged = true;
    }
    public void Remove_Mortagage()
    {
        ISMortagaged = false;
    }
}
