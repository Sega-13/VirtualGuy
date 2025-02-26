using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenTransition : MonoBehaviour
{
    public Animator transition;
    private float transitionTime = 1f;
    [SerializeField] private Finish finish;
    void Update()
    {
        if(finish.levelCompleted)
        {
            LoadLevel();
        }

        
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);
        
    }
    /*public void LoadNextLevel()
    {
       StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int index)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(index);
    }*/
}
