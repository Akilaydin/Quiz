using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    public UnityEvent<GameObject> CardSelected;

    private bool _isInputAllowed = false;
    public void OnCardClicked(GameObject card)
    {
        if (_isInputAllowed == true)
        {
            CardSelected.Invoke(card);
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
