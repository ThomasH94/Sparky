using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHomingAttack : MonoBehaviour
{
    Transform target;
    //bool countDownTriggered = false;
    public float moveSpeed;
    // Start is called before the first frame update
    void OnEnable()
    {
        target = GameObject.Find("Player").transform;
        if(target == null)
        {
            DestoryMe();
        }
        else
        {
            Debug.Log("Projectile has found the player");
            StartCoroutine(MoveTimer());
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }

    void OnTriggerEnter(Collider collider)
    {
        PlayerController playerController;
        playerController = collider.GetComponent<PlayerController>();
        if(playerController != null)
        {
            playerController.DoDamage(10);
            DestoryMe();
        }
        else if(collider.gameObject.CompareTag("Prop"))
        {
            DestoryMe();
        }
    }

    private void MoveToTarget()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        float step = moveSpeed * Time.deltaTime;
        if(distance > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    IEnumerator MoveTimer()
    {
        Debug.Log("Timer started..");
        yield return new WaitForSeconds(2f);
        DestoryMe();
    }

    void DestoryMe()
    {
        Destroy(gameObject);
    }
}
