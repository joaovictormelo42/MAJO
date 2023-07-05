using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrMenu : MonoBehaviour
{
   public void LoadScenes(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
