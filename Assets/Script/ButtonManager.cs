using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject player;
    public void Up()
    {
        player.GetComponent<PlayerController>().moveVertical += 1;              // player에 Up button으로 수평방향으로 힘적용
    }
    public void Down()
    {
        player.GetComponent<PlayerController>().moveVertical -= 1;
    }
    public void Right()
    {
        player.GetComponent<PlayerController>().moveHorizonal += 1;
    }
    public void Left()
    {
        player.GetComponent<PlayerController>().moveHorizonal -= 1;
    }
    public void Jump()                                                  // 물체에 기본적으로 RigidBody로 중력 적용
    {
        player.GetComponent<PlayerController>().Jump();
        /*Vector3 pos = player.transform.position;
        pos.y +=3;
        // 중력 속도 반작용
        player.GetComponent<PlayerController>().moveJump = 9.81f;
        while (player.transform.position != pos)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, pos, Time.deltaTime * 0.1f);
        }
        player.GetComponent<PlayerController>().moveJump = 0.0f;        // 중력 구현.*/

    }
}
