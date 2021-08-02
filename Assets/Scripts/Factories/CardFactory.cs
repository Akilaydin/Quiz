using UnityEngine;
using UnityEngine.UI;

public class CardFactory : Factory
{
    public GameObject CreateNewCard(CardData cardData, Transform frameTransform)
    {
        GameObject card = new GameObject("card");
        Image cardImage = card.AddComponent<Image>();
        cardImage.sprite = cardData.Sprite;
        cardImage.SetNativeSize();
        card.AddComponent<Card>().SetIdentifier(cardData.Identifier);
        card.transform.SetParent(frameTransform);
        return card;
    }
}
