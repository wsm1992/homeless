using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Fungus;
using System;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Flowchart rubbish_bread;
    public Flowchart rubbish_bed;

    public int Warm = 10;
    public int Food = 10;
    public int Energy = 10;
    public int Mood = 10;

    public int Days = 20;

    private List<Flowchart> PendingEvents = new List<Flowchart>();
    private List<Flowchart> EnabledEvents = new List<Flowchart>();

    private List<string> TriggeredEvents = new List<string>();
    private Flowchart CurrentEvent;


    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in GameObject.Find("flowcharts").transform)
        {
            PendingEvents.Add(child.GetComponent<Flowchart>());
            Debug.Log(child.name);
        }
    }

    void Restart()
    {
        PendingEvents.Clear();
        EnabledEvents.Clear();
        TriggeredEvents.Clear();

        CurrentEvent = null;

        Flowchart flowchart = GameObject.Find("start").GetComponent<Flowchart>();
        flowchart.SetIntegerVariable("money", 0);
        flowchart.SetIntegerVariable("warm", 25);
        flowchart.SetIntegerVariable("food", 25);
        flowchart.SetIntegerVariable("energy", 25);
        flowchart.SetIntegerVariable("mood", 25);
        flowchart.SetBooleanVariable("matches", false);
        flowchart.SetBooleanVariable("clothes", false);
        flowchart.SetBooleanVariable("bed", false);
        flowchart.SetBooleanVariable("cardbox", false);

        foreach (Transform child in GameObject.Find("flowcharts").transform)
        {
            PendingEvents.Add(child.GetComponent<Flowchart>());
            Debug.Log(child.name);
        }

        Debug.Log("go to restart");
        flowchart.ExecuteBlock("Start");

        Days = 20;

    }

    // Update is called once per frame
    void Update()
    {
        UpdateUIStatus();
    }

	
    void UpdateUIStatus()
    {
        Flowchart flowchart = GameObject.Find("start").GetComponent<Flowchart>();
        int money = flowchart.GetIntegerVariable("money");

        int warm = flowchart.GetIntegerVariable("warm");
        int food = flowchart.GetIntegerVariable("food");
        int energy = flowchart.GetIntegerVariable("energy");
        int mood = flowchart.GetIntegerVariable("mood");

        GameObject.Find("MoneyText").GetComponent<Text>().text = "金錢: " + money;
        GameObject.Find("WarmText").GetComponent<Text>().text = "溫暖: " + warm;
        GameObject.Find("FoodText").GetComponent<Text>().text = "飽腹: " + food;
        GameObject.Find("EnergyText").GetComponent<Text>().text = "體力: " + energy;
        GameObject.Find("MoodText").GetComponent<Text>().text = "心情: " + mood;
    }

    //public void AddItem(string item)
    //{
    //    Items.Add(item);
    //}

    //public void RemoveItem(string item)
    //{
    //    Items.Remove(item);
    //}

    public bool HasTriggeredEvent(string name)
    {
        return TriggeredEvents.Contains(name);
    }

    public void AddTriggeredEvent(string storyEvent)
    {
        TriggeredEvents.Add(storyEvent);
    }

    public void RemoveTriggeredEvent(string storyEvent)
    {
        TriggeredEvents.Remove(storyEvent);
    }

    public void Next()
    {
		Days--;
        UpdateEventList();
        UpdateCurrent();
		updateEnding();
        Debug.Log("go to: " + CurrentEvent.name);
        CurrentEvent.ExecuteBlock("start");
    }

    public void UpdateStatus(int deltaWarm, int deltaFood, int deltaEnergy, int deltaMood)
    {
        Warm += deltaWarm;
        Food += deltaFood;
        Energy += deltaEnergy;
        Mood += deltaMood;
    }

    public void UpdateCurrent()
    {
        int count = EnabledEvents.Count;
        if (count <= 0)
        {
            Debug.Log("no enabled events");
            foreach (Transform child in GameObject.Find("flowcharts").transform)
            {
                PendingEvents.Add(child.GetComponent<Flowchart>());
                Debug.Log(child.name);
            }
            UpdateEventList();
            count = EnabledEvents.Count;
        }

        System.Random random = new System.Random();
        int pick = random.Next(0, count);
        CurrentEvent = EnabledEvents[pick];
        EnabledEvents.RemoveAt(pick);
    }

    public void UpdateEventList()
    {
        List<Flowchart> tempFlowCharts = new List<Flowchart>();
        foreach (Flowchart fc in PendingEvents)
        {
            Debug.Log("check isenabled for " + fc.name);
            Story story = fc.GetComponent<Story>();
            if (story.isEnabled())
            {
                tempFlowCharts.Add(fc);
                EnabledEvents.Add(fc);
            }
        }
        foreach (Flowchart fc in tempFlowCharts)
        {
            PendingEvents.Remove(fc);
        }
    }

    public bool updateEnding()
    {
          //return false; 

		foreach (Transform child in GameObject.Find("endingFlowchards").transform)
        {
			StoryEnd storyEnd = child.GetComponent<StoryEnd>();
			Debug.Log("update ending");
			if(storyEnd.Ending() != null)
			{
				Debug.Log("update ending, ending not null");
				CurrentEvent = storyEnd.Ending();
				return true;
			}
			Debug.Log("update ending, ending is null");
        }	
		return false;
    }
}
