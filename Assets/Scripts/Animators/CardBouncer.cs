using DG.Tweening;
using UnityEngine;

public abstract class CardBouncer : CardAnimator
{ 
    [Range(0.05f, 10f)]
    [Tooltip("The time that card uses to bounce in front and back")]
    [SerializeField]
    private float _cardBounceTime = 0.45f;
    [Range(0.5f, 5f)]
    [Tooltip("The size scales to when bounces")]
    [SerializeField]
    private float _cardBounceSize = 1.2f;

    public override void AnimateCard(GameObject card)
    {
        card.transform.DOScale(new Vector2(_cardBounceSize, _cardBounceSize), _cardBounceTime).SetEase(_ease).OnComplete(() => {
            card.transform.DOScale(new Vector2(1, 1), _cardBounceTime).SetEase(_ease);
        });
    }
}
