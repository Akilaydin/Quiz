using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesPlayer : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _starsParticle;

    public void PlayStarsParticle()
    {
        _starsParticle.Play();
    }
}
