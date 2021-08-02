using UnityEngine;

public class Identifier : MonoBehaviour
{
    private string _identifier;

    public void SetIdentifier(string identifier)
    {
        if (string.IsNullOrEmpty(identifier) == false)
        {
            _identifier = identifier;
        }
        else
        {
            throw new System.ArgumentNullException();
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
