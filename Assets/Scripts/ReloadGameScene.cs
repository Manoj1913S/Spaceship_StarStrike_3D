using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReloadGameScene : MonoBehaviour
{
    public void RestartLevel()
    {
        StartCoroutine(RestartLevelCoroutines());
    }

    IEnumerator RestartLevelCoroutines()
    {
        //get index of scene we are currently which scene 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

        Debug.Log("Game Over");
        yield return new WaitForSeconds(2f);

    }
}
