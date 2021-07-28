using UnityEngine;

public class Card : MonoBehaviour
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
}
