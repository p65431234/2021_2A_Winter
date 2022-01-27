using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaButton : MonoBehaviour
{

    private GameObject Cam;
    private GameObject Panel;

    private float CamX;
    private float CamY;
    private float CamZ;

    // Start is called before the first frame update
    void Start()
    {
        Cam = GameObject.Find("Main Camera");
        Panel = GameObject.Find("CharaList");
    }

    // Update is called once per frame
    void Update()
    {
        ClickButton();
    }

    void ClickButton()
    {
        CamX = Panel.transform.position.x;
        CamY = Panel.transform.position.y;
        CamZ = Panel.transform.position.z;

        Cam.transform.position = new Vector3(CamX, CamY, CamZ);
    }



}
