using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCam : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    private float CamX;
    private float CamY; 
    private float CamZ = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //void MoveCam()
    //{
    //    CamX = Player.transform.position.x;
    //    CamY = Player.transform.position.y;
    //    CamZ = Player.transform.position.z - 10;

    //    Camera.transform.position = new Vector3(CamX, CamY, CamZ);
    //}

    // Update is called once per frame
    void Update()
    {
        //MoveCam();
    }

    private void FixedUpdate()
    {
        Vector3 TargetFos = new Vector3(Player.transform.position.x, Player.transform.position.y, CamZ);
        Camera.transform.position = Vector3.Lerp(Camera.transform.position, TargetFos, Time.deltaTime * 5f);
    }
}
