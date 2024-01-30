using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class EndGameMenu : MonoBehaviour
{
    public YandexGame sdk;
    [SerializeField] CoinManager _coinManager;
    [SerializeField] GameObject _bonusButton;

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Menu");
        YandexGame.FullscreenShow();
    }

    public void AdButton()
    {
        sdk._RewardedShow(1);
        _bonusButton.SetActive(false);
    }

    public void AdButtonMoney()
    {
        _coinManager.AddMoney(150);
    }
}
