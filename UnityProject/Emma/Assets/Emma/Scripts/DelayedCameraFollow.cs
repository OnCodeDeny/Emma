using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedCameraFollow : MonoBehaviour
{
    private struct PointInSpace
    {
        public Vector3 Position;
        public float Time;
    }

    //What to follow
    [SerializeField]
    private Transform target;

    [SerializeField]
    private Vector3 offset;

    //time before it starts following
    [SerializeField]
    private float delay = 0.5f;

    [SerializeField]
    private float speed = 5;

    //positions of the target for the last X seconds
    private Queue<PointInSpace> pointsInSpace = new Queue<PointInSpace>();

    void LateUpdate()
    {
        // Add the current target position to the list of positions
        pointsInSpace.Enqueue(new PointInSpace() { Position = target.position, Time = Time.time });

        // Move the camera to the position of the target X seconds ago 
        while (pointsInSpace.Count > 0 && pointsInSpace.Peek().Time <= Time.time - delay + Mathf.Epsilon)
        {
            transform.position = Vector3.Lerp(transform.position, pointsInSpace.Dequeue().Position + offset, Time.deltaTime * speed);
        }
    }
}
