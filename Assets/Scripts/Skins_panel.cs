using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class Skins_panel : MonoBehaviour
{
public int Money;
public TextMeshProUGUI Money_text;

public GameObject No_hat;
public int int_no_hat;

public GameObject Hat_cylinder;
public GameObject Hide_hat_cylinder;
public int int_hat_cylinder;
public int int_hat_cylinder_special;

public GameObject Hat_shlapa;
public GameObject Hide_hat_shlapa;
public int int_hat_shlapa;
public int int_hat_shlapa_special;

public GameObject Hat_headphones;
public GameObject Hide_hat_headphones;
public int int_hat_headphones;
public int int_hat_headphones_special;

public GameObject Hat_kepka;
public GameObject Hide_hat_kepka;
public int int_hat_kepka;
public int int_hat_kepka_special;

public GameObject Hat_sombrero;
public GameObject Hide_hat_sombrero;
public int int_hat_sombrero;
public int int_hat_sombrero_special;

public GameObject Hat_crown;
public GameObject Hide_hat_crown;
public int int_hat_crown;
public int int_hat_crown_special;

public GameObject Hat_znak;
public GameObject Hide_hat_znak;
public int int_hat_znak;
public int int_hat_znak_special;

public GameObject Hat_helowyn;
public GameObject Hide_hat_helowyn;
public int int_hat_helowyn;
public int int_hat_helowyn_special;

public GameObject Cylinder;
public GameObject Shlapa;
public GameObject Headphones;
public GameObject Kepka;
public GameObject Sombrero;
public GameObject Crown;
public GameObject Znak;
public GameObject Helowyn;

// vip or offvip
public GameObject Buy_skins;
public GameObject Reward_skins;
public GameObject Reward_skins_vip;

public GameObject Skins;
public GameObject Vip;

// ad reward
private string RewardedUnitId = "ca-app-pub-5084433675560306/6656150566";
private RewardedAd rewardedAd;
public int int_bonus_hat;
public EndManager restart;

private void OnEnable()
{
    rewardedAd = new RewardedAd(RewardedUnitId);
    AdRequest adRequest = new AdRequest.Builder().Build();
    rewardedAd.LoadAd(adRequest);
    rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
}

// показ рекламы
public void ShowAd()
{
    if (int_hat_cylinder == 1 || int_hat_shlapa == 1 || int_hat_headphones == 1 || int_hat_kepka == 1 || int_hat_sombrero == 1){
    AdRequest adRequest = new AdRequest.Builder().Build();
    rewardedAd.LoadAd(adRequest);

    if (rewardedAd.IsLoaded())
        rewardedAd.Show();
    }
}

// награда по рекламе
private void HandleUserEarnedReward(object sender, Reward e)
{
    if (int_hat_cylinder == 1){
        int_hat_cylinder = 2;
        int_hat_cylinder_special = 1;
        Hide_hat_cylinder.SetActive(false);
    }

    if (int_hat_shlapa == 1){
        int_hat_shlapa = 2;
        int_hat_shlapa_special = 1;
        Hide_hat_shlapa.SetActive(false);
    }

    if (int_hat_headphones == 1){
        int_hat_headphones = 2;
        int_hat_headphones_special = 1;
        Hide_hat_headphones.SetActive(false);
    }

    if (int_hat_kepka == 1){
        int_hat_kepka = 2;
        int_hat_kepka_special = 1;
        Hide_hat_kepka.SetActive(false);
    }

    if (int_hat_sombrero == 1){
        int_hat_sombrero = 2;
        int_hat_sombrero_special = 1;
        Hide_hat_sombrero.SetActive(false);
    }

    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 

    PlayerPrefs.SetInt("int_hat_cylinder_special",int_hat_cylinder_special); 
    PlayerPrefs.SetInt("int_hat_shlapa_special",int_hat_shlapa_special); 
    PlayerPrefs.SetInt("int_hat_headphones_special",int_hat_headphones_special); 
    PlayerPrefs.SetInt("int_hat_kepka_special",int_hat_kepka_special); 
    PlayerPrefs.SetInt("int_hat_sombrero_special",int_hat_sombrero_special);  
}

public void buy (){
    if (int_hat_cylinder == 1){
    if (Money >= 1000){
        Money -= 1000;
        int_hat_cylinder = 2;
        int_hat_cylinder_special = 1;
        Hide_hat_cylinder.SetActive(false);

        PlayerPrefs.SetInt("Money",Money);
    }
    }

    if (int_hat_shlapa == 1){
    if (Money >= 1000){
        Money -= 1000;
        int_hat_shlapa = 2;
        int_hat_shlapa_special = 1;
        Hide_hat_shlapa.SetActive(false);

        PlayerPrefs.SetInt("Money",Money);
    }
    }

    if (int_hat_headphones == 1){
    if (Money >= 1000){
        Money -= 1000;
        int_hat_headphones = 2;
        int_hat_headphones_special = 1;
        Hide_hat_headphones.SetActive(false);

        PlayerPrefs.SetInt("Money",Money);
    }
    }

    if (int_hat_kepka == 1){
    if (Money >= 1000){
        Money -= 1000;
        int_hat_kepka = 2;
        int_hat_kepka_special = 1;
        Hide_hat_kepka.SetActive(false);

        PlayerPrefs.SetInt("Money",Money);
    }
    }

    if (int_hat_sombrero == 1){
    if (Money >= 1000){
        Money -= 1000;
        int_hat_sombrero = 2;
        int_hat_sombrero_special = 1;
        Hide_hat_sombrero.SetActive(false);

        PlayerPrefs.SetInt("Money",Money);
    }
    }

    if (int_hat_crown == 1){
    Vip.SetActive(true);
    Skins.SetActive(false);
    }

    if (int_hat_znak == 1){
    Vip.SetActive(true);
    Skins.SetActive(false);
    }

    if (int_hat_helowyn == 1){
    Vip.SetActive(true);
    Skins.SetActive(false);
    }

    PlayerPrefs.SetInt("Money",Money);
    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 
 
    PlayerPrefs.SetInt("int_hat_crown_special",int_hat_crown_special);
    PlayerPrefs.SetInt("int_hat_cylinder_special",int_hat_cylinder_special); 
    PlayerPrefs.SetInt("int_hat_shlapa_special",int_hat_shlapa_special); 
    PlayerPrefs.SetInt("int_hat_headphones_special",int_hat_headphones_special); 
    PlayerPrefs.SetInt("int_hat_kepka_special",int_hat_kepka_special); 
    PlayerPrefs.SetInt("int_hat_sombrero_special",int_hat_sombrero_special); 
    PlayerPrefs.SetInt("int_hat_znak_special",int_hat_znak_special); 
    PlayerPrefs.SetInt("int_hat_helowyn_special",int_hat_helowyn_special); 
}

public void hat_button (){
    int_no_hat = 2;
    int_hat_cylinder = 0;
    int_hat_shlapa = 0;
    int_hat_headphones = 0;
    int_hat_kepka = 0;
    int_hat_sombrero = 0;
    int_hat_crown = 0;
    int_hat_znak = 0;
    int_hat_helowyn = 0;
    
    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

}

public void no_hat_button (){
    if (int_no_hat < 2){
    int_no_hat = 1;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Buy_skins.SetActive(true);
    Reward_skins.SetActive(true);
    Reward_skins_vip.SetActive(false);

}

public void hat_cylinder_button (){
    int_no_hat = 0;
    int_hat_cylinder = 2;
    int_hat_shlapa = 0;
    int_hat_headphones = 0;
    int_hat_kepka = 0;
    int_hat_sombrero = 0;
    int_hat_crown = 0;
    int_hat_znak = 0;
    int_hat_helowyn = 0;

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

}

public void no_hat_cylinder_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 1;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn);

    Buy_skins.SetActive(true);
    Reward_skins.SetActive(true);
    Reward_skins_vip.SetActive(false); 
}

