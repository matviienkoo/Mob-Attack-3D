using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
public GameObject End_Scene;

public Animation flag_agressor_1;
public Animation flag_my_1;

public Animation flag_agressor_2;
public Animation flag_my_2;

public Animation flag_agressor_3;
public Animation flag_my_3;

public Animation flag_agressor_4;
public Animation flag_my_4;

public Animation flag_agressor_5;
public Animation flag_my_5;

public Animation flag_agressor_6;
public Animation flag_my_6;

public Animation flag_agressor_7;
public Animation flag_my_7;

public Animation flag_agressor_8;
public Animation flag_my_8;

public Animation flag_agressor_9;
public Animation flag_my_9;

public Animation flag_agressor_10;
public Animation flag_my_10;

public Animation flag_agressor_11;
public Animation flag_my_11;

public Animation flag_agressor_12;
public Animation flag_my_12;

public Animation flag_agressor_13;
public Animation flag_my_13;

public Animation flag_agressor_14;
public Animation flag_my_14;

public Animation flag_agressor_15;
public Animation flag_my_15;

public Animation flag_agressor_16;
public Animation flag_my_16;

public Animation flag_agressor_17;
public Animation flag_my_17;

public Animation flag_agressor_18;
public Animation flag_my_18;

public Animation flag_agressor_19;
public Animation flag_my_19;

public Animation flag_agressor_20;
public Animation flag_my_20;

public Animation flag_agressor_21;
public Animation flag_my_21;

public Animation flag_agressor_22;
public Animation flag_my_22;

public Animation flag_agressor_23;
public Animation flag_my_23;

public Animation flag_agressor_24;
public Animation flag_my_24;

public Animation flag_agressor_25;
public Animation flag_my_25;

public Animation flag_agressor_26;
public Animation flag_my_26;

public Animation flag_agressor_27;
public Animation flag_my_27;

public Animation flag_agressor_28;
public Animation flag_my_28;

public Animation flag_agressor_29;
public Animation flag_my_29;

public Animation flag_agressor_30;
public Animation flag_my_30;

public Animation flag_agressor_31;
public Animation flag_my_31;

public Animation flag_agressor_32;
public Animation flag_my_32;

public Animation flag_agressor_33;
public Animation flag_my_33;

public Animation flag_agressor_34;
public Animation flag_my_34;

public Animation flag_agressor_35;
public Animation flag_my_35;

public Animation flag_agressor_36;
public Animation flag_my_36;

public Animation flag_agressor_37;
public Animation flag_my_37;

public Animation flag_agressor_38;
public Animation flag_my_38;

public Animation flag_agressor_39;
public Animation flag_my_39;

public Animation flag_agressor_40;
public Animation flag_my_40;

public Animation flag_agressor_41;
public Animation flag_my_41;

public Animation flag_agressor_42;
public Animation flag_my_42;

public Animation flag_agressor_43;
public Animation flag_my_43;

public Animation flag_agressor_44;
public Animation flag_my_44;

public Animation flag_agressor_45;
public Animation flag_my_45;

public Animation flag_agressor_46;
public Animation flag_my_46;

public Animation flag_agressor_47;
public Animation flag_my_47;

public Animation flag_agressor_48;
public Animation flag_my_48;

public Animation flag_agressor_49;
public Animation flag_my_49;

public Animation flag_agressor_50;
public Animation flag_my_50;

public int end_int;
public float timer;

public Animation restart_anim;

public int int_level;
public int Loaded_level;

public int real_text_level;
public TextMeshProUGUI text_level;

// levels
public GameObject Game_Level_1;
public GameObject Game_Level_2;
public GameObject Game_Level_3;
public GameObject Game_Level_4;
public GameObject Game_Level_5;
public GameObject Game_Level_6;
public GameObject Game_Level_7;
public GameObject Game_Level_8;
public GameObject Game_Level_9;
public GameObject Game_Level_10;
public GameObject Game_Level_11;
public GameObject Game_Level_12;
public GameObject Game_Level_13;
public GameObject Game_Level_14;
public GameObject Game_Level_15;
public GameObject Game_Level_16;
public GameObject Game_Level_17;
public GameObject Game_Level_18;
public GameObject Game_Level_19;
public GameObject Game_Level_20;
public GameObject Game_Level_21;
public GameObject Game_Level_22;
public GameObject Game_Level_23;
public GameObject Game_Level_24;
public GameObject Game_Level_25;
public GameObject Game_Level_26;
public GameObject Game_Level_27;
public GameObject Game_Level_28;
public GameObject Game_Level_29;
public GameObject Game_Level_30;
public GameObject Game_Level_31;
public GameObject Game_Level_32;
public GameObject Game_Level_33;
public GameObject Game_Level_34;
public GameObject Game_Level_35;
public GameObject Game_Level_36;
public GameObject Game_Level_37;
public GameObject Game_Level_38;
public GameObject Game_Level_39;
public GameObject Game_Level_40;
public GameObject Game_Level_41;
public GameObject Game_Level_42;
public GameObject Game_Level_43;
public GameObject Game_Level_44;
public GameObject Game_Level_45;
public GameObject Game_Level_46;
public GameObject Game_Level_47;
public GameObject Game_Level_48;
public GameObject Game_Level_49;
public GameObject Game_Level_50;

