using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 instance;

    [SerializeField]
    private GameObject[] characters;

    private int _charIndex;
    public int CharIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }

    private void Awake()
    {
        if (instance == null) //means instance is not initialized
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
       SceneManager.sceneLoaded += OnLevelFinishLoading;
    }
    private void OnDisable()
    {
       SceneManager.sceneLoaded -= OnLevelFinishLoading;
    }

    void OnLevelFinishLoading(Scene scene, LoadSceneMode mode )
    {
        if(scene.name == "FlappyBird")
        {
            Instantiate(characters[CharIndex]);
        }
    }
   }
   

