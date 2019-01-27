using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daughter01 : Story
{
    void op1()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("daughter01" + "_" + "1");
        game.Next();
    }

    void op2()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("daughter01" + "_" + "2");
        game.Next();
    }
}
