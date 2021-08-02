using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAnimator : MonoBehaviour
{
    [SerializeField]
    private Graphic _graphicElement;

    [Tooltip("The alpha channel value in which the graphic element is going to be after animation is completed")]
    [Range(0f, 1f)]
    [SerializeField]
    private float _fadeInRate = 1;

    [Tooltip("The alpha channel value in which the graphic element is going to be after animation is completed")]
    [Range(0f, 1f)]
    [SerializeField]
    private float _fadeOutRate = 0;

    [Space]
    [Range(0.05f, 5f)]
    [Tooltip("The time that graphic element takes to fade in")]
    [SerializeField]
    private float _fadeInDuration = 0.2f;

    [Range(0.05f, 5f)]
    [Tooltip("The time that graphic element takes to fade out")]
    [SerializeField]
    private float _fadeOutDuration = 0.2f;

    public void FadeIn()
    {
        _graphicElement.DOFade(_fadeInRate, _fadeInDuration);
    }

    public void FadeOut()
    {
        _graphicElement.DOFade(_fadeOutRate, _fadeOutDuration);
    }
}
