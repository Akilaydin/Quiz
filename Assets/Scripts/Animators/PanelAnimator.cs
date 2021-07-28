using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PanelAnimator : MonoBehaviour
{
    [SerializeField]
    private Image _panel;
    [Range(0f, 5f)]
    [Tooltip("The time that panel takes to fade in")]
    [SerializeField]
    private float _fadeInDuration = 0.2f;
    [Range(0f, 5f)]
    [Tooltip("The time that panel takes to fade out")]
    [SerializeField]
    private float _fadeOutDuration = 0.2f;

    public void FadeInPanel()
    {
        _panel.DOFade(0.5f, _fadeInDuration);
    }

    public void FadeOutPanel()
    {
        _panel.DOFade(0, _fadeOutDuration);
    }
}
