/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class Digitalchange : MonoBehaviour
{
    public int oldmoney;
    public int oldwarm;
    public int oldfood;
    public int oldenergy;
    public int oldmood;

    public int newmoney = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("money");
    public int newwarm = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("warm");
    public int newfood = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("food");
    public int newenergy = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("energy");
    public int newmood = GameObject.Find("start").GetComponent<Flowchart>().GetIntegerVariable("mood");

    public Text myText;

    private Text tempText;

      public void createMyText(string message)
    {
        tempText = (Text)Instantiate(myText);
        tempText.GetComponent<Transform>().SetParent(Gameject.Find("Canvas").GetComponent<Transform>(),
            tempText = message;
    }
// Start is called before the first frame update
void Start()
    {
        oldmoney = newmoney;
        oldwarm = newwarm;
        oldfood = newfood;
        oldenergy = newenergy;
        oldmood = newmood;
}

    // Update is called once per frame
    void Update()
    {
        if(oldmoney != newmoney) {
            GameObject a = Instantiate(Dchange, gameObject.transform.position, gameObject.transform.rotation);
            a.GetComponent<Transform>().GetChild(0).Text
                //= oldmoney -= newmoney;
        }

        
    }
}*/
