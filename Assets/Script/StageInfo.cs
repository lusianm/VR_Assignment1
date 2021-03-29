using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageInfo : MonoBehaviour
{
    public bool isStageActivated;
    CameraMove mainCameraMove;
    // Start is called before the first frame update
    public CameraMove GetCameraMove() => mainCameraMove;

    void Start()
    {
        isStageActivated = false;
        mainCameraMove = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMove>();
    }

    public void StageStart()
    {
        if (!isStageActivated)
        {
            isStageActivated = true;
        }

    }

    public void StageClear()
    {
        if (isStageActivated)
        {
            isStageActivated = false;
        }
    }

}
