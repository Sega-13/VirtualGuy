using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
   // [SerializeField]StartSceenTransition startSceenTransition;
    [SerializeField] private Button buttonPlay;
    public GameObject LevelSelection;
    private void Awake()
    {
        buttonPlay.onClick.AddListener(PlayGame);
    }
    private void PlayGame()
    {
        //startSceenTransition.gameObject.SetActive(true);
        LevelSelection.SetActive(true);
        //SceneManager.LoadScene(1);

    }
    /*public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/
}
