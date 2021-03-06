﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

class GoToJail : Non_Purchasable
{
    //defualt constructor.
    public GoToJail() : base()
    {
    }
    //Parameterized constructor.
    public GoToJail(Monopoly.Monopoly P, int fieldnumber, Point fieldpostion) : base(P,fieldnumber, fieldpostion)
    {
    }
    //overriding the pure virtual function Action.
    override public void Action(Player player)
    {
        Point jail = new Point(80, 530);
        player.Set_PlayerPosition(jail);
        player.Set_Fieldnumber(7);
        player.Pay_Tax(50);
        GetForm().Main.Check_PlayerBalance(player);
        switch (player.Get_Token())
        {
            case 1:
                GetForm().SetPlayer1PanelLocation(jail);
                break;
            case 2:
                GetForm().SetPlayer2PanelLocation(jail);
                break;
            case 3:
                GetForm().SetPlayer3PanelLocation(jail);
                break;
            case 4:
                GetForm().SetPlayer4PanelLocation(jail);
                break;
        }
        GetForm().Main.Move_Player(player);
    }
}
