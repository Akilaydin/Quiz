using DG.Tweening;
using UnityEngine;

public abstract class CardAnimator : MonoBehaviour
{
    [SerializeField]
    protected Ease _ease = Ease.Linear;

    public abstract void AnimateCard(GameObject card);
}
