using UnityEngine;

[CreateAssetMenu(fileName = "New Card Bundle", menuName = "Card Bundle", order = 5)]
public class CardBundle : ScriptableObject
{
    [SerializeField]
    private CardData[] cardData;
    public CardData[] CardData => cardData;
}
