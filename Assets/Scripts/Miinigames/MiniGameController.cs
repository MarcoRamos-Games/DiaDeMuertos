using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameController : MonoBehaviour
{
    [SerializeField] private GameObject candleMinigame;
    public bool isOnMinigame;

    private void Start()
    {
        candleMinigame.SetActive(false);
    }
    public void StartCandleMinigame()
    {
        candleMinigame.SetActive(true);
        isOnMinigame = true;
    }
    public void StopCandleMinigame()
    {
        candleMinigame.SetActive(false);
        isOnMinigame = false;
    }
}