public void hat_shala_button (){
    int_no_hat = 0;
    int_hat_cylinder = 0;
    int_hat_shlapa = 2;
    int_hat_headphones = 0;
    int_hat_kepka = 0;
    int_hat_sombrero = 0;
    int_hat_crown = 0;
    int_hat_znak = 0;
    int_hat_helowyn = 0;

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

}

public void no_hat_shlapa_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 1;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Buy_skins.SetActive(true);
    Reward_skins.SetActive(true);
    Reward_skins_vip.SetActive(false);
}

public void hat_headphones_button (){
    int_no_hat = 0;
    int_hat_cylinder = 0;
    int_hat_shlapa = 0;
    int_hat_headphones = 2;
    int_hat_kepka = 0;
    int_hat_sombrero = 0;
    int_hat_crown = 0;
    int_hat_znak = 0;
    int_hat_helowyn = 0;

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 
}

public void no_hat_headphones_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 1;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Buy_skins.SetActive(true);
    Reward_skins.SetActive(true);
    Reward_skins_vip.SetActive(false);
}

public void hat_kepka_button (){
    int_no_hat = 0;
    int_hat_cylinder = 0;
    int_hat_shlapa = 0;
    int_hat_headphones = 0;
    int_hat_kepka = 2;
    int_hat_sombrero = 0;
    int_hat_crown = 0;
    int_hat_znak = 0;
    int_hat_helowyn = 0;

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn);  
}

