using UnityEngine;

public class UIPrompt : MonoBehaviour
{
    [SerializeField]
    protected GameObject mainObject;

    void Awake()
    {
        hide();
    }

    public virtual void show(params object[] args)
    {
        mainObject.SetActive(true);
    }

    public virtual void hide()
    {
        mainObject.SetActive(false);
    }
}
