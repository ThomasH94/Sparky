using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public bool loadWithString;
    public string sceneToLoad;
    public int buildIndexToLoad;

    public Vector2 newPlayerPosition;

    // Load a scene when we trigger this object
    // Then, set the player position based on where we load into
    private void OnTriggerEnter2D(Collider2D col2D)
    {
        if(col2D.name == "FakePlayerForTesting")
        {
            Debug.Log(col2D.gameObject.name);
            if(loadWithString)
            {
                SceneLoader.Instance.LoadSceneWithString(sceneToLoad);
            }
            else
            {
                SceneLoader.Instance.LoadSceneWithBuildIndex(buildIndexToLoad);
            }
        }

        SceneLoader.Instance.MovePlayerAfterSceneLoad(col2D.gameObject, newPlayerPosition);
    }
}
