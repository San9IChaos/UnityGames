using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class StartGame : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] GameObject _startButton;
    [SerializeField] GameObject _gameInterface;
    [SerializeField] RoadSpawner _roadSpawner;
    [SerializeField] RoadMove _roadMove;

    private void Start()
    {
        Pause();

    }

    public void Pause()
    {
        _playerMove.enabled = false;
        _roadSpawner.enabled = false;
        _roadMove.enabled = false;
    }

    public void GameStart()
    {
        _playerMove.enabled = true;
        _startButton.SetActive(false);
        _gameInterface.SetActive(true);
        _roadMove.enabled = true;
        _roadSpawner.enabled = true;
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Menu");
        YandexGame.FullscreenShow();
    }
}
