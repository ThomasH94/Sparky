using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Singleton..
    public static SceneLoader Instance;

    // Set our Singleton Reference..
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadSceneWithString(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void LoadSceneWithBuildIndex(int buildIndexToLoad)
    {
        SceneManager.LoadScene(buildIndexToLoad);
    }

    public void MovePlayerAfterSceneLoad(GameObject player, Vector2 newPosition)
    {
        player.transform.position = newPosition;
    }
}
