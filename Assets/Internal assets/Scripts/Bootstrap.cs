using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstrap : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
