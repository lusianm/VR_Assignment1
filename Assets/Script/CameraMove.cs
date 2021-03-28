using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Gyroscope gyro;
    public int cameraSlope = 0;

    // ī�޶� �����Ͽ� ī�޶��� ȸ�� �� ��ġ�� �����ϴ� Script
    void Start()
    {
        //Gyro�� ��� ���
        gyro = Input.gyro;
        gyro.enabled = true;
        cameraSlope = 0;
    }

    Quaternion GyroToUnity(Quaternion q) => new Quaternion(q.x, q.y, -q.z, -q.w);

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = GyroToUnity(gyro.attitude);
        Vector3 playerForward = transform.forward;
        playerForward.y = 0;
        playerTransform.forward = playerForward;

        if (transform.right.y < -0.35f)
            cameraSlope = 1;
        else if (transform.right.y > 0.35f)
            cameraSlope = 2;
        else
            cameraSlope = 0;
        //Vector3 CameraToPlayer = playerTransform.position - transform.position.normalized;


            //���ӵ� ������ ��Ȯ���� �ʹ� ���ϴ�.
            //cameraParent.position = transform.position - gyro.userAcceleration * Time.deltaTime*50f + new Vector3(0, Time.deltaTime/10,0);
            //Debug.Log(Time.deltaTime);
    }
}
