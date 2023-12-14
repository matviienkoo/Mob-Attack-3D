using DG.Tweening;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private bool Repiat;
    void Start()
    {

    if (Repiat)
        transform.DOMoveY(0.40F, 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);
    }
}
