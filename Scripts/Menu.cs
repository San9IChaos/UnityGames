using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject _warningAuth;
    [SerializeField] GameObject _warningRateGame;
    [SerializeField] GameObject _aboutGame;

    public void RateGame()
    {
        if (YandexGame.auth && YandexGame.EnvironmentData.reviewCanShow)
        {
            YandexGame.ReviewShow(false);
        }
        else
        {
            _warningRateGame.SetActive(true);
        }
    }
    public void OpenWarningWindow()
    {
        _warningAuth.SetActive(true);
    }

    public void CloseWarningWindow()
    {
        _warningAuth.SetActive(false);
    }

    public void CloseWarningRateWindow()
    {
        _warningRateGame.SetActive(false);
    }

    public void PpenAboutGameWindow()
    {
        _aboutGame.SetActive(true);
    }

    public void CloseAboutGameWindow()
    {
        _aboutGame.SetActive(false);
    }

    public void OpenAuthDialog()
    {
        YandexGame.AuthDialog();
    }

    public void OpenMyRoom()
    {
        SceneManager.LoadScene("Room");
        YandexGame.FullscreenShow();
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
        YandexGame.FullscreenShow();
    }
}
