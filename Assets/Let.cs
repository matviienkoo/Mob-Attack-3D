using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Let : MonoBehaviour
{
    int int_let;

    public Collider m_Collider;

    private void OnCollisionEnter(Collision other){
        if (other.collider.CompareTag("add_special")){
            int_let = 1;
        }
    }

    void Update (){
        if (int_let == 1){
            m_Collider.enabled = false;
            int_let = 2;
        }
    }
}
