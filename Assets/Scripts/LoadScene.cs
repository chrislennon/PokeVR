using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {

    public string loadScene;

    public void StartScene()
    {
        SceneManager.LoadScene(loadScene);
    }
}
