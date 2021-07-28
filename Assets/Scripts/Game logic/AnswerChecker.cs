using UnityEngine;
using UnityEngine.Events;

public class AnswerChecker : MonoBehaviour
{
    private string _rightIdentifier;
    public UnityEvent<GameObject> RightCardChosen;
    public UnityEvent<GameObject> WrongCardChosen;
    public void CheckAnswer(GameObject selectedCard)
    {
        if (_rightIdentifier == selectedCard.GetComponent<Card>().GetIdentifier())
        {
            RightCardChosen.Invoke(selectedCard);
        }
        else
        {
            WrongCardChosen.Invoke(selectedCard);
        }
    }
    public void SetRightIdentifier(string rightIdentifier)
    {
        _rightIdentifier = rightIdentifier;
    }
}
