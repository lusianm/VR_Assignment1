using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{
    [SerializeField] StageInfo stageInfo;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Player"))
            stageInfo.StageClear();
    }

}
