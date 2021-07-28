using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class CardAnimator : MonoBehaviour
{    
    [Header("On card appearance")]
    [Range(0.05f, 10f)]
    [Tooltip("The time that card uses to bounce in front and back")]
    [SerializeField]
    private float _appearedCardBounceTime = 0.5f;
    [Range(0.5f, 5f)]
    [Tooltip("The size scales to when bounces")]
    [SerializeField]
    private float _appearedCardBounceSize = 1.2f;
    [SerializeField]
    private Ease _appearanceEase = Ease.Linear;

    [Space]
    [Header("On wrong choosen card")]
    [Range(0.05f, 10f)]
    [Tooltip("The time that card uses to bounce in front and back")]
    [SerializeField]
    private float _wrongCardShakeTime = 0.5f;
    [Range(0.01f, 10f)]
    [Tooltip("The size scales to when bounces")]
    [SerializeField]
    private float _wrongCardShakeStrength = 0.3f;
    [SerializeField]
    private Ease _wrongEase = Ease.InBounce;

    [Space]
    [Header("On right choosen card")]
    [Range(0.05f, 10f)]
    [Tooltip("The time that card uses to bounce in front and back")]
    [SerializeField]
    private float _rightCardBounceTime = 0.45f;
    [Range(0.5f, 5f)]
    [Tooltip("The size scales to when bounces")]
    [SerializeField]
    private float _rightCardBounceSize = 1.2f;
    [SerializeField]
    private Ease _rightEase = Ease.Linear;

    public void BounceCardOnAppear(GameObject card)
    {
        card.transform.DOScale(new Vector2(_appearedCardBounceSize, _appearedCardBounceSize), _appearedCardBounceTime).SetEase(_appearanceEase).OnComplete(() => {
            card.transform.DOScale(new Vector2(1, 1), _appearedCardBounceTime).SetEase(_appearanceEase);
        });
    }
    public void BounceCardOnWrong(GameObject card)
    {
        card.transform.DOShakeScale(_wrongCardShakeTime,_wrongCardShakeStrength).SetEase(_wrongEase).OnComplete(() => {
            card.transform.DOScale(new Vector3(1, 1, 1),0.1f);
        });
    }
    public void BounceCardOnRight(GameObject card)
    {
        card.transform.DOScale(new Vector2(_rightCardBounceSize, _rightCardBounceSize), _rightCardBounceTime).SetEase(_rightEase).OnComplete(() => {
            card.transform.DOScale(new Vector2(1, 1), _rightCardBounceTime).SetEase(_rightEase);
        });
    }
}
