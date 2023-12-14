using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Transtion_System : MonoBehaviour{
public Animation transtion_anim;
public GameObject transtion_object;
public int real_text_level;
public int int_skip_level;
public int int_randomize;
public int int_level;

int int_transtion;
float float_timer;

    void Start (){
        transtion_anim.Play("transtion_closed");
        int_transtion = 1;
        PlayerPrefs.SetInt("int_transtion",int_transtion); 
    }

    public void DeletSave (){
        PlayerPrefs.DeleteAll();
    }

    void Update (){
    real_text_level = PlayerPrefs.GetInt("real_text_level");
    int_skip_level = PlayerPrefs.GetInt("int_skip_level");
    int_transtion = PlayerPrefs.GetInt("int_transtion");
    int_randomize = PlayerPrefs.GetInt("int_randomize");
    int_level = PlayerPrefs.GetInt("int_level");

        // closed transtion panel
        if (int_transtion == 1){
        float_timer += Time.deltaTime;
        if (float_timer >= 0.12){
            transtion_object.SetActive(false);
            float_timer = 0;
            int_transtion = 0;
            PlayerPrefs.SetInt("int_transtion",int_transtion);  
        }
        }

        // GOOD open transtion panel
        if (int_transtion == 2){
            transtion_object.SetActive(true);
            transtion_anim.Play("trastion_open");
            int_transtion = 3;
            PlayerPrefs.SetInt("int_transtion",int_transtion); 
        }

        if (int_transtion == 3){
        float_timer += Time.deltaTime;
        if (float_timer >= 0.12){
            float_timer = 0;
            int_transtion = 0;
            PlayerPrefs.SetInt("int_trastion",int_transtion); 

            if (int_randomize == 0){
            int_level += 1;
            PlayerPrefs.SetInt("int_level",int_level); 
            }

            if (int_randomize == 1){
            int_level = Random.Range(10, 50);
            PlayerPrefs.SetInt("int_level",int_level);  
            }

            real_text_level += 1;
            PlayerPrefs.SetInt("real_text_level",real_text_level); 

            SceneManager.LoadScene("Protothype_Scene");
        }
        }

        // BAD open transtion panel
        if (int_transtion == 5){
            transtion_object.SetActive(true);
            transtion_anim.Play("trastion_open");
            int_transtion = 6;
            PlayerPrefs.SetInt("int_transtion",int_transtion); 
        }

        if (int_transtion == 6){
        float_timer += Time.deltaTime;
        if (float_timer >= 1){
            float_timer = 0;
            int_transtion = 0;
            PlayerPrefs.SetInt("int_trastion",int_transtion); 
            SceneManager.LoadScene("Protothype_Scene");
        }
        }
    }
}
