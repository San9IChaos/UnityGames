using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] Transform panelCard;
    [SerializeField] List<Card> cards;

    [SerializeField] int numberCard;
    [SerializeField] bool findCard = false;

    [SerializeField] GameTimer gameTimer;

    public bool FindCard => findCard;

    private void Awake()
    {
        for (int i = 0; i < panelCard.childCount; i++)
        {
            panelCard.GetChild(i).transform.SetSiblingIndex(Random.Range(0, panelCard.childCount));
        }
    }

    private void Start()
    {
        for(int i = 0; i < panelCard.childCount; i++)
        {
            cards.Add(panelCard.GetChild(i).GetComponent<Card>());
        }
    }

    public void OpenCards()
    {
        var openCard = 0;

        foreach (Card card in cards)
        {
            if(card.Down)
            {
                if(openCard == 0)
                {
                    numberCard = card.Number;
                }
                openCard++;
            }
        }
        if(openCard == 2)
        {
            CheckCard();
        }
    }

    public void CheckCard()
    {
        var a = 0;

        foreach(Card card in cards)
        {
            if (card.Down && card.Number == numberCard)
            {
                a++;
            }
        }

        if (a == 2)
        {
            FoundCards();
        }
        else
        {
            NotFoundCards();
        }
    }

    public void FoundCards()
    {
        foreach (Card card in cards)
        {
            if (card.Down)
            {
                StartCoroutine(Found(card));
            }
        }
    }

    public void NotFoundCards()
    {
        foreach (Card card in cards)
        {
            if (card.Down)
            {
                StartCoroutine(NotFound(card));
            }
        }
    }

    IEnumerator NotFound(Card card)
    {
        findCard = true;
        yield return new WaitForSeconds(0.5f);
        card.GetComponent<Card>().NotFindCard();
        findCard = false;
    }

    IEnumerator Found(Card card)
    {
        findCard = true;
        yield return new WaitForSeconds(0.5f);
        card.GetComponent<Card>().FindCard();
        findCard = false;
    }

    public void Win()
    {
        var a = 0;
        foreach (Card card in cards)
        {
            if (card.Found)
            {
                a++;
            }
        }
        if (a == panelCard.childCount)
        {
            gameTimer.time = 0;
        }
    }
}
