using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class tooHungry : StoryEnd
{
    public override Flowchart Ending()
    {
		int food = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("food");
        if (food <= 0)
        {						
			Flowchart flowchart = GameObject.Find("tooHungry").GetComponent<Flowchart>();
            return flowchart;
        }
		return null;
    }
}
