using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    public Image imageToFade;
    public Animator anim;

    private void Start()
    {
        imageToFade.enabled = false;
    }

    public void FadeIn()
    {
        anim.SetTrigger("FadeIn");
        imageToFade.enabled = true;
        StartCoroutine(DisableRoutine());

    }

    public void FadeOut()
    {
        anim.SetTrigger("FadeOut");
        imageToFade.enabled = true;
        StartCoroutine(DisableRoutine());
    }

    private IEnumerator DisableRoutine()
    {
        yield return new WaitForSeconds(1.0f);
        imageToFade.enabled = false;
    }

}
