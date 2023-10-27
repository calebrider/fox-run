using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public float smoothTime = 0.1f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.position;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
