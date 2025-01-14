using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnnemiWaypoint : MonoBehaviour
{
    public float speed = 10;
    public Transform[] waypoint;

    public SpriteRenderer graph;
    private Transform target;
    private int dest = 0;

    public Animator anim;

    public bool Move = false;

    public enemie_weak_spot Enemie_weak_spot;

    void Start()
    {
        target = waypoint[0];
        Move = true;
        anim.SetBool("Move", true);
    }

    void Update()
    {
        if (Move == true && Enemie_weak_spot.dead == false) {
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
        anim.SetBool("Move", false);
        yield return new WaitForSeconds(2);
        anim.SetBool("Move", true);
        dest = (dest + 1) % waypoint.Length;
        target = waypoint[dest];
        graph.flipX = !graph.flipX;
        Move = true;
    }
}