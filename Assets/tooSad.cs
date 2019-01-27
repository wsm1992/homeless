using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class tooSad : StoryEnd
{
    public override Flowchart Ending()
    {
		int mood = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("mood");
        if (mood <= 0)
        {						
			Flowchart flowchart = GameObject.Find("tooSad").GetComponent<Flowchart>();
            return flowchart;
        }
		return null;
    }
}
