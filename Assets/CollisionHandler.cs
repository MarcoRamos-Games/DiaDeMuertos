using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    CollectablesHandler myCollectables;
    private void Start()
    {
        myCollectables = FindObjectOfType<CollectablesHandler>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "flower")
        {
            myCollectables.flowerCollected();
        }
        else if(other.tag == "candle")
        {
            myCollectables.candleCollected();
        }
        else if (other.tag == "insense")
        {
            myCollectables.insenseCollected();
        }

    }
}
