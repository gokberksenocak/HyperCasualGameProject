using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    private Scene _scene;
    void Start()
    {
        _scene = SceneManager.GetActiveScene();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
}