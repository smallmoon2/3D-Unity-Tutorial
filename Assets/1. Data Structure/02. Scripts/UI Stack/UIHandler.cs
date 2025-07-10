using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform ParentRect;

    private Vector2 basePos;
    private Vector2 startPos;
    private Vector2 moveOffset;

    void Awake()
    {
        ParentRect = transform.parent.GetComponent<RectTransform>();

        //ParentRect.SetAsFirstSibling(); //먼저 그려짐
        //ParentRect.SetAsLastSibling(); // 나중에
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ParentRect.SetAsLastSibling();
        basePos = ParentRect.anchoredPosition;
        startPos = eventData.position;
    }


    public void OnDrag(PointerEventData eventData)
    {
        moveOffset = eventData.position - startPos;
        ParentRect.anchoredPosition = basePos + moveOffset;
    }


}
