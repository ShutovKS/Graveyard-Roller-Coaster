using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToMainMenu : MonoBehaviour
{
    private AsyncOperation _loadSceneAsync;

    private void Start()
    {
        _loadSceneAsync = SceneManager.LoadSceneAsync("MainMenu");
        _loadSceneAsync.allowSceneActivation = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _loadSceneAsync.allowSceneActivation = true;
    }
}