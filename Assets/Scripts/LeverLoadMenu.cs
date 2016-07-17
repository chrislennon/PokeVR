using UnityEngine;
using System.Collections;
using NewtonVR;
using UnityEngine.SceneManagement;

public class LeverLoadMenu : MonoBehaviour {

    public string loadScene;
    public NVRLever Control;

    private void Update()
    {
        if (Control.LeverEngaged == true)
        {
            DoSceneLoad();
        }
    }


    private void DoSceneLoad()
    {
        SceneManager.LoadScene(loadScene);
    }
}
