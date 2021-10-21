using UnityEngine;
using UnityEngine.UI;

public class CollectablesHandler : MonoBehaviour
{

    [SerializeField] private Image flower;
    [SerializeField] private Image candle;
    [SerializeField] private Image insense;

    public static bool isFlowerCollected = false, isCandleColleccted=false, isInsenseCollected=false;
   
    public void flowerCollected()
    {
        flower.color = Color.white;
        isFlowerCollected = true;
    }
    public void candleCollected()
    {
        candle.color = Color.white;
        isCandleColleccted = true;
    }
    public void insenseCollected()
    {
        insense.color = Color.white;
        isInsenseCollected = true;
    }

}
