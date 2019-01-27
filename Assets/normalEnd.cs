using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class normalEnd : StoryEnd
{
    public override Flowchart Ending()
    {
		Game game = GameObject.Find("game").GetComponent<Game>();
		if(game.Days<=0){
			Flowchart flowchart = GameObject.Find("normalEnd").GetComponent<Flowchart>();
            return flowchart;
		}
		return null;
    }
}
