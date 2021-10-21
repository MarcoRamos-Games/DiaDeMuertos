using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    private SwipeTask mySwipeTask;
    bool isCandleOn = false;
    [SerializeField] private GameObject candleOn, candleOf;

    private void Awake()
    {
        mySwipeTask = GetComponentInParent<SwipeTask>();
    }

    private void Start()
    {
        isCandleOn = false;
        candleOf.SetActive(true);
        candleOn.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!mySwipeTask.isSwipeItemOn)
        {
            return;       
        }
        else
        {
            candleOf.SetActive(false);
            candleOn.SetActive(true);
            isCandleOn = true;
            mySwipeTask.LightCandle(isCandleOn);
        }
    }
}
