using DG.Tweening;
using UnityEngine;

public class Moving_wall : MonoBehaviour
{
    [SerializeField] private bool LeftRight;

    void Start()
    {
        if (LeftRight)
            transform.DOMoveX(0.75f, 2f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);
        else
            transform.DOMoveX(0.75f, 2f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);

    }

  
}
