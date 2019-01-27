using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class tooCold : StoryEnd
{
    public override Flowchart Ending()
    {		
		int warm = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("warm");
        if (warm <= 0)
        {						
			Flowchart flowchart = GameObject.Find("tooCold").GetComponent<Flowchart>();
            return flowchart;
        }
		return null;
    }
}
