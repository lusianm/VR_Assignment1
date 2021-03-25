using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;

    public void OnPointerDown(PointerEventData eventData)       // ������ ���� ��
    {
        player.GetComponent<PlayerController>().moveVertical = 1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        player.GetComponent<PlayerController>().moveVertical = 0;
    }
}