// audio 
public AudioSource Win_audio;
public int Music_int;

// langugage
public Text contry_text;
int contry_int;

// skip level
public GameObject skip_panel;
public int int_skip_level;

// transtion system
public int int_transtion;
public int int_randomize;

void Start (){
    real_text_level = PlayerPrefs.GetInt("real_text_level");
    int_skip_level = PlayerPrefs.GetInt("int_skip_level");
    int_randomize = PlayerPrefs.GetInt("int_randomize");
    int_level = PlayerPrefs.GetInt("int_level");
    PlayerPrefs.DeleteKey("Loaded_level");

    if (int_level == 1){
        Game_Level_1.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }
    if (int_level == 2){
        Game_Level_2.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }
    if (int_level == 3){
        Game_Level_3.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 4){
        Game_Level_4.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 5){
        Game_Level_5.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 6){
        Game_Level_6.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 7){
        Game_Level_7.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 8){
        Game_Level_8.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 9){
        Game_Level_9.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 10){
        Game_Level_10.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 11){
        Game_Level_11.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 12){
        Game_Level_12.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 13){
        Game_Level_13.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 14){
        Game_Level_14.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 15){
        Game_Level_15.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 16){
        Game_Level_16.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 17){
        Game_Level_17.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 18){
        Game_Level_18.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 19){
        Game_Level_19.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 20){
        Game_Level_20.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }


    if (int_level == 21){
        Game_Level_21.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }


    if (int_level == 22){
        Game_Level_22.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 23){
        Game_Level_23.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }


    if (int_level == 24){
        Game_Level_24.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }


    if (int_level == 25){
        Game_Level_25.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 26){
        Game_Level_26.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 27){
        Game_Level_27.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 28){
        Game_Level_28.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 29){
        Game_Level_29.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 30){
        Game_Level_30.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 31){
        Game_Level_31.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 32){
        Game_Level_32.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 33){
        Game_Level_33.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 34){
        Game_Level_34.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 35){
        Game_Level_35.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 36){
        Game_Level_36.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 37){
        Game_Level_37.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 38){
        Game_Level_38.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 39){
        Game_Level_39.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 40){
        Game_Level_40.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 41){
        Game_Level_41.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 42){
        Game_Level_42.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 43){
        Game_Level_43.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 44){
        Game_Level_44.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 45){
        Game_Level_45.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 46){
        Game_Level_46.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 47){
        Game_Level_47.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 48){
        Game_Level_48.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 49){
        Game_Level_49.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        } 
    }

    if (int_level == 50){
        Game_Level_50.SetActive(true);

        if (Loaded_level <= 0){
        Loaded_level = 1;
        PlayerPrefs.SetInt("Loaded_level",Loaded_level); 
        }
    }

    if (int_level == 51){
        int_randomize = 1;
        PlayerPrefs.SetInt("int_randomize",int_randomize); 

        int_level = Random.Range(10, 50);
        PlayerPrefs.SetInt("int_level",int_level); 
    }

    if (real_text_level <= 0){
    real_text_level = 1;
    PlayerPrefs.SetInt("real_text_level",real_text_level); 
    }

    if (int_level <= 0){
    int_level = 1;
    PlayerPrefs.SetInt("int_level",int_level); 
    }

    if (int_skip_level >= 3){
    skip_panel.SetActive(true);

    int_skip_level = 0;
    PlayerPrefs.SetInt("int_skip_level",int_skip_level); 
    }
}

public void No (){
    int_skip_level = 0;
    PlayerPrefs.SetInt("int_skip_level",int_skip_level); 

    skip_panel.SetActive(false);
}

