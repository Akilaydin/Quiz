using UnityEngine;
using UnityEngine.UI;

public class FrameFactory : Factory
{
    [SerializeField]
    private Transform _framesPanel;
    [SerializeField]
    private Sprite _frameSprite;

    public GameObject CreateNewFrame()
    {
        GameObject frame = new GameObject("frame");
        Image frameImage = frame.AddComponent<Image>();
        frameImage.sprite = _frameSprite;
        frameImage.raycastTarget = false;
        frame.transform.SetParent(_framesPanel);
        return frame;
    }
}
