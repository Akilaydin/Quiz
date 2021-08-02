using DG.Tweening;
using UnityEngine;

public class CardShaker : CardAnimator
{
    [Range(0.05f, 10f)]
    [Tooltip("The time that card uses to shake")]
    [SerializeField]
    private float _cardShakeTime = 0.5f;
    [Range(0.01f, 10f)]
    [Tooltip("The strength with which a card shaked on wrong answer")]
    [SerializeField]
    private float _cardShakeStrength = 0.3f;

    public override void AnimateCard(GameObject card)
    {
        card.transform.DOShakeScale(_cardShakeTime, _cardShakeStrength).SetEase(_ease).OnComplete(() => {
            card.transform.DOScale(new Vector3(1, 1, 1), 0.1f);
        });
    }
}
