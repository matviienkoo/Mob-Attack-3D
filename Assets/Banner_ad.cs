using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class Banner_ad : MonoBehaviour
{
    private BannerView bannerView;
    int not_ads;

#if UNITY_ANDROID
    private const string bannerUnitId = "ca-app-pub-5084433675560306/3765714608";
#elif UNITY_IPHONE
    private const string bannerUnitId = "";
#else
    private const string bannerUnitId = "unexpected_platform";
#endif

    void OnEnable()
    {
        not_ads = PlayerPrefs.GetInt("not_ads");

        // no ads = false
        if (not_ads == 0)
        {
        bannerView = new BannerView(bannerUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest adRequest = new AdRequest.Builder().Build();
        bannerView.LoadAd(adRequest);
        StartCoroutine(ShowBanner());
        }
    }

    IEnumerator ShowBanner()
    {
        yield return new WaitForSecondsRealtime(3.0f);
        bannerView.Show();
    }  
}
