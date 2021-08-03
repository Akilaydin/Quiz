using UnityEngine;
using UnityEngine.UI;

public class CardFactory : Factory
{
    [SerializeField]
    private InputHandler _inputHandler;
    public GameObject CreateNewCard(CardData cardData, Transform frameTransform)
    {
        GameObject card = new GameObject("card");

        Image cardImage = card.AddComponent<Image>();
        cardImage.sprite = cardData.Sprite;
        cardImage.SetNativeSize();

        Card cardComponent = card.AddComponent<Card>();
        cardComponent.SetIdentifier(cardData.Identifier);
        cardComponent.CardClicked.AddListener((card) => _inputHandler.OnCardClicked(card));

        card.transform.SetParent(frameTransform);
        return card;
    }
}
