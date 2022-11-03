using PathCreation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBaseScript : MonoBehaviour
{
    [SerializeField]
    PathCreator pathCreator;

    public float speed = 6f;

    float moveDistance;

    void Update()
    {
        moveDistance += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(moveDistance);
        transform.rotation = pathCreator.path.GetRotationAtDistance(moveDistance);
    }
}