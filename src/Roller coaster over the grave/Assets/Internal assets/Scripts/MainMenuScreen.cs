using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    private AsyncOperation _asyncOperationCemetery;

    private void Start()
    {
        _asyncOperationCemetery = SceneManager.LoadSceneAsync("Gameplay");
        _asyncOperationCemetery.allowSceneActivation = false;
    }

    public void EnterGameplay()
    {
        _asyncOperationCemetery.allowSceneActivation = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}