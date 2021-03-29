using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    [SerializeField] StageInfo stageInfo;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationRightBound = -30;
    [SerializeField] private float rotationLeftBound = 30;
    private Quaternion rightRotation;
    private Quaternion leftRotation;

    private void Start()
    {
        rotationRightBound = (360 + transform.rotation.eulerAngles.x + rotationRightBound) % 360;
        rightRotation = Quaternion.Euler(new Vector3(rotationRightBound, transform.eulerAngles.y, transform.eulerAngles.z));
        rotationLeftBound = (360 + transform.rotation.eulerAngles.x + rotationLeftBound) % 360;
        leftRotation = Quaternion.Euler(new Vector3(rotationLeftBound, transform.eulerAngles.y, transform.eulerAngles.z));
    }

    void FixedUpdate()
    {
        if (stageInfo.isStageActivated)
        {
            float rotationX = (transform.rotation.eulerAngles.x + 360) % 360;
            switch (stageInfo.GetCameraMove().cameraSlope)
            {
                case 0:
                    return;
                case 1:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, rightRotation, moveSpeed);
                    break;
                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, leftRotation, moveSpeed);
                    break;
            }
        }
    }
}
