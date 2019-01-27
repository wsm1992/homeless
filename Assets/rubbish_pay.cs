using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class rubbish_pay : Story
{
    public override bool isEnabled()
    {
        int money = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("money");
        return money > 0;
    }

    void op1()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_pay" + "_" + "1");
        game.Next();
    }

    void op2()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_pay" + "_" + "1");
        game.Next();
    }
}
