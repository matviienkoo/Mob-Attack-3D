using DG.Tweening;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private bool Repiat;
    void Start()
    {

    if (Repiat)
        transform.DORotate(new Vector3(0f, -180f, -180f), 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);
    else
        transform.DORotate(new Vector3(0f, 180f, 180f), 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);

    }

}
