using UnityEngine;
using UnityEngine.Events;

public class AnswerChecker : Identifier
{
    public UnityEvent<GameObject> RightCardChosen;
    public UnityEvent<GameObject> WrongCardChosen;

    public void CheckAnswer(GameObject selectedCard)
    {
        if (GetIdentifier() == selectedCard.GetComponent<Card>().GetIdentifier())
        {
            RightCardChosen.Invoke(selectedCard);
        }
        else
        {
            WrongCardChosen.Invoke(selectedCard);
        }
    }
}
