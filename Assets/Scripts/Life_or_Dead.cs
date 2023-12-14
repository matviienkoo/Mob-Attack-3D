using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_or_Dead : MonoBehaviour
{
public int Life;
public int Dead;
public int pizda;

void Start (){
    PlayerPrefs.DeleteKey("Dead");
    PlayerPrefs.DeleteKey("Life");
}

private void OnCollisionEnter(Collision other){

    if (other.collider.CompareTag("obstacle"))
    {
        if (pizda == 0){
        pizda = 1;
        }
    }

}

void Update (){
Dead = PlayerPrefs.GetInt("Dead");
Life = PlayerPrefs.GetInt("Life");

if (pizda == 1){
Dead += 1;
PlayerPrefs.SetInt("Dead",Dead);

pizda = 2;
}

// end update
}
}