public void Restart (){
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

public void Restart_bad (){
    int_skip_level += 1;
    PlayerPrefs.SetInt("int_skip_level",int_skip_level); 

    SceneManager.LoadScene("Protothype_Scene");
}

void Update (){ 
int_skip_level = PlayerPrefs.GetInt("int_skip_level");
int_randomize = PlayerPrefs.GetInt("int_randomize");
int_transtion = PlayerPrefs.GetInt("int_transtion");
Loaded_level = PlayerPrefs.GetInt("Loaded_level");
Music_int = PlayerPrefs.GetInt("Music_int");
end_int = PlayerPrefs.GetInt("end_int");

    int_level = PlayerPrefs.GetInt("int_level");
    real_text_level = PlayerPrefs.GetInt("real_text_level");
    if (contry_text.text == "United Kingdom"){
    text_level.text = "Level " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Russia"){
    text_level.text = "Уровень " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Ukraine"){
    text_level.text = "Рівень " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Canada"){
    text_level.text = "Level " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "United States"){
    text_level.text = "Level " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Netherlands"){
    text_level.text = "Niveau " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Italy"){
    text_level.text = "Livello " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Germany"){
    text_level.text = "Ebene " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "France"){
    text_level.text = "Niveau " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Austria"){
    text_level.text = "Ebene " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Sweden"){
    text_level.text = "Nivå " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Norway"){
    text_level.text = "Nivå " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Finland"){
    text_level.text = "Taso " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Denmark"){
    text_level.text = "Niveau " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Czech Republic"){
    text_level.text = "Úroveň " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Slovakia"){
    text_level.text = "Úroveň " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Hungary"){
    text_level.text = "Szint " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Bulgaria"){
    text_level.text = "Ниво " + real_text_level.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Spain"){
    text_level.text = "Nivel " + real_text_level.ToString();
    contry_int = 1;
    }

    if (contry_int == 0){
    text_level.text = "Level " + real_text_level.ToString();
    contry_int = 1;
    }

    // Подмена флага
    if (end_int == 1){
        if (int_level == 1){
        flag_agressor_1.Play();
        }
        if (int_level == 2){
        flag_agressor_2.Play();
        }
        if (int_level == 3){
        flag_agressor_3.Play();
        }
        if (int_level == 4){
        flag_agressor_4.Play();
        }
        if (int_level == 5){
        flag_agressor_5.Play();
        }
        if (int_level == 6){
        flag_agressor_6.Play();
        }
        if (int_level == 7){
        flag_agressor_7.Play();
        }
        if (int_level == 8){
        flag_agressor_8.Play();
        }
        if (int_level == 9){
        flag_agressor_9.Play();
        }
        if (int_level == 10){
        flag_agressor_10.Play();
        }
        if (int_level == 11){
        flag_agressor_11.Play();
        }
        if (int_level == 12){
        flag_agressor_12.Play();
        }
        if (int_level == 13){
        flag_agressor_13.Play();
        }
        if (int_level == 14){
        flag_agressor_14.Play();
        }
        if (int_level == 15){
        flag_agressor_15.Play();
        }
        if (int_level == 16){
        flag_agressor_16.Play();
        }
        if (int_level == 17){
        flag_agressor_17.Play();
        }
        if (int_level == 18){
        flag_agressor_18.Play();
        }
        if (int_level == 19){
        flag_agressor_19.Play();
        }
        if (int_level == 20){
        flag_agressor_20.Play();
        }
        if (int_level == 21){
        flag_agressor_21.Play();
        }
        if (int_level == 22){
        flag_agressor_22.Play();
        }
        if (int_level == 23){
        flag_agressor_23.Play();
        }
        if (int_level == 24){
        flag_agressor_24.Play();
        }
        if (int_level == 25){
        flag_agressor_25.Play();
        }
        if (int_level == 26){
        flag_agressor_26.Play();
        }
        if (int_level == 27){
        flag_agressor_27.Play();
        }
        if (int_level == 28){
        flag_agressor_28.Play();
        }
        if (int_level == 29){
        flag_agressor_29.Play();
        }
        if (int_level == 30){
        flag_agressor_30.Play();
        }
        if (int_level == 31){
        flag_agressor_31.Play();
        }
        if (int_level == 32){
        flag_agressor_32.Play();
        }
        if (int_level == 33){
        flag_agressor_33.Play();
        }
        if (int_level == 34){
        flag_agressor_34.Play();
        }
        if (int_level == 35){
        flag_agressor_35.Play();
        }
        if (int_level == 36){
        flag_agressor_36.Play();
        }
        if (int_level == 37){
        flag_agressor_37.Play();
        }
        if (int_level == 38){
        flag_agressor_38.Play();
        }
        if (int_level == 39){
        flag_agressor_39.Play();
        }
        if (int_level == 40){
        flag_agressor_40.Play();
        }
        if (int_level == 41){
        flag_agressor_41.Play();
        }
        if (int_level == 42){
        flag_agressor_42.Play();
        }
        if (int_level == 43){
        flag_agressor_43.Play();
        }
        if (int_level == 44){
        flag_agressor_44.Play();
        }
        if (int_level == 45){
        flag_agressor_45.Play();
        }
        if (int_level == 46){
        flag_agressor_46.Play();
        }
        if (int_level == 47){
        flag_agressor_47.Play();
        }
        if (int_level == 48){
        flag_agressor_48.Play();
        }
        if (int_level == 49){
        flag_agressor_49.Play();
        }
        if (int_level == 50){
        flag_agressor_50.Play();
        }

        if (Music_int == 0){
        Win_audio.Play();
        }
        
        end_int = 2;
        PlayerPrefs.SetInt("end_int",end_int);
    }

    if (end_int == 2){
        timer += Time.deltaTime; 
        if (timer >= 1){
            if (int_level == 1){
            flag_my_1.Play();
            }
            if (int_level == 2){
            flag_my_2.Play();
            }
            if (int_level == 3){
            flag_my_3.Play();
            }
            if (int_level == 4){
            flag_my_4.Play();
            }
            if (int_level == 5){
            flag_my_5.Play();
            }
            if (int_level == 6){
            flag_my_6.Play();
            }
            if (int_level == 7){
            flag_my_7.Play();
            }
            if (int_level == 8){
            flag_my_8.Play();
            }
            if (int_level == 9){
            flag_my_9.Play();
            }
            if (int_level == 10){
            flag_my_10.Play();
            }
            if (int_level == 11){
            flag_my_11.Play();
            }
            if (int_level == 12){
            flag_my_12.Play();
            }
            if (int_level == 13){
            flag_my_13.Play();
            }
            if (int_level == 14){
            flag_my_14.Play();
            }
            if (int_level == 15){
            flag_my_15.Play();
            }
            if (int_level == 16){
            flag_my_16.Play();
            }
            if (int_level == 17){
            flag_my_17.Play();
            }
            if (int_level == 18){
            flag_my_18.Play();
            }
            if (int_level == 19){
            flag_my_19.Play();
            }
            if (int_level == 20){
            flag_my_20.Play();
            }
            if (int_level == 21){
            flag_my_21.Play();
            }
            if (int_level == 22){
            flag_my_22.Play();
            }
            if (int_level == 23){
            flag_my_23.Play();
            }
            if (int_level == 24){
            flag_my_24.Play();
            }
            if (int_level == 25){
            flag_my_25.Play();
            }
            if (int_level == 26){
            flag_my_26.Play();
            }
            if (int_level == 27){
            flag_my_27.Play();
            }
            if (int_level == 28){
            flag_my_28.Play();
            }
            if (int_level == 29){
            flag_my_29.Play();
            }
            if (int_level == 30){
            flag_my_30.Play();
            }
            if (int_level == 31){
            flag_my_31.Play();
            }
            if (int_level == 32){
            flag_my_32.Play();
            }
            if (int_level == 33){
            flag_my_33.Play();
            }
            if (int_level == 34){
            flag_my_34.Play();
            }
            if (int_level == 35){
            flag_my_35.Play();
            }
            if (int_level == 36){
            flag_my_36.Play();
            }
            if (int_level == 37){
            flag_my_37.Play();
            }
            if (int_level == 38){
            flag_my_38.Play();
            }
            if (int_level == 39){
            flag_my_39.Play();
            }
            if (int_level == 40){
            flag_my_40.Play();
            }
            if (int_level == 41){
            flag_my_41.Play();
            }
            if (int_level == 42){
            flag_my_42.Play();
            }
            if (int_level == 43){
            flag_my_43.Play();
            }
            if (int_level == 44){
            flag_my_44.Play();
            }
            if (int_level == 45){
            flag_my_45.Play();
            }
            if (int_level == 46){
            flag_my_46.Play();
            }
            if (int_level == 47){
            flag_my_47.Play();
            }
            if (int_level == 48){
            flag_my_48.Play();
            }
            if (int_level == 49){
            flag_my_49.Play();
            }
            if (int_level == 50){
            flag_my_50.Play();
            }
        }
        if (timer >= 2){
            timer = 0;
            end_int = 0;
            PlayerPrefs.SetInt("end_int",end_int);

            if(End_Scene != null){
            End_Scene.SetActive(true);
            }
            restart_anim.Play();
        }
    } 

    // ВОСТАНОВЛЕНИЕ ПРОБЛЕМНОГО КОДА

    if (Loaded_level <= 0){
        SceneManager.LoadScene ("Protothype_Scene");
    }

    // end update
}

}


