using TMPro;
using UnityEngine;
using YG;

public class CoinManager : MonoBehaviour
{
    public int NumberOfCoins;
    [SerializeField] TextMeshProUGUI _text;


    private void Start()
    {
        NumberOfCoins = YandexGame.savesData.coins;
        _text.text = NumberOfCoins.ToString();
        YandexGame.NewLeaderboardScores("JungleRunLeaderboard", YandexGame.savesData.totalCoins);
    }


    public void AddOne()
    {
        NumberOfCoins++;
        YandexGame.savesData.coins = NumberOfCoins;
        YandexGame.savesData.totalCoins = NumberOfCoins;
        _text.text = NumberOfCoins.ToString();
        YandexGame.SaveProgress();
    }

    public void AddChest()
    {
        NumberOfCoins += 100;
        YandexGame.savesData.coins = NumberOfCoins;
        YandexGame.savesData.totalCoins = NumberOfCoins;
        _text.text = NumberOfCoins.ToString();
        YandexGame.SaveProgress();
    }

    public void AddMoney(int value)
    {
        NumberOfCoins += value;
        YandexGame.savesData.coins = NumberOfCoins;
        _text.text = NumberOfCoins.ToString();
        YandexGame.SaveProgress();
    }

}
