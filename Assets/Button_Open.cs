using DG.Tweening;
using UnityEngine;

public class Button_Open : MonoBehaviour
{
    public GameObject Object_Open;

    public Animation Wall_first;
    public Animation Wall_second;

    private void OnCollisionEnter(Collision other){
        if (other.collider.CompareTag("add_special")){
            Wall_first.Play();
            Wall_second.Play();
            Object_Open.SetActive(false);
        }
    }
}
