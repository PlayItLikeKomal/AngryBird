using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
public class bannerad : MonoBehaviour
{
    string GameID = "4982867";
    bool testmode = true;   //make it false when game is uploaded on playstore
    string BannerAdID = "bannerPlacement";
    // Start is called before the first frame update
    void Start()
    {
        //Advertisement.AddListener(this);
        Advertisement.Initialize(GameID);
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        StartCoroutine(ShowAdsWhenInitialized());
    }
    IEnumerator ShowAdsWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(BannerAdID);
    }
}