public void no_hat_kepka_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 1;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    } 

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Buy_skins.SetActive(true);
    Reward_skins.SetActive(true);
    Reward_skins_vip.SetActive(false);
}

public void hat_sombrero_button (){
    int_no_hat = 0;
    int_hat_cylinder = 0;
    int_hat_shlapa = 0;
    int_hat_headphones = 0;
    int_hat_kepka = 0;
    int_hat_sombrero = 2;
    int_hat_crown = 0;
    int_hat_znak = 0;
    int_hat_helowyn = 0;

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn);  
}

public void no_hat_sombrero_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 1;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Buy_skins.SetActive(true);
    Reward_skins.SetActive(true);
    Reward_skins_vip.SetActive(false);
}

public void hat_crown_button (){
    int_no_hat = 0;
    int_hat_cylinder = 0;
    int_hat_shlapa = 0;
    int_hat_headphones = 0;
    int_hat_kepka = 0;
    int_hat_sombrero = 0;
    int_hat_crown = 2;
    int_hat_znak = 0;
    int_hat_helowyn = 0;

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 
}

public void no_hat_crown_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 1;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    }
    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn);

    Buy_skins.SetActive(false);
    Reward_skins.SetActive(false);
    Reward_skins_vip.SetActive(true);  
}

public void hat_znak_button (){
    int_no_hat = 0;
    int_hat_cylinder = 0;
    int_hat_shlapa = 0;
    int_hat_headphones = 0;
    int_hat_kepka = 0;
    int_hat_sombrero = 0;
    int_hat_crown = 0;
    int_hat_znak = 2;
    int_hat_helowyn = 0;

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 
}

public void no_hat_znak_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 1;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 0;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Buy_skins.SetActive(false);
    Reward_skins.SetActive(false);
    Reward_skins_vip.SetActive(true);
}

public void hat_helowyn_button (){
    int_no_hat = 0;
    int_hat_cylinder = 0;
    int_hat_shlapa = 0;
    int_hat_headphones = 0;
    int_hat_kepka = 0;
    int_hat_sombrero = 0;
    int_hat_crown = 0;
    int_hat_znak = 0;
    int_hat_helowyn = 2;
    
    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown);
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn);  
}

