using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public bool loadWithString;
    public string sceneToLoad;
    public int buildIndexToLoad;

    public Vector3 newPlayerPosition;

    // Load a scene when we trigger this object
    // Then, set the player position based on where we load into
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "FakePlayerForTesting")
        {
            Debug.Log(col.gameObject.name);
            if(loadWithString)
            {
                SceneLoader.Instance.LoadSceneWithString(sceneToLoad);
            }
            else
            {
                SceneLoader.Instance.LoadSceneWithBuildIndex(buildIndexToLoad);
            }
        }

        SceneLoader.Instance.MovePlayerAfterSceneLoad(col.gameObject, newPlayerPosition);
    }
}
