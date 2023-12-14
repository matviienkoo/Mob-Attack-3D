using DG.Tweening;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField] private bool Repiat;
    void Start()
    {

    if (Repiat)
        transform.DORotate(new Vector3(-360f, -360f, -0f), 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);
    else
        transform.DORotate(new Vector3(360f, 360f, 0f), 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);

    }
}
