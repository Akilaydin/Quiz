using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public UnityEvent SceneRestarted;
    public UnityEvent SceneBeginsToRestart;
    [Range(0f,10f)]
    [SerializeField]
    private float delayBeforeLoadScene; //Needs to show loading screen.
    public void Restart()
    {
        SceneBeginsToRestart.Invoke();
        StartCoroutine(RestartCoroutine());
    }

    private IEnumerator RestartCoroutine()
    {
        yield return new WaitForSeconds(delayBeforeLoadScene);
        SceneRestarted.Invoke();
        SceneManager.LoadScene(0);
    }
}
