using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameObject endGame;
    public int time = 60;

    void Start()
    {
        StartCoroutine(MyTimer());
    }

    IEnumerator MyTimer()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1);
            time--;
            timerText.text = time.ToString();
            if (time == 0)
            {
                time = 60;
                timerText.text = "60";
                endGame.SetActive(true);
                break;
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(MyTimer());
    }
}
