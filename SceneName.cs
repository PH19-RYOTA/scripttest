using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneName : MonoBehaviour
{
    [SerializeField, Header("Scene / URL")] string scene = "";
    private float change = 0.5f;

    public void SceneChange()
    {
        Invoke("Change", change);
    }

    void Change()
    {
        SceneManager.LoadScene(scene);
    }

    public void URL()
    {
        Application.OpenURL(scene);
    }
}
