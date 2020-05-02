using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Resources resourceManager;
    public List<Events> eventList = new List<Events>();

    public void SetEvent(int eventNumber)
    {
        Debug.Log(eventList[eventNumber].eventName);
        resourceManager.money += eventList[eventNumber].deltaMoney;
        resourceManager.moneyPerSecond += eventList[eventNumber].deltaMoneyPerSecond;
        resourceManager.maxPower += eventList[eventNumber].deltaMaxPower;
        resourceManager.consPower += eventList[eventNumber].deltaConsPower;
        resourceManager.allPeople += eventList[eventNumber].deltaAllPeople;
        resourceManager.chippedPeople += eventList[eventNumber].deltaChippedPeople;
        resourceManager.chippedPeoplePerSecond += eventList[eventNumber].deltaChippedPeoplePerSecond;
        resourceManager.oppositionPeople += eventList[eventNumber].deltaOppositionPeople;
        resourceManager.oppositionPeoplePerSecond += eventList[eventNumber].deltaOppositionPeoplePerSecond;
    }

    private void Start()
    {
        SetEvent(1);
    }
}
