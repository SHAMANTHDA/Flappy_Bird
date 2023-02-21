using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
    public void homebutton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
