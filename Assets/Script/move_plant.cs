using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class move_plant : MonoBehaviour
{
    public float speed = 10;
    public Transform[] waypoint;

    private Transform target;
    private int dest = 0;

    public Animator anim;

    public bool Move = false;

    void Start()
    {
        target = waypoint[0];
        Move = true;
        if (anim != null)
            anim.SetBool("Move", true);
    }

    void Update()
    {
        if (Move == true) {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

            if (Vector3.Distance(transform.position, target.position) < 0.3f)
            {
                StartCoroutine(MyCoroutine());
            }
        }
    }

    public IEnumerator MyCoroutine() {
        Move = false;
        if (anim != null)
            anim.SetBool("Move", false);
        yield return new WaitForSeconds(2);
        if (anim != null)
            anim.SetBool("Move", true);
        dest = (dest + 1) % waypoint.Length;
        target = waypoint[dest];
        Move = true;
    }
}
