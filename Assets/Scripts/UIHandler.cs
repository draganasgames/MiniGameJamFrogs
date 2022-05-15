using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public InputField InputName;
    public void startScene()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void playGame()
    {
        if (InputName.text == string.Empty) return;
        GameManager.Instance.setName(InputName.text);
        startScene();
    }
    public void goToMyMenu()
    {
        SceneManager.LoadScene(0);
    }
}
