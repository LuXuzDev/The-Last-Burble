using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
   public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Closed()
    {
        gameObject.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}
