using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    [SerializeField] private GameObject textDisplay;
    [SerializeField] private int secondsLeft = 30;
    public bool takingAway = false;
    public bool isGameStarted = false;

    private void Start()
    {
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
    }

    private void Update()
    {
        if(takingAway == false && secondsLeft > 0 && isGameStarted)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        takingAway = false;
    }

}
