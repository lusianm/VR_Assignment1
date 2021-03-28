using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    CameraMove slopeCamera;
    [SerializeField] private float moveSpeed = 3f;
    Vector3 objectRightPosition => transform.position + transform.right.normalized * 0.52f;
    Vector3 objectLeftPosition => transform.position - transform.right.normalized * 0.52f;
    // Start is called before the first frame update
    void Start()
    {
        slopeCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMove>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (slopeCamera.cameraSlope)
        {
            case 0:
                return;
            case 1:
                if (!Physics.Raycast(transform.position, transform.right, 0.5f * transform.lossyScale.x, 1 << LayerMask.NameToLayer("Obstacle")))
                    transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.right.normalized, moveSpeed);
                break;
            case 2:
                if (!Physics.Raycast(transform.position, -transform.right, 0.5f * transform.lossyScale.x, 1 << LayerMask.NameToLayer("Obstacle")))
                    transform.position = Vector3.MoveTowards(transform.position, transform.position - transform.right.normalized, moveSpeed);
                break;
        }
    }
}
