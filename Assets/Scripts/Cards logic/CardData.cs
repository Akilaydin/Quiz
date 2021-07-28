using UnityEngine;

[System.Serializable]
public class CardData
{
    [SerializeField]
    private string identifier;
    [SerializeField]
    private Sprite sprite;
    public string Identifier => identifier;
    public Sprite Sprite => sprite;
}
