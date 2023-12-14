using DG.Tweening;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private bool Repiat;
    void Start()
    {

    if (Repiat)
    transform.DOScale(new Vector3(0.7f, 0.7f, 0.7f), 1f).SetLoops(100000,LoopType.Yoyo).SetEase(Ease.InOutSine);

    }
}
