using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Card : Identifier, IPointerClickHandler
{
    public UnityEvent<GameObject> CardClicked;

    private void Awake()
    {
        CardClicked = new UnityEvent<GameObject>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        CardClicked.Invoke(gameObject);
    }
}