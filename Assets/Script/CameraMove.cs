using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Gyroscope gyro;

    // ī�޶� �����Ͽ� ī�޶��� ȸ�� �� ��ġ�� �����ϴ� Script
    void Start()
    {
        //Gyro�� ��� ���
        gyro = Input.gyro;
        gyro.enabled = true;
    }

    Quaternion GyroToUnity(Quaternion q) => new Quaternion(q.x, q.y, -q.z, -q.w);

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = GyroToUnity(gyro.attitude);
        Vector3 playerForward = transform.forward;
        playerForward.y = 0;
        playerTransform.forward = playerForward;
        //���ӵ� ������ ��Ȯ���� �ʹ� ���ϴ�.
        //cameraParent.position = transform.position - gyro.userAcceleration * Time.deltaTime*50f + new Vector3(0, Time.deltaTime/10,0);
        //Debug.Log(Time.deltaTime);
    }
}
