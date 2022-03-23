
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jouer: MonoBehaviour
{
    [SerializeField] private string SceneName;
    [SerializeField] private GameObject ScreenToLoad;


    public void LoadSceneAsync()
    {
        StartCoroutine(LoadScreenCoroutine());
    }

    IEnumerator LoadScreenCoroutine()
    {
        var screen = Instantiate(ScreenToLoad);
        DontDestroyOnLoad(screen);

        var chargement = SceneManager.LoadSceneAsync("VerticalSlice");
        chargement.allowSceneActivation = false;

        while (chargement.isDone == false)
        {
            if (chargement.progress >= 0.9f)
            {
                chargement.allowSceneActivation = true;
                screen.GetComponent<Animator>().SetTrigger("disparait");
                Destroy(screen);
            }

            yield return new WaitForSeconds(3);

        }

    }
}