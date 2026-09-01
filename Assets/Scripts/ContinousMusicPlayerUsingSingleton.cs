using UnityEngine;
using UnityEngine.Rendering;

public class ContinousMusicPlayerUsingSingleton : MonoBehaviour
{
    void Start()
    {
        int numOfMusicPlayers =
            FindObjectsByType<ContinousMusicPlayerUsingSingleton>(FindObjectsSortMode.None).Length; //INFO:  // Count how many GameObjects have this script attached in the scene

        //INFO:If there is more than one MusicPlayer, it means a duplicate exists
        if (numOfMusicPlayers > 1)
        {
            Destroy(gameObject); //Destroy current duplicate  music object
        }
        else
        {
             // Keep this MusicPlayer alive when changing scenes
            DontDestroyOnLoad(gameObject);
        }
    }
}