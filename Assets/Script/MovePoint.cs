using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovePoint : MonoBehaviour
{
    public float speed = 10;
    public Transform[] waypoint;
    public bool Move = false;
    private Transform target;
    private int dest = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = waypoint[0];
        Move = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Move == true) {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

            if (Vector3.Distance(transform.position, target.position) < 0.3f)
            {
                dest = (dest + 1) % waypoint.Length;
                target = waypoint[dest];
            }
        }
    }
}
