using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject Chara1;
    public GameObject Chara2;
    protected bool MoveType = true; // true = right, false = left


    // Start is called before the first frame update
    void Start()
    {
        if (CharaButton.CharaNumber == 1)
        {
            Chara1.SetActive(true);
        }
        if (CharaButton.CharaNumber == 2)
        {
            Chara2.SetActive(true);
        }
        
    }

    void Move()
    {
        float PlayerX;
        float PlayerY;
        float PlayerZ;

        PlayerX = Player.transform.position.x;
        PlayerY = Player.transform.position.y;
        PlayerZ = Player.transform.position.z;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (MoveType)
            {
                MoveType = false;
                PlayerY = 180;
            }
            else
            {
                MoveType = true;
                PlayerY = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (MoveType == false)
            {
                PlayerX = PlayerX -= 0.7f;
                PlayerY = PlayerY += 0.2f;
                ScoreManager.score++;
            }
            else
            {
                PlayerX = PlayerX += 0.7f;
                PlayerY = PlayerY += 0.2f;
                ScoreManager.score++;
            }
             
        }

        Player.transform.position = new Vector3(PlayerX, PlayerY, PlayerZ);

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
