using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class ShopManager : MonoBehaviour
{
    public int Money;
    public TextMeshProUGUI Money_text;

    // lifes
    public GameObject Player;
    public GameObject Bad_End;
    public GameObject Level_object;
    public int Life;
    public int Dead;

    public TextMeshProUGUI Text_Int_plus_money_for_bad_level;
    public int Int_plus_money_for_bad_level;
    int stop_money;

    public TextMeshProUGUI Text_plus_money_for_end_level;
    public int Int_plus_money_for_end_level;

    public TextMeshProUGUI Text_plus_money_for_ads;
    public int Int_plus_money_for_ads;

    // -- sword
    public int Price_Sword;
    public TextMeshProUGUI Price_Sword_text;
    public int Level_Sword;
    public TextMeshProUGUI Level_Sword_text;

    public int sword_prokacka;

    public GameObject sword_upg;
    public GameObject sword_dont_upg;

    public Button sword_incerantable;
    public GameObject sword_particle;
    public int int_sword_particle;
    float timer_float_sword_particle;

    // -- coins
    public int Price_Coins;
    public TextMeshProUGUI Price_Coins_text;
    public int Level_Coins;
    public TextMeshProUGUI Level_Coins_text;

    public GameObject coins_upg;
    public GameObject coins_dont_upg;

    public Button coin_incerantable;
    public GameObject coins_particle;
    public int int_coins_particle;
    float timer_float_coins_particle;

    // -- shield
    public int Price_Shield;
    public TextMeshProUGUI Price_Shield_text;
    public int Level_Shield;
    public TextMeshProUGUI Level_Shield_text;

    public int shield_prokacka;

    public GameObject shield_upg;
    public GameObject shield_dont_upg;
    
    public Button shield_incerantable;
    public GameObject shield_particle;
    public int int_shield_particle;
    float timer_float_shield_particle;

    // ---- Things_Swords
    public GameObject Sword_thing_1;
    public GameObject Sword_thing_2;
    public GameObject Sword_thing_3;
    public GameObject Sword_thing_4;
    public GameObject Sword_thing_5;
    public GameObject Sword_thing_6;
    public GameObject Sword_thing_7;
    public GameObject Sword_thing_8;
    public GameObject Sword_thing_9;
    public GameObject Sword_thing_10;
    public GameObject Sword_thing_11;
    public GameObject Sword_thing_12;
    public GameObject Sword_thing_13;
    public GameObject Sword_thing_14;
    public GameObject Sword_thing_15;
    public GameObject Sword_thing_16;

    // ---- Things_Shield
    public GameObject Shield_thing_1;
    public GameObject Shield_thing_2;
    public GameObject Shield_thing_3;
    public GameObject Shield_thing_4;
    public GameObject Shield_thing_5;
    public GameObject Shield_thing_6;
    public GameObject Shield_thing_7;
    public GameObject Shield_thing_8;
    public GameObject Shield_thing_9;
    public GameObject Shield_thing_10;
    public GameObject Shield_thing_11;
    public GameObject Shield_thing_12;
    public GameObject Shield_thing_13;
    public GameObject Shield_thing_14;
    public GameObject Shield_thing_15;
    public GameObject Shield_thing_16;
    public GameObject Shield_thing_17;
    public GameObject Shield_thing_18;

    // bonus
    public GameObject Good_End_Panel;
    public GameObject Bonus_Panel;
    public Slider Bonus_Slider;

    public TextMeshProUGUI Text_procent_bonus; 
    float int_procent_bonus;
    float int_procent_bonus_max = 100;

    public int int_prb;
    public GameObject Continue;
    public GameObject Take;
    public GameObject Take_no_thanks;

    public GameObject Hat_crown_bonus;
    public GameObject Hat_conus_bonus;
    public GameObject Hat_hallowyn_bonus;

    // ad reward
    private string RewardedUnitId = "ca-app-pub-5084433675560306/4277399238";
    private RewardedAd rewardedAd;

    public int int_bonus_hat;
    int reward_money_int;

    // audio
    public AudioSource Lose_audio;
    public AudioSource Buy_audiosorce;
    public GameObject Bonus_Sound;
    public GameObject Shach;

    // langugage
    public Text contry_text;
    public int contry_int;

    public int Music_int;

    void Start (){
        contry_text.text = RegionInfo.CurrentRegion.DisplayName;

        Int_plus_money_for_bad_level = PlayerPrefs.GetInt("Int_plus_money_for_bad_level");
        Int_plus_money_for_end_level = PlayerPrefs.GetInt("Int_plus_money_for_end_level");
        Int_plus_money_for_ads = PlayerPrefs.GetInt("Int_plus_money_for_ads");
        Music_int = PlayerPrefs.GetInt("Music_int");

        Price_Sword = PlayerPrefs.GetInt("Price_Sword");
        Price_Coins = PlayerPrefs.GetInt("Price_Coins");
        Price_Shield = PlayerPrefs.GetInt("Price_Shield");

        Level_Sword = PlayerPrefs.GetInt("Level_Sword");
        Level_Coins = PlayerPrefs.GetInt("Level_Coins");
        Level_Shield = PlayerPrefs.GetInt("Level_Shield");

        // sword
        if (Price_Sword == 0){
        Price_Sword = 150;
        PlayerPrefs.SetInt("Price_Sword",Price_Sword);
        }
        if (Level_Sword == 0){
        Level_Sword = 1;
        PlayerPrefs.SetInt("Level_Sword",Level_Sword);    
        }

        // coins
        if (Price_Coins == 0){
        Price_Coins = 150;
        PlayerPrefs.SetInt("Price_Coins",Price_Coins);
        }
        if (Level_Coins == 0){
        Level_Coins = 1;
        PlayerPrefs.SetInt("Level_Coins",Level_Coins);    
        }

        if (Int_plus_money_for_end_level < 300){
        Int_plus_money_for_end_level = 300;
        PlayerPrefs.SetInt("Int_plus_money_for_end_level",Int_plus_money_for_end_level);  
        }

        if (Int_plus_money_for_ads < 900){
        Int_plus_money_for_ads = 900;
        PlayerPrefs.SetInt("Int_plus_money_for_ads",Int_plus_money_for_ads);  
        }

        // shield
        if (Price_Shield == 0){
        Price_Shield = 150;
        PlayerPrefs.SetInt("Price_Shield",Price_Shield);
        }
        if (Level_Shield == 0){
        Level_Shield = 1;
        PlayerPrefs.SetInt("Level_Shield",Level_Shield);    
        }

        // bad level
        if (Int_plus_money_for_bad_level <= 0){
            Int_plus_money_for_bad_level = 50;
            PlayerPrefs.SetInt("Int_plus_money_for_bad_level",Int_plus_money_for_bad_level);
        }

    }

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
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);

        if (rewardedAd.IsLoaded())
            rewardedAd.Show();
    }

    // награда по рекламе
    private void HandleUserEarnedReward(object sender, Reward e)
    {
        // корона
        if (int_procent_bonus == 100){
        if (int_prb == 8){

            int_bonus_hat = 1;
            PlayerPrefs.SetInt("int_bonus_hat",int_bonus_hat);  
        }
        }

        // конус
        if (int_procent_bonus == 100){
        if (int_prb == 16){
            
            int_bonus_hat = 2;
            PlayerPrefs.SetInt("int_bonus_hat",int_bonus_hat);   
        }    
        }

        // хелоуин
        if (int_procent_bonus == 100){
        if (int_prb == 0){
            
            int_bonus_hat = 3;
            PlayerPrefs.SetInt("int_bonus_hat",int_bonus_hat);      
        } 
        }
    }

    public void Sword_Up_Level (){
        if (Money >= Price_Sword){
            Money -= Price_Sword;

            if(sword_particle != null){
            sword_particle.SetActive(true);
            } 

            int_sword_particle = 1;

            Price_Sword += 150;
            Level_Sword += 1;
            sword_prokacka += 1;

            PlayerPrefs.SetInt("Money",Money);  
            PlayerPrefs.SetInt("Level_Sword",Level_Sword);  
            PlayerPrefs.SetInt("Price_Sword",Price_Sword);  
            PlayerPrefs.SetInt("sword_prokacka",sword_prokacka);

            if (Music_int == 0){
            Buy_audiosorce.Play();
            }
            if (Music_int == 1){

            }
        }
    }

    public void Coin_Up_Level (){
        if (Money >= Price_Coins){
            Money -= Price_Coins;
            Int_plus_money_for_end_level += 60;
            Int_plus_money_for_ads += 180;
            Price_Coins += 150;
            Level_Coins += 1;

            if(coins_particle != null){
            coins_particle.SetActive(true);
            } 

            int_coins_particle = 1;

            PlayerPrefs.SetInt("Money",Money);  
            PlayerPrefs.SetInt("Level_Coins",Level_Coins);  
            PlayerPrefs.SetInt("Price_Coins",Price_Coins);  
            PlayerPrefs.SetInt("Int_plus_money_for_end_level",Int_plus_money_for_end_level);
            PlayerPrefs.SetInt("Int_plus_money_for_ads",Int_plus_money_for_ads);  

            if (Music_int == 0){
            Buy_audiosorce.Play();
            }
            if (Music_int == 1){
            
            }
        }        
    }

    public void Shield_Up_Level (){
        if (Money >= Price_Shield){
            Money -= Price_Shield;
            Price_Shield += 150;
            Level_Shield += 1;
            shield_prokacka += 1;

            if(shield_particle != null){
            shield_particle.SetActive(true);
            }

            int_shield_particle = 1; 

            PlayerPrefs.SetInt("Money",Money);  
            PlayerPrefs.SetInt("Level_Shield",Level_Shield);  
            PlayerPrefs.SetInt("Price_Shield",Price_Shield); 
            PlayerPrefs.SetInt("shield_prokacka",shield_prokacka); 

            if (Music_int == 0){
            Buy_audiosorce.Play();
            }
            if (Music_int == 1){
            
            }
        }
    }

    public void Plus_Money_for_end_Level (){
        if (reward_money_int == 0){
        Money += Int_plus_money_for_end_level;
        PlayerPrefs.SetInt("Money",Money);  
        }

        if (reward_money_int >= 1){
        Money += Int_plus_money_for_ads;
        PlayerPrefs.SetInt("Money",Money); 

        reward_money_int = 0; 
        PlayerPrefs.SetInt("reward_money_int",reward_money_int);  
        }

        Good_End_Panel.SetActive(false);
        Bonus_Panel.SetActive(true);

        Continue.SetActive(false);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);

        // корона 
        if (int_prb == 0){
        int_procent_bonus = 0;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        int_prb = 1;

        Hat_crown_bonus.SetActive(true);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(false);
        }
        if (int_prb == 2){
        int_prb = 3;

        Hat_crown_bonus.SetActive(true);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(false);
        }
        if (int_prb == 4){
        int_prb = 5;

        Hat_crown_bonus.SetActive(true);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(false);
        }
        if (int_prb == 6){
        int_prb = 7;

        Hat_crown_bonus.SetActive(true);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(false);
        }

        // конус 
        if (int_prb == 8){
        int_procent_bonus = 0;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        int_prb = 9;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(true);
        Hat_hallowyn_bonus.SetActive(false);
        }
        if (int_prb == 10){
        int_prb = 11;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(true);
        Hat_hallowyn_bonus.SetActive(false);
        }
        if (int_prb == 12){
        int_prb = 13;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(true);
        Hat_hallowyn_bonus.SetActive(false);
        }
        if (int_prb == 14){
        int_prb = 15;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(true);
        Hat_hallowyn_bonus.SetActive(false);
        }

        // хэлоуин 
        if (int_prb == 16){
        int_procent_bonus = 0;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        int_prb = 17;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(true);
        }
        if (int_prb == 18){
        int_prb = 19;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(true);
        }
        if (int_prb == 20){
        int_prb = 21;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(true);
        }
        if (int_prb == 22){
        int_prb = 23;

        Hat_crown_bonus.SetActive(false);
        Hat_conus_bonus.SetActive(false);
        Hat_hallowyn_bonus.SetActive(true);
        }

        PlayerPrefs.SetInt("int_prb",int_prb);  
    }

    public void Plus_Money(){
        Money += 10000;
        PlayerPrefs.SetInt("Money",Money);  
    }

    public void DeletSave (){
        PlayerPrefs.DeleteAll();  
    }

    void Update (){
    int_bonus_hat = PlayerPrefs.GetInt("int_bonus_hat");

    Price_Sword = PlayerPrefs.GetInt("Price_Sword");
    Price_Coins = PlayerPrefs.GetInt("Price_Coins");
    Price_Shield = PlayerPrefs.GetInt("Price_Shield");
    Price_Sword_text.text = Price_Sword.ToString();
    Price_Coins_text.text = Price_Coins.ToString();
    Price_Shield_text.text = Price_Shield.ToString();

    Level_Sword = PlayerPrefs.GetInt("Level_Sword");
    Level_Coins = PlayerPrefs.GetInt("Level_Coins");
    Level_Shield = PlayerPrefs.GetInt("Level_Shield");

    if (contry_text.text == "United Kingdom"){
    Level_Sword_text.text = "Level " + Level_Sword.ToString();
    Level_Coins_text.text = "Level " + Level_Coins.ToString();
    Level_Shield_text.text = "Level " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Russia"){
    Level_Sword_text.text = "Уровень " + Level_Sword.ToString();
    Level_Coins_text.text = "Уровень " + Level_Coins.ToString();
    Level_Shield_text.text = "Уровень " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Ukraine"){
    Level_Sword_text.text = "Рівень " + Level_Sword.ToString();
    Level_Coins_text.text = "Рівень " + Level_Coins.ToString();
    Level_Shield_text.text = "Рівень " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Canada"){
    Level_Sword_text.text = "Level " + Level_Sword.ToString();
    Level_Coins_text.text = "Level " + Level_Coins.ToString();
    Level_Shield_text.text = "Level " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "United States"){
    Level_Sword_text.text = "Level " + Level_Sword.ToString();
    Level_Coins_text.text = "Level " + Level_Coins.ToString();
    Level_Shield_text.text = "Level " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Netherlands"){
    Level_Sword_text.text = "Niveau " + Level_Sword.ToString();
    Level_Coins_text.text = "Niveau " + Level_Coins.ToString();
    Level_Shield_text.text = "Niveau " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Italy"){
    Level_Sword_text.text = "Livello " + Level_Sword.ToString();
    Level_Coins_text.text = "Livello " + Level_Coins.ToString();
    Level_Shield_text.text = "Livello " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Germany"){
    Level_Sword_text.text = "Ebene " + Level_Sword.ToString();
    Level_Coins_text.text = "Ebene " + Level_Coins.ToString();
    Level_Shield_text.text = "Ebene " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "France"){
    Level_Sword_text.text = "Niveau " + Level_Sword.ToString();
    Level_Coins_text.text = "Niveau " + Level_Coins.ToString();
    Level_Shield_text.text = "Niveau " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Austria"){
    Level_Sword_text.text = "Ebene " + Level_Sword.ToString();
    Level_Coins_text.text = "Ebene " + Level_Coins.ToString();
    Level_Shield_text.text = "Ebene " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Sweden"){
    Level_Sword_text.text = "Nivå " + Level_Sword.ToString();
    Level_Coins_text.text = "Nivå " + Level_Coins.ToString();
    Level_Shield_text.text = "Nivå " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Norway"){
    Level_Sword_text.text = "Nivå " + Level_Sword.ToString();
    Level_Coins_text.text = "Nivå " + Level_Coins.ToString();
    Level_Shield_text.text = "Nivå " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Finland"){
    Level_Sword_text.text = "Taso " + Level_Sword.ToString();
    Level_Coins_text.text = "Taso " + Level_Coins.ToString();
    Level_Shield_text.text = "Taso " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Denmark"){
    Level_Sword_text.text = "Niveau " + Level_Sword.ToString();
    Level_Coins_text.text = "Niveau " + Level_Coins.ToString();
    Level_Shield_text.text = "Niveau " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Czech Republic"){
    Level_Sword_text.text = "Úroveň " + Level_Sword.ToString();
    Level_Coins_text.text = "Úroveň " + Level_Coins.ToString();
    Level_Shield_text.text = "Úroveň " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Slovakia"){
    Level_Sword_text.text = "Úroveň " + Level_Sword.ToString();
    Level_Coins_text.text = "Úroveň " + Level_Coins.ToString();
    Level_Shield_text.text = "Úroveň " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Hungary"){
    Level_Sword_text.text = "Szint " + Level_Sword.ToString();
    Level_Coins_text.text = "Szint " + Level_Coins.ToString();
    Level_Shield_text.text = "Szint " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Bulgaria"){
    Level_Sword_text.text = "Ниво " + Level_Sword.ToString();
    Level_Coins_text.text = "Ниво " + Level_Coins.ToString();
    Level_Shield_text.text = "Ниво " + Level_Shield.ToString();
    contry_int = 1;
    }
    if (contry_text.text == "Spain"){
    Level_Sword_text.text = "Nivel " + Level_Sword.ToString();
    Level_Coins_text.text = "Nivel " + Level_Coins.ToString();
    Level_Shield_text.text = "Nivel " + Level_Shield.ToString();
    contry_int = 1;
    }

    if (contry_int == 0){
    Level_Sword_text.text = "Level " + Level_Sword.ToString();
    Level_Coins_text.text = "Level " + Level_Coins.ToString();
    Level_Shield_text.text = "Level " + Level_Shield.ToString();  
    }

    Int_plus_money_for_end_level = PlayerPrefs.GetInt("Int_plus_money_for_end_level");
    Text_plus_money_for_end_level.text = "+" + Int_plus_money_for_end_level.ToString();
    Int_plus_money_for_ads = PlayerPrefs.GetInt("Int_plus_money_for_ads");
    Text_plus_money_for_ads.text = "+" + Int_plus_money_for_ads.ToString();
    Int_plus_money_for_bad_level = PlayerPrefs.GetInt("Int_plus_money_for_bad_level");
    Text_Int_plus_money_for_bad_level.text = "+" + Int_plus_money_for_bad_level.ToString();

    sword_prokacka = PlayerPrefs.GetInt("sword_prokacka");
    shield_prokacka = PlayerPrefs.GetInt("shield_prokacka");

    int_prb = PlayerPrefs.GetInt("int_prb");
    int_procent_bonus = PlayerPrefs.GetFloat("int_procent_bonus");
    Text_procent_bonus.text = int_procent_bonus.ToString("F0") + " %";

    Bonus_Slider.value = int_procent_bonus;
    Bonus_Slider.maxValue = int_procent_bonus_max;

    reward_money_int = PlayerPrefs.GetInt("reward_money_int");

    Music_int = PlayerPrefs.GetInt("Music_int");

    Dead = PlayerPrefs.GetInt("Dead");
    Life = PlayerPrefs.GetInt("Life");

    Money = PlayerPrefs.GetInt("Money");
    Money_text.text = Money.ToString();

    // sword upgrade
    if (Money >= Price_Sword){
        sword_incerantable.interactable = true;

        if(sword_upg != null){
        sword_upg.SetActive(true);
        }
        if(sword_dont_upg != null){
        sword_dont_upg.SetActive(false);
        }
    }
    if (Money < Price_Sword){
        sword_incerantable.interactable = false;

        if(sword_upg != null){
        sword_upg.SetActive(false);
        }
        if(sword_dont_upg != null){
        sword_dont_upg.SetActive(true);
        }
    }

    if (int_sword_particle >= 1){
        timer_float_sword_particle += Time.deltaTime;
        if (timer_float_sword_particle >= 0.22){

            if(sword_particle != null){
            sword_particle.SetActive(false);
            }

            int_sword_particle = 0;
            timer_float_sword_particle = 0;
        }
    }

    // coins upgrade
    if (Money >= Price_Coins){
        coin_incerantable.interactable = true;

        if(coins_upg != null){
        coins_upg.SetActive(true);
        }
        if(coins_dont_upg != null){
        coins_dont_upg.SetActive(false);
        }
    }
    if (Money < Price_Coins){
       coin_incerantable.interactable = false; 

        if(coins_upg != null){
        coins_upg.SetActive(false);
        }
        if(coins_dont_upg != null){
        coins_dont_upg.SetActive(true);
        }
    }

    if (int_coins_particle >= 1){
        timer_float_coins_particle += Time.deltaTime;
        if (timer_float_coins_particle >= 0.22){

            if(coins_particle != null){
            coins_particle.SetActive(false);
            }

            int_coins_particle = 0;
            timer_float_coins_particle = 0;
        }
    }

    // shield upgrade
    if (Money >= Price_Shield){
        shield_incerantable.interactable = true;

        if(shield_upg != null){
        shield_upg.SetActive(true);
        }
        if(shield_dont_upg != null){
        shield_dont_upg.SetActive(false);
        }
    }
    if (Money < Price_Shield){
        shield_incerantable.interactable = false;

        if(shield_upg != null){
        shield_upg.SetActive(false);
        }
        if(shield_dont_upg != null){
        shield_dont_upg.SetActive(true);
        }
    }

    if (int_shield_particle >= 1){
        timer_float_shield_particle += Time.deltaTime;
        if (timer_float_shield_particle >= 0.22){

            if(shield_particle != null){
            shield_particle.SetActive(false);
            }

            int_shield_particle = 0;
            timer_float_shield_particle = 0;
        }
    }

    // SWORD LEVEL
    if (sword_prokacka == 1){
        Sword_thing_1.SetActive(true);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 2){
        Sword_thing_1.SetActive(true);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 3){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(true);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 4){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(true);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 5){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(true);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 6){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(true);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 7){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(true);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 8){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(true);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 9){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(true);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 10){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(true);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 11){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(true);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 12){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(true);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 13){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(true);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 14){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(true);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 15){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(true);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 16){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(true);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 17){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(true);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 18){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(true);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 19){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(true);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 20){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(true);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 21){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(true);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 22){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(true);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 23){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(true);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 24){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(true);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 25){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(true);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 26){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(true);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 27){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(true);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 28){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(true);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 29){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(true);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 30){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(true);
        Sword_thing_16.SetActive(false);
    }

    if (sword_prokacka == 31){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(true);
    }

    if (sword_prokacka == 32){
        Sword_thing_1.SetActive(false);
        Sword_thing_2.SetActive(false);
        Sword_thing_3.SetActive(false);
        Sword_thing_4.SetActive(false);
        Sword_thing_5.SetActive(false);
        Sword_thing_6.SetActive(false);
        Sword_thing_7.SetActive(false);
        Sword_thing_8.SetActive(false);
        Sword_thing_9.SetActive(false);
        Sword_thing_10.SetActive(false);
        Sword_thing_11.SetActive(false);
        Sword_thing_12.SetActive(false);
        Sword_thing_13.SetActive(false);
        Sword_thing_14.SetActive(false);
        Sword_thing_15.SetActive(false);
        Sword_thing_16.SetActive(true);
    }

    if (sword_prokacka == 33){
        sword_prokacka = 1;
        PlayerPrefs.SetInt("sword_prokacka",sword_prokacka);
    }

    // SHIELD LEVEL
    if (shield_prokacka == 1){
        Shield_thing_1.SetActive(true);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 2){
        Shield_thing_1.SetActive(true);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 3){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(true);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 4){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(true);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 5){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(true);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 6){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(true);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 7){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(true);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 8){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(true);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 9){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(true);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 10){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(true);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 11){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(true);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 12){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(true);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 13){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(true);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 14){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(true);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 15){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(true);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 16){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(true);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 17){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(true);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 18){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(true);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 19){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(true);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 20){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(true);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 21){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(true);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 22){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(true);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 23){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(true);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 24){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(true);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 25){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(true);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 26){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(true);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 27){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(true);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 28){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(true);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 29){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(true);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 30){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(true);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 31){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(true);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 32){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(true);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 33){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(true);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 34){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(true);
        Shield_thing_18.SetActive(false);
    }

    if (shield_prokacka == 35){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(true);
    }

    if (shield_prokacka == 36){
        Shield_thing_1.SetActive(false);
        Shield_thing_2.SetActive(false);
        Shield_thing_3.SetActive(false);
        Shield_thing_4.SetActive(false);
        Shield_thing_5.SetActive(false);
        Shield_thing_6.SetActive(false);
        Shield_thing_7.SetActive(false);
        Shield_thing_8.SetActive(false);
        Shield_thing_9.SetActive(false);
        Shield_thing_10.SetActive(false);
        Shield_thing_11.SetActive(false);
        Shield_thing_12.SetActive(false);
        Shield_thing_13.SetActive(false);
        Shield_thing_14.SetActive(false);
        Shield_thing_15.SetActive(false);
        Shield_thing_16.SetActive(false);
        Shield_thing_17.SetActive(false);
        Shield_thing_18.SetActive(true);
    }

    if (shield_prokacka == 37){
        shield_prokacka = 1;
        PlayerPrefs.SetInt("shield_prokacka",shield_prokacka);
    }

    // ----- bonus panel

    // корона
    if (int_prb == 1){
        if (int_procent_bonus <= 40){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 40){
        int_prb = 2;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }
    }

    if (int_prb == 3){
        if (int_procent_bonus <= 60){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 60){
        int_prb = 4;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    if (int_prb == 5){
        if (int_procent_bonus <= 80){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 80){
        int_prb = 6;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    if (int_prb == 7){
        if (int_procent_bonus <= 100){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 100){
        int_procent_bonus = 100;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        int_prb = 8;
        Continue.SetActive(false);
        Take.SetActive(true);
        Take_no_thanks.SetActive(true);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    // конус
    if (int_prb == 9){
        if (int_procent_bonus <= 40){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 40){
        int_prb = 10;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }
    }

    if (int_prb == 11){
        if (int_procent_bonus <= 60){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 60){
        int_prb = 12;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    if (int_prb == 13){
        if (int_procent_bonus <= 80){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 80){
        int_prb = 14;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    if (int_prb == 15){
        if (int_procent_bonus <= 100){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 100){
        int_procent_bonus = 100;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        int_prb = 16;
        Continue.SetActive(false);
        Take.SetActive(true);
        Take_no_thanks.SetActive(true);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    // халуин
    if (int_prb == 17){
        if (int_procent_bonus <= 40){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 40){
        int_prb = 18;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }
    }

    if (int_prb == 19){
        if (int_procent_bonus <= 60){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 60){
        int_prb = 20;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    if (int_prb == 21){
        if (int_procent_bonus <= 80){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 80){
        int_prb = 22;
        Continue.SetActive(true);
        Take.SetActive(false);
        Take_no_thanks.SetActive(false);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }   
    }

    if (int_prb == 23){
        if (int_procent_bonus <= 100){
        int_procent_bonus += 20 * Time.deltaTime;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        if (Music_int == 0){
        Bonus_Sound.SetActive(true);
        }
        }
        
        if (int_procent_bonus >= 100){
        int_procent_bonus = 100;
        PlayerPrefs.SetFloat("int_procent_bonus",int_procent_bonus);

        int_prb = 0;
        Continue.SetActive(false);
        Take.SetActive(true);
        Take_no_thanks.SetActive(true);
        PlayerPrefs.SetInt("int_prb",int_prb);  

        if (Music_int == 0){
        Bonus_Sound.SetActive(false);
        }
        }    
    }

    if (reward_money_int >= 1){
        gameObject.GetComponent<ShopManager>().Plus_Money_for_end_Level();
    }

    // The bad end
    if (Life >= 1 && Dead >= 1){
    if (Dead >= Life){
        Shach.SetActive(false);
        Bad_End.SetActive(true);
        Level_object.SetActive(false);
        Player.SetActive(false);

        if (stop_money == 0){
        if (Music_int == 0){ 
        Lose_audio.Play();
        }
        Money += Int_plus_money_for_bad_level; 
        PlayerPrefs.SetInt("Money",Money);  

        stop_money = 1;
        }
    }
    }
    
    // end Update    
    }
}


