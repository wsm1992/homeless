using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class tooTired : StoryEnd
{
    public override Flowchart Ending()
    {
		int energy = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("energy");
        if (energy <= 0)
        {						
			Flowchart flowchart = GameObject.Find("tooTired").GetComponent<Flowchart>();
            return flowchart;
        }
		return null;
    }
}
