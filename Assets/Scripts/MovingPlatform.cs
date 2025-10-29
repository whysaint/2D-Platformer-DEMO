using System;
using UnityEngine;
using UnityEditor;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 finistPos = Vector3.zero;
    public float speed = .5f;

    public Vector3 startPos;
    public float trackPercent = 0;

    private int _derection = 1;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        trackPercent += _derection * speed * Time.deltaTime;
        float x = (finistPos.x - startPos.x) * trackPercent + startPos.x;
        float y = (finistPos.y - startPos.y) * trackPercent + startPos.y;
        transform.position = new Vector3(x, y, startPos.z);

        if ((_derection == 1 && trackPercent > .9f) || (_derection == -1 && trackPercent < .1f))
        {
            _derection *= -1;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, finistPos);
    }
}
