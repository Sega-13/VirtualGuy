using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StartSceenTransition : MonoBehaviour
{
    public Animator transition;
    private float transitionTime;

    private void Awake()
    {
        LoadLevel();
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);

    }
}
