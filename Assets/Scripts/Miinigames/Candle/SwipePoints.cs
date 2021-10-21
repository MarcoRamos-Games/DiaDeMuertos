using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipePoints : MonoBehaviour
{

    private SwipeTask mySwipeTask;
    private void Awake()
    {
        mySwipeTask = GetComponentInParent<SwipeTask>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        mySwipeTask.SwipePointTrigger(this);
        Debug.Log(other.name);
    }
}
