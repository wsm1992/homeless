using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class rubbish_ticket : Story
{

    private void Start()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        Flowchart flowchart = GetComponent<Flowchart>();
        flowchart.SetIntegerVariable("money", 100);
    }

    void op1()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_ticket" + "_" + "1");
        game.Next();
    }

    void op2()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_ticket" + "_" + "1");
        game.Next();
    }
}
