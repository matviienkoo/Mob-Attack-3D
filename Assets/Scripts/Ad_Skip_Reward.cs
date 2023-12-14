using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class Ad_Skip_Reward : MonoBehaviour
{
    private string RewardedUnitId = "ca-app-pub-5084433675560306/3598742383";
    private RewardedAd rewardedAd;

    int real_text_level;
    int int_skip_level;
    int int_randomize;
    int int_level;
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
            real_text_level += 1;
            PlayerPrefs.SetInt("real_text_level",real_text_level); 

            int_skip_level = 0;
            PlayerPrefs.SetInt("int_skip_level",int_skip_level);  

            if (int_randomize == 0){
            int_level += 1;
            PlayerPrefs.SetInt("int_level",int_level); 
            }

            if (int_randomize == 1){
            int_level = Random.Range(10, 50);
            PlayerPrefs.SetInt("int_level",int_level);  
            }

            SceneManager.LoadScene("Protothype_Scene");
        }
    }

    // награда по рекламе
    private void HandleUserEarnedReward(object sender, Reward e)
    {
        real_text_level += 1;
        PlayerPrefs.SetInt("real_text_level",real_text_level); 

        int_skip_level = 0;
        PlayerPrefs.SetInt("int_skip_level",int_skip_level);  

        if (int_randomize == 0){
        int_level += 1;
        PlayerPrefs.SetInt("int_level",int_level); 
        }

        if (int_randomize == 1){
        int_level = Random.Range(10, 50);
        PlayerPrefs.SetInt("int_level",int_level);  
        }

        SceneManager.LoadScene("Protothype_Scene");
    }

    void Update (){
    real_text_level = PlayerPrefs.GetInt("real_text_level");
    int_skip_level = PlayerPrefs.GetInt("int_skip_level");
    int_randomize = PlayerPrefs.GetInt("int_randomize");
    int_level = PlayerPrefs.GetInt("int_level");

    }
}