public void no_hat_helowyn_button (){
    if (int_no_hat < 2){
    int_no_hat = 0;
    }
    if (int_hat_cylinder < 2){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa < 2){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones < 2){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka < 2){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero < 2){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown < 2){
    int_hat_crown = 0;
    }
    if (int_hat_znak < 2){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn < 2){
    int_hat_helowyn = 1;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Buy_skins.SetActive(false);
    Reward_skins.SetActive(false);
    Reward_skins_vip.SetActive(true);
}

public void Back (){
    if (int_no_hat == 1){
    int_no_hat = 0;
    }
    if (int_hat_cylinder == 1){
    int_hat_cylinder = 0;
    }
    if (int_hat_shlapa == 1){
    int_hat_shlapa = 0;
    }
    if (int_hat_headphones == 1){
    int_hat_headphones = 0;
    }
    if (int_hat_kepka == 1){
    int_hat_kepka = 0;
    }
    if (int_hat_sombrero == 1){
    int_hat_sombrero = 0;
    }
    if (int_hat_crown == 1){
    int_hat_crown = 0;
    }
    if (int_hat_znak == 1){
    int_hat_znak = 0;
    }
    if (int_hat_helowyn == 1){
    int_hat_helowyn = 0;
    }

    PlayerPrefs.SetInt("int_no_hat",int_no_hat); 
    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
    PlayerPrefs.SetInt("int_hat_cylinder",int_hat_cylinder); 
    PlayerPrefs.SetInt("int_hat_shlapa",int_hat_shlapa); 
    PlayerPrefs.SetInt("int_hat_headphones",int_hat_headphones); 
    PlayerPrefs.SetInt("int_hat_kepka",int_hat_kepka); 
    PlayerPrefs.SetInt("int_hat_sombrero",int_hat_sombrero); 
    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

    Skins.SetActive(false);
}

void Update (){
int_bonus_hat = PlayerPrefs.GetInt("int_bonus_hat");

int_hat_cylinder = PlayerPrefs.GetInt("int_hat_cylinder");
int_hat_shlapa = PlayerPrefs.GetInt("int_hat_shlapa");
int_hat_headphones = PlayerPrefs.GetInt("int_hat_headphones");
int_hat_kepka = PlayerPrefs.GetInt("int_hat_kepka");
int_hat_sombrero = PlayerPrefs.GetInt("int_hat_sombrero");
int_hat_crown = PlayerPrefs.GetInt("int_hat_crown");
int_hat_znak = PlayerPrefs.GetInt("int_hat_znak");
int_hat_helowyn = PlayerPrefs.GetInt("int_hat_helowyn");
int_no_hat = PlayerPrefs.GetInt("int_no_hat");

int_hat_cylinder_special = PlayerPrefs.GetInt("int_hat_cylinder_special");
int_hat_shlapa_special = PlayerPrefs.GetInt("int_hat_shlapa_special");
int_hat_headphones_special = PlayerPrefs.GetInt("int_hat_headphones_special");
int_hat_kepka_special = PlayerPrefs.GetInt("int_hat_kepka_special");
int_hat_sombrero_special = PlayerPrefs.GetInt("int_hat_sombrero_special");
int_hat_crown_special = PlayerPrefs.GetInt("int_hat_crown_special");
int_hat_znak_special = PlayerPrefs.GetInt("int_hat_znak_special");
int_hat_helowyn_special = PlayerPrefs.GetInt("int_hat_helowyn_special");

Money = PlayerPrefs.GetInt("Money");
Money_text.text = Money.ToString();

    // ads 

    // получить корону за рекламу
    if (int_bonus_hat == 1){
        int_hat_crown_special = 1;
        int_hat_crown = 2;
        int_bonus_hat = 0;
        PlayerPrefs.SetInt("int_hat_crown_special",int_hat_crown_special); 
        PlayerPrefs.SetInt("int_bonus_hat",int_bonus_hat); 
        PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 

        restart.Restart();
    }

    // получить конус за рекламу
    if (int_bonus_hat == 2){
        int_hat_znak_special = 1;
        int_hat_znak = 2;
        int_bonus_hat = 0;
        PlayerPrefs.SetInt("int_hat_znak_special",int_hat_znak_special); 
        PlayerPrefs.SetInt("int_bonus_hat",int_bonus_hat); 
        PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 

        restart.Restart();
    }

    // получить хелоунискую шляпу за рекламу
    if (int_bonus_hat == 3){
        int_hat_helowyn_special = 1;
        int_hat_helowyn = 2;
        int_bonus_hat = 0;
        PlayerPrefs.SetInt("int_hat_helowyn_special",int_hat_helowyn_special); 
        PlayerPrefs.SetInt("int_bonus_hat",int_bonus_hat); 
        PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 

        restart.Restart();
    }

    if (int_no_hat == 2){
    Cylinder.SetActive(false);
    Shlapa.SetActive(false);
    Headphones.SetActive(false);
    Kepka.SetActive(false);
    Sombrero.SetActive(false);
    Crown.SetActive(false);
    Znak.SetActive(false);
    Helowyn.SetActive(false);
    }

    if (int_hat_cylinder == 2){
    Hide_hat_cylinder.SetActive(false);

    Cylinder.SetActive(true);
    Shlapa.SetActive(false);
    Headphones.SetActive(false);
    Kepka.SetActive(false);
    Sombrero.SetActive(false);
    Crown.SetActive(false);
    Znak.SetActive(false);
    Helowyn.SetActive(false);
    }

    if (int_hat_shlapa == 2){
    Hide_hat_shlapa.SetActive(false);

    Cylinder.SetActive(false);
    Shlapa.SetActive(true);
    Headphones.SetActive(false);
    Kepka.SetActive(false);
    Sombrero.SetActive(false);
    Crown.SetActive(false);
    Znak.SetActive(false);
    Helowyn.SetActive(false);
    }

    if (int_hat_headphones == 2){
    Hide_hat_headphones.SetActive(false);

    Cylinder.SetActive(false);
    Shlapa.SetActive(false);
    Headphones.SetActive(true);
    Kepka.SetActive(false);
    Sombrero.SetActive(false);
    Crown.SetActive(false);
    Znak.SetActive(false);
    Helowyn.SetActive(false);
    }

    if (int_hat_kepka == 2){
    Hide_hat_kepka.SetActive(false);

    Cylinder.SetActive(false);
    Shlapa.SetActive(false);
    Headphones.SetActive(false);
    Kepka.SetActive(true);
    Sombrero.SetActive(false);
    Crown.SetActive(false);
    Znak.SetActive(false);
    Helowyn.SetActive(false);
    }

    if (int_hat_sombrero == 2){
    Hide_hat_sombrero.SetActive(false);

    Cylinder.SetActive(false);
    Shlapa.SetActive(false);
    Headphones.SetActive(false);
    Kepka.SetActive(false);
    Sombrero.SetActive(true);
    Crown.SetActive(false);
    Znak.SetActive(false);
    Helowyn.SetActive(false);
    }

    if (int_hat_crown == 2){
    Hide_hat_crown.SetActive(false);

    Cylinder.SetActive(false);
    Shlapa.SetActive(false);
    Headphones.SetActive(false);
    Kepka.SetActive(false);
    Sombrero.SetActive(false);
    Crown.SetActive(true);
    Znak.SetActive(false);
    Helowyn.SetActive(false);
    }

    if (int_hat_znak == 2){
    Hide_hat_znak.SetActive(false);

    Cylinder.SetActive(false);
    Shlapa.SetActive(false);
    Headphones.SetActive(false);
    Kepka.SetActive(false);
    Sombrero.SetActive(false);
    Crown.SetActive(false);
    Znak.SetActive(true);
    Helowyn.SetActive(false);
    }

    if (int_hat_helowyn == 2){
    Hide_hat_helowyn.SetActive(false);

    Cylinder.SetActive(false);
    Shlapa.SetActive(false);
    Headphones.SetActive(false);
    Kepka.SetActive(false);
    Sombrero.SetActive(false);
    Crown.SetActive(false);
    Znak.SetActive(false);
    Helowyn.SetActive(true);
    }

    // ----------

    if (int_hat_cylinder_special >= 1){
    Hide_hat_cylinder.SetActive(false);  
    }
    if (int_hat_shlapa_special >= 1){
    Hide_hat_shlapa.SetActive(false);    
    }
    if (int_hat_headphones_special >= 1){
    Hide_hat_headphones.SetActive(false);    
    }
    if (int_hat_kepka_special >= 1){
    Hide_hat_kepka.SetActive(false);        
    }
    if (int_hat_sombrero_special >= 1){
    Hide_hat_sombrero.SetActive(false);     
    }
    if (int_hat_crown_special >= 1){
    Hide_hat_crown.SetActive(false);     
    }
    if (int_hat_znak_special >= 1){
    Hide_hat_znak.SetActive(false);  
    }
    if (int_hat_helowyn_special >= 1){
    Hide_hat_helowyn.SetActive(false);
    }

// end update
}
}


