using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public UnityEvent<GameObject> CardSelected;

    [SerializeField]
    private GraphicRaycaster _graphicRaycaster;

    private bool _isInputAllowed = false;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && _isInputAllowed)
        {
            PointerEventData pointerEventData = new PointerEventData(null);
            pointerEventData.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            _graphicRaycaster.Raycast(pointerEventData, results);

            if (results.Count > 0 && results.Count < 2)
            {
                if (results[0].gameObject.GetComponent<Card>())
                {
                    GameObject card = results[0].gameObject;
                    CardSelected.Invoke(card);
                }
            }
        }
    }

    public void SetInputAllowedFalse()
    {
        _isInputAllowed = false;
    }

    public void SetInputAllowedTrue()
    {
        _isInputAllowed = true;
    }
}
