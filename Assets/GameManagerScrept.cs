using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //シーンマネジメントを追加せなあかん。

public class GameManagerScrept : MonoBehaviour
{
    
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeReset(string nextScene)
    {

        SceneManager.LoadScene(nextScene);
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, false);
        

    }

    

}
