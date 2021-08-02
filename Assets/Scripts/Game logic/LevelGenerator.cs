using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelGenerator : MonoBehaviour
{
    public UnityEvent TextSetup;
    public UnityEvent LevelGenerated;
    public UnityEvent LevelStartedToGenerate;

    [Range(0f, 10f)]
    [Tooltip("The time between spawn each card")]
    [SerializeField]
    private float _cardSpawnDelay = 0.7f;
    [Range(0f, 10f)]
    [Tooltip("The time between spawn each card")]
    [SerializeField]
    private float _delayBetweenLevels = 1f;
    [SerializeField]
    private string _questionTextTemplate = "Find ";
    [SerializeField]
    private Text _questionText;
    [SerializeField]
    private Spawner _cardSpawner;
    
    private void Start()
    {
        GenerateLevel();
    }

    public void GenerateLevel()
    {
        StartCoroutine(GenerateLevelCoroutine());
    }

    public void OnCardsForLevelGenerated()
    {
        LevelGenerated.Invoke();
    }

    public void SetupQuestionText(string rightAnswer)
    {
        _questionText.text = _questionTextTemplate + rightAnswer;
        TextSetup.Invoke();
    }

    public void SetZeroCardSpawnTime()
    {
        _cardSpawnDelay = 0;
    }

    private IEnumerator GenerateLevelCoroutine()
    {
        yield return new WaitForSeconds(_delayBetweenLevels);
        LevelStartedToGenerate.Invoke();
        _cardSpawner.SpawnCards(_cardSpawnDelay);
    }
}
