using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenAnimator : MonoBehaviour
{
    [SerializeField]
    private Image _loadingScreen;
    [Range(0f, 5f)]
    [Tooltip("The time that panel takes to fade in")]
    [SerializeField]
    private float _fadeInDuration = 1f;
    [Range(0f, 5f)]
    [Tooltip("The time that panel takes to fade out")]
    [SerializeField]
    private float _fadeOutDuration = 0.2f;

    public void FadeInLoadingScreen()
    {
        _loadingScreen.DOFade(1, _fadeOutDuration);
    }

    public void FadeOutLoadingScreen()
    {
        _loadingScreen.DOFade(0, _fadeOutDuration);
    }

}
