using DG.Tweening;
using UnityEngine;

public class Circle_Move : MonoBehaviour
{
    [SerializeField] private bool Repiat;
    void Start()
    {

    if (Repiat)
        transform.DORotate(new Vector3(0f, -180f, -180f), 2f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);
    else
        transform.DORotate(new Vector3(0f, 180f, 180f), 2f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);

    if (Repiat)
        transform.DOMoveX(0.65f, 2f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);
    else
        transform.DOMoveX(0.65f, 2f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);

    }

}
