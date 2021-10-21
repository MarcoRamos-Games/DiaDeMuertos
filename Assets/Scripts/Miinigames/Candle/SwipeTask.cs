using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTask : MonoBehaviour
{
    public List<SwipePoints> mySwipePoints = new List<SwipePoints>();

    public float countdownMax = 0.5f;

    private int currentSwipePointIndex = 0;
    private float countdown = 0;

    [SerializeField] private GameObject swipeItemOn, swipeItemOf;
    public bool isSwipeItemOn= false;

    private void OnEnable()
    {
        isSwipeItemOn = false;
        swipeItemOf.SetActive(true);
        swipeItemOn.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if(currentSwipePointIndex !=0 && countdown <= 0)
        {
            currentSwipePointIndex = 0;

        }
    }

    public void SwipePointTrigger (SwipePoints swipePoint)
    {
        if(swipePoint == mySwipePoints[currentSwipePointIndex])
        {
            currentSwipePointIndex++;
            countdown = countdownMax;
        }
        if(currentSwipePointIndex >= mySwipePoints.Count)
        {
            currentSwipePointIndex = 0;
            swipeItemOn.transform.position = swipeItemOf.transform.position;
            swipeItemOf.SetActive(false);
            swipeItemOn.SetActive(true);
            isSwipeItemOn = true;
            
        }
    }

    public void LightCandle(bool isCandleOn)
    {
        if (isCandleOn)
        {
            StartCoroutine(FinishMiniGame());
        }
    }

    IEnumerator FinishMiniGame()
    {
        yield return new WaitForSeconds(3);
        FindObjectOfType<MiniGameController>().StopCandleMinigame();
        FindObjectOfType<CollectablesHandler>().candleCollected();
    }
    
}
