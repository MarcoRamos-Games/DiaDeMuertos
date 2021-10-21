using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeItem : MonoBehaviour, IDragHandler
{
    private Canvas myCanvas;

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            myCanvas.transform as RectTransform, 
            eventData.position,
            myCanvas.worldCamera, 
            out pos);

        transform.position = myCanvas.transform.TransformPoint(pos);
    }

    private void Awake()
    {
        myCanvas = GetComponentInParent<Canvas>();
    }

    

}
