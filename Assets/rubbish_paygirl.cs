using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class rubbish_paygirl : Story
{
    public override bool isEnabled()
    {
        bool matches = GameObject.Find("start").GetComponent<Flowchart>().GetBooleanVariable("matches");
        Debug.Log("has matches??: " + matches);
        return matches;
    }

    void op1()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_paygirl" + "_" + "1");
        game.Next();
    }

    void op2()
    {
        Game game = GameObject.Find("game").GetComponent<Game>();
        game.UpdateStatus(0, 10, 0, 0);
        game.AddTriggeredEvent("rubbish_paygirl" + "_" + "1");
        game.Next();
    }
}