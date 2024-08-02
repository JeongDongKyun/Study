using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    static string next_scene = null;
    [SerializeField] private Image image_bar = null;

    private void Start()
    {
        StartCoroutine(LoadingIE());
    }

    public static void NextScene(string scene_name)
    {
        next_scene = scene_name;

        SceneManager.LoadScene("Loading");
    }

    IEnumerator LoadingIE()
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync("Game1");

        ao.allowSceneActivation = false;

        float timer = 0;

        while (!ao.isDone)
        {
            timer += Time.deltaTime;

            image_bar.fillAmount = timer / 10;

            if (timer >= 10)
            {
                ao.allowSceneActivation = true;

                Debug.Log("Start game!");
            }

            yield return null;
        }
    }
}
