using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerClickHandler
{
    private string _identifier;

    public void SetIdentifier(string identifier)
    {
        if (string.IsNullOrEmpty(identifier) == false)
        {
            _identifier = identifier;
        }
    }
    public string GetIdentifier()
    {
        if (string.IsNullOrEmpty(_identifier) == false)
        {
            return _identifier;
        }
        else
        {
            throw new System.ArgumentNullException();
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        Debug.Log(name + " Game Object Clicked!");
    }
}
