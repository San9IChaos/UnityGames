using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] Game game;

    [SerializeField] Sprite backCard;
    [SerializeField] Sprite frontCard;
    [SerializeField] Sprite foundCard;

    [SerializeField] int number;


    public bool Down => this.GetComponent<Image>().sprite == frontCard;

    public bool Found => this.GetComponent<Image>().sprite == foundCard;

    public int Number => number;

    public void OnMouseDown()
    {
        if(!Found)
        {
            if (!game.FindCard)
            {
                if (!Down)
                {
                    this.GetComponent<Image>().sprite = frontCard;
                    game.OpenCards();
                }
            }
        }
    }

    public void NotFindCard()
    {
        this.GetComponent<Image>().sprite = backCard;
    }

    public void FindCard()
    {
        this.GetComponent<Image>().sprite = foundCard;
    }
}
