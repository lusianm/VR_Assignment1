using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageStart : MonoBehaviour
{
    [SerializeField] StageInfo stageInfo;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Player"))
            stageInfo.StageStart();
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
}
