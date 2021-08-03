using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [Header("Events")]
    public UnityEvent AllCardsGenerated;
    public UnityEvent CardsForLevelGenerated;
    public UnityEvent<string> AnswerGenerated;
    public UnityEvent<GameObject> CardGenerated;

    [Space]
    [Header("Factories")]
    [SerializeField]
    private FrameFactory _frameFactory;
    [SerializeField]
    private CardFactory _cardFactory;

    [Space]
    [SerializeField]
    private CardBundle[] _levelsData;

    private List<CardData> _cardsToGenerateForLevel; // To provide random order of cards
    private List<Card> _generatedCards; //To provide random answer
    private List<GameObject> _generatedFrames;
    private int _levelIndex;

    private void Start()
    {
        _levelIndex = 0;
        _generatedCards = new List<Card>();
        _generatedFrames = new List<GameObject>();
        _cardsToGenerateForLevel = new List<CardData>();
        FillCardsToGenerate();
    }

    public void SpawnCards(float cardSpawnDelay)
    {
        if (_generatedFrames.Count != 0)
        {
            DestroyGeneratedFrames();
        }
        if (_generatedCards.Count != 0)
        {
            RemoveGeneratedCards();
        }
        StartCoroutine(SpawnCardsCoroutine(cardSpawnDelay));
        _levelIndex++;
        FillCardsToGenerate();
    }

    private IEnumerator SpawnCardsCoroutine(float cardSpawnDelay)
    {
        if (IsHavingCardsToGenerate() == true)
        {
            foreach (var cardData in _cardsToGenerateForLevel.ToList())
            {
                GameObject frame = _frameFactory.CreateNewFrame();
                _generatedFrames.Add(frame);

                GameObject card = _cardFactory.CreateNewCard(cardData, frame.transform);
                _generatedCards.Add(card.GetComponent<Card>());
                CardGenerated.Invoke(card);
                yield return new WaitForSeconds(cardSpawnDelay);
            }
            CardsForLevelGenerated.Invoke();
        }
        else
        {
            AllCardsGenerated.Invoke();
            yield break;
        }
    }

    private bool IsHavingCardsToGenerate()
    {
        if (_levelIndex > _levelsData.Length - 1)
        {
            return false;
        }
        return true;
    }

    public void SetRandomAnswer()
    {
        int randomCardIndex = Random.Range(0, _generatedCards.Count);
        Card randomCard = _generatedCards[randomCardIndex];
        AnswerGenerated.Invoke(randomCard.GetIdentifier());
    }

    private void DestroyGeneratedFrames()
    {
        foreach (var frame in _generatedFrames)
        {
            Destroy(frame);
        }
    }

    private void FillCardsToGenerate()
    {
        if (IsHavingCardsToGenerate() == true)
        {
            ClearCardsToGenerate();
            _cardsToGenerateForLevel.AddRange(_levelsData[_levelIndex].CardData);
            ShuffleCardsToGenerate();
        }
    }

    private void ShuffleCardsToGenerate()
    {
        CardData tempData;
        for (int i = 0; i < _cardsToGenerateForLevel.Count; i++)
        {
            int rnd = Random.Range(0, _cardsToGenerateForLevel.Count);
            tempData = _cardsToGenerateForLevel[rnd];
            _cardsToGenerateForLevel[rnd] = _cardsToGenerateForLevel[i];
            _cardsToGenerateForLevel[i] = tempData;
        }
    }

    private void ClearCardsToGenerate()
    {
        _cardsToGenerateForLevel.Clear();
    }

    private void RemoveGeneratedCards()
    {
        _generatedCards.Clear();
    }
}
