using DG.Tweening;
using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField] private bool LeftRight;
    void Start()
    {
        if (LeftRight)
            transform.DORotate(new Vector3(0f, 0f, -50f), 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);
        else
            transform.DORotate(new Vector3(0f, 0f, 100f), 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);

    }

  
}
