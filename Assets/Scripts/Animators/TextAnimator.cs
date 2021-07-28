using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextAnimator : MonoBehaviour
{
    [SerializeField]
    private Text questionText;
    [Range(0.05f, 5f)]
    [Tooltip("The time that text takes to fade in")]
    [SerializeField]
    private float _fadeInDuration = 0.2f;
    [Range(0.05f, 5f)]
    [Tooltip("The time that text takes to fade out")]
    [SerializeField]
    private float _fadeOutDuration = 0.2f;

    public void FadeInText()
    {
        questionText.DOFade(1, _fadeInDuration);
    }

    public void FadeOutText()
    {
        questionText.DOFade(0, _fadeOutDuration);
    }
}
