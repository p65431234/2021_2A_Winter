using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Move()
    {
        float PlayerX;
        float PlayerY;
        float PlayerZ;

        PlayerX = Player.transform.position.x;
        PlayerY = Player.transform.position.y;
        PlayerZ = Player.transform.position.z;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayerX = PlayerX -= 1;
            PlayerZ = PlayerZ += 1;
            ScoreManager.score++;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerX = PlayerX += 1;
            PlayerZ = PlayerZ += 1;
            ScoreManager.score++;
        }

        Player.transform.position = new Vector3(PlayerX, PlayerY, PlayerZ);

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
