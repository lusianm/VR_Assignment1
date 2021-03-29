using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] StageInfo stageInfo;
    [SerializeField] private float moveSpeed;


    void FixedUpdate()
    {
        if (stageInfo.isStageActivated)
        {
            switch (stageInfo.GetCameraMove().cameraSlope)
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
}
