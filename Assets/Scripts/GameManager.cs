using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    // SCENE MANAGEMENT - maybe theres a better, more concise way but I don't care
    public void GoToW1()
    {
        SceneManager.LoadScene("Warrtior_1");
    }

    public void GoToW2()
    {
        SceneManager.LoadScene("Warrior_2");
    }

    public void GoToW3()
    {
        SceneManager.LoadScene("Warrior_3");
    }

    public void GoToR1()
    {
        SceneManager.LoadScene("Rogue_1");
    }

    public void GoToR2()
    {
        SceneManager.LoadScene("Rogue_2");
    }

    public void GoToR3()
    {
        SceneManager.LoadScene("Rogue_3");
    }

    public void GoToM1()
    {
        SceneManager.LoadScene("Mage_1");
    }

    public void GoToM2()
    {
        SceneManager.LoadScene("Mage_2");
    }

    public void GoToM3()
    {
        SceneManager.LoadScene("Mage_3");
    }
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("World_Selector");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
