using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class ShopMenu : MonoBehaviour
{
    [SerializeField] GameObject _menu;
    [SerializeField] GameObject _shop;
    [SerializeField] GameObject _button;

    public void OpenMenu()
    {
        _menu.SetActive(true);
        _button.SetActive(false);
    }

    public void OpenShop()
    {
        _shop.SetActive(true);
        _menu.SetActive(false);
    }

    public void CloseMenu()
    {
        _menu.SetActive(false);
        _button.SetActive(true);
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Menu");
        YandexGame.FullscreenShow();
    }
}
