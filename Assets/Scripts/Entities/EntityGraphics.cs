using UnityEngine;

public class EntityGraphics : MonoBehaviour
{
    [SerializeField]
    protected Animator anim;

    public void PlayAnimation(string setTrigger)
    {
        anim?.SetTrigger(setTrigger);
    }
}
