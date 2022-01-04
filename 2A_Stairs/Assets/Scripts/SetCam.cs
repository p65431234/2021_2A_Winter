using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCam : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    private float CamX;
    private float CamY; 
    private float CamZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MoveCam()
    {
        CamX = Player.transform.position.x;
        CamY = Player.transform.position.y + 15;
        CamZ = Player.transform.position.z;

        Camera.transform.position = new Vector3(CamX, CamY, CamZ);
    }

    // Update is called once per frame
    void Update()
    {
        MoveCam();
    }
}
