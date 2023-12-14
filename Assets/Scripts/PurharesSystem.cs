using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
using TMPro;

public class PurharesSystem : MonoBehaviour
{
    public int Money;
    public int not_ads;
    public int hero_pack;

    public Skins_panel HeroesPack;
    public TextMeshProUGUI Money_text;

    public Button NoAds_Button;
    public Button HeroPack_Button;
    public TextMeshProUGUI NoAds_text;
    public TextMeshProUGUI HeroPack_text;

    public int int_hat_helowyn;
    public int int_hat_helowyn_special;

    public int int_hat_znak;
    public int int_hat_znak_special;

    public int int_hat_crown;
    public int int_hat_crown_special;

    private void Start ()
    {
        not_ads = PlayerPrefs.GetInt("not_ads");
        hero_pack = PlayerPrefs.GetInt("hero_pack");

        if (not_ads == 1)
        {
            NoAds_text.text = "Sold";
            NoAds_Button.enabled = false;
        }

        if (hero_pack == 1)
        {
            HeroPack_text.text = "Sold";
            HeroPack_Button.enabled = false;
        }
    }

    public void OnPurchaseComplete(Product product)
    {
        switch (product.definition.id)
        {
            case "5000coins":
                {
                    Money += 5000;
                    PlayerPrefs.SetInt("Money",Money); 
                }
                break;
            case "15000coins":
                {
                    Money += 15000;
                    PlayerPrefs.SetInt("Money",Money); 
                }
                break;
            case "50000coins":
                {
                    Money += 50000;
                    PlayerPrefs.SetInt("Money",Money); 
                }
                break;
            case "noads":
                {
                    not_ads = 1;
                    PlayerPrefs.SetInt("not_ads",not_ads); 

                    NoAds_text.text = "Sold";
                    NoAds_Button.enabled = false;
                }
                break;
            case "heroespack":
                {
                    int_hat_helowyn = 2;
                    int_hat_helowyn_special = 1;
                    int_hat_znak = 2;
                    int_hat_znak_special = 1;
                    int_hat_crown = 2;
                    int_hat_crown_special = 1;
                    PlayerPrefs.SetInt("int_hat_helowyn",int_hat_helowyn); 
                    PlayerPrefs.SetInt("int_hat_helowyn_special",int_hat_helowyn_special); 
                    PlayerPrefs.SetInt("int_hat_znak",int_hat_znak); 
                    PlayerPrefs.SetInt("int_hat_znak_special",int_hat_znak_special); 
                    PlayerPrefs.SetInt("int_hat_crown",int_hat_crown); 
                    PlayerPrefs.SetInt("int_hat_crown_special",int_hat_crown_special); 

                    hero_pack = 1;
                    PlayerPrefs.SetInt("hero_pack",hero_pack); 

                    Money += 5000;
                    PlayerPrefs.SetInt("Money",Money); 

                    HeroPack_text.text = "Sold";
                    HeroPack_Button.enabled = false;
                }
                break;
        }
    }

    private void Update ()
    {
        Money = PlayerPrefs.GetInt("Money");
        Money_text.text = Money.ToString();
    }
}


