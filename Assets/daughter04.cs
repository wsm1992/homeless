using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daughter04 : Story
{
    public override bool isEnabled()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        return game.HasTriggeredEvent("daughter03" + "_" + "1");
    }
    void op1()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("daughter04" + "_" + "1");
        game.Next();
    }

    void op2()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("daughter04" + "_" + "2");
        game.Next();
    }
}
