using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    CollectablesHandler myCollectables;
    MiniGameController myMiniGameController;
    private void Start()
    {
        myCollectables = FindObjectOfType<CollectablesHandler>();
        myMiniGameController = FindObjectOfType<MiniGameController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = transform.position;
        FindObjectOfType<TimerCountdown>().isGameStarted = true;
        if(other.tag == "flower")
        {
            myCollectables.flowerCollected();
        }
        else if(other.tag == "candle")
        {

            //myCollectables.flowerCollected();
            myMiniGameController.StartCandleMinigame();
        }
        else if (other.tag == "insense")
        {
            myCollectables.insenseCollected();
        }

    }
}
