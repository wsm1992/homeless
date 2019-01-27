using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubbish_oldclothes : Story
{
    void op1()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_oldclothes" + "_" + "1");
        game.Next();
    }

    void op2()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_oldclothes" + "_" + "1");
        game.Next();
    }
}
