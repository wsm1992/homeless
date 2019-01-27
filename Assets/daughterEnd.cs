using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class daughterEnd : StoryEnd
{
    public override Flowchart Ending()
    {
		Game game = GameObject.Find("game").GetComponent<Game>();
        if( game.HasTriggeredEvent("daughter04" + "_" + "1")){
			Flowchart flowchart = GameObject.Find("daughterEnd").GetComponent<Flowchart>();
            return flowchart;
		}
		return null;
    }
}
