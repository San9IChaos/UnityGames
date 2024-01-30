using UnityEngine;
using YG;

public class Shop : MonoBehaviour
{
    [SerializeField] GameObject _palm;
    [SerializeField] GameObject _grass;
    [SerializeField] GameObject _face;
    [SerializeField] GameObject _boat;
    [SerializeField] GameObject _paddle;
    [SerializeField] GameObject _fence;
    [SerializeField] GameObject _food;
    [SerializeField] GameObject _shop;
    [SerializeField] GameObject _button;

    void Start()
    {
        _palm.SetActive(YandexGame.savesData.buyPalm);
        _grass.SetActive(YandexGame.savesData.buyGrass);
        _face.SetActive(YandexGame.savesData.buyFace);
        _boat.SetActive(YandexGame.savesData.buyBoat);
        _paddle.SetActive(YandexGame.savesData.buyPaddle);
        _fence.SetActive(YandexGame.savesData.buyFence);
        _food.SetActive(YandexGame.savesData.buyFood);
    }

    public void BuyPalm()
    {
        if(YandexGame.savesData.buyPalm == false && YandexGame.savesData.coins >= 1000)
        {
            _palm.SetActive(true);
            YandexGame.savesData.buyPalm = true;
            YandexGame.savesData.coins -= 1000;
            YandexGame.SaveProgress();
        }
    }

    public void BuyGrass()
    {
        if (YandexGame.savesData.buyGrass == false && YandexGame.savesData.coins >= 500)
        {
            _grass.SetActive(true);
            YandexGame.savesData.buyGrass = true;
            YandexGame.savesData.coins -= 500;
            YandexGame.SaveProgress();
        }
    }

    public void BuyFace()
    {
        if (YandexGame.savesData.buyFace == false && YandexGame.savesData.coins >= 2000)
        {
            _face.SetActive(true);
            YandexGame.savesData.buyFace = true;
            YandexGame.savesData.coins -= 2000;
            YandexGame.SaveProgress();
        }
    }

    public void BuyBoat()
    {
        if (YandexGame.savesData.buyBoat == false && YandexGame.savesData.coins >= 1500)
        {
            _boat.SetActive(true);
            YandexGame.savesData.buyBoat = true;
            YandexGame.savesData.coins -= 1500;
            YandexGame.SaveProgress();
        }
    }

    public void BuyPaddle()
    {
        if (YandexGame.savesData.buyPaddle == false && YandexGame.savesData.coins >= 750)
        {
            _paddle.SetActive(true);
            YandexGame.savesData.buyPaddle = true;
            YandexGame.savesData.coins -= 750;
            YandexGame.SaveProgress();
        }
    }

    public void BuyFence()
    {
        if (YandexGame.savesData.buyFence == false && YandexGame.savesData.coins >= 1250)
        {
            _fence.SetActive(true);
            YandexGame.savesData.buyFence = true;
            YandexGame.savesData.coins -= 1250;
            YandexGame.SaveProgress();
        }
    }

    public void BuyFood()
    {
        if (YandexGame.savesData.buyFood == false && YandexGame.savesData.coins >= 1000)
        {
            _food.SetActive(true);
            YandexGame.savesData.buyFood = true;
            YandexGame.savesData.coins -= 1000;
            YandexGame.SaveProgress();
        }
    }

    public void CloseShop()
    {
        _shop.SetActive(false);
        _button.SetActive(true);
    }
}
