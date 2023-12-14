using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class Ad_Money_Reward : MonoBehaviour
{
    private string RewardedUnitId = "ca-app-pub-5084433675560306/8775580278";
    private RewardedAd rewardedAd;
    int reward_money_int;
    int not_ads;

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
        not_ads = PlayerPrefs.GetInt("not_ads");
        
        // no ads = false
        if (not_ads == 0)
        {        
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        if (rewardedAd.IsLoaded())
            rewardedAd.Show();
        }

        // no ads = true
        if (not_ads == 1)
        { 
            reward_money_int = 1;
            PlayerPrefs.SetInt("reward_money_int",reward_money_int);  
        }
    }

    // награда по рекламе
    private void HandleUserEarnedReward(object sender, Reward e)
    {
        reward_money_int = 1;
        PlayerPrefs.SetInt("reward_money_int",reward_money_int);  
    }

    void Update (){
    reward_money_int = PlayerPrefs.GetInt("reward_money_int");

    }
}


