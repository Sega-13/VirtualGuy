using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField]SceenTransition sceenTransition;
    private AudioSource finishSound;
    public bool levelCompleted = false;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelCompleted)
        {
            Debug.Log("@@@@@@@@@@@@"+ levelCompleted);
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
            sceenTransition.gameObject.SetActive(true);
            
        }
    }

    private void CompleteLevel()
    {
        LevelManager.Instance.MarkCurrentLevelComplete();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
