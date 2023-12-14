using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;

public class Suicide : MonoBehaviour
{
    public GameObject Particle_Death;
    public GameObject myCollider;
    public Transform myTransform;

    public int int_suicide;
    int Music_int;

    public AudioSource Audio_obcerantable;  

    void Update (){
    int_suicide = PlayerPrefs.GetInt("int_suicide");
    Music_int = PlayerPrefs.GetInt("Music_int");

        if (int_suicide == 1){
            Instantiate(Particle_Death, myTransform.position, Quaternion.identity);
            if (Music_int == 0){
            Audio_obcerantable.Play();
            }

            myCollider.SetActive(false);
        }
    }
}
