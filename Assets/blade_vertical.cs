using DG.Tweening;
using UnityEngine;

public class blade_vertical : MonoBehaviour
{

    void Start()
    {
        transform.DOMoveX(-0.82f, Random.Range(1f, 1.3f)).SetLoops(1000000, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

}
