using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandCreate : MonoBehaviour
{
    private GameObject Land;
    private List<GameObject> LandList;
    public int LandCount;
    static private float LandX;
    static private float LandY;
    static private float LandZ;
    private bool Dir = true; // true = right, false = left
    // Start is called before the first frame update

    private void Awake()
    {
        LandList = new List<GameObject>();
        Land = GameObject.Find("Block");
        LandX = 0f;
        LandY = -0.6f;
        LandZ = 0f;
    }
    void Start()
    {
        CreateLand();
    }



    // Update is called once per frame
    void Update()
    {
    }

    void CreateLand()
    {
        for (int i = 0; i < LandCount; i++)
        {
            int random = Random.Range(0, 5);
            for (int j = 0; j < random; j++)
            {
                GameObject copyobj = GameObject.Instantiate(Land);
                copyobj.transform.position = new Vector3(LandX, LandY, LandZ);
                LandList.Add(copyobj);
                copyobj.SetActive(true);
                if (Dir)
                    LandX += 0.7f;
                else
                    LandX -= 0.7f;
                LandY += 0.2f;
            }
            if (Dir)
                Dir = false;
            else
                Dir = true;
        }
    }
}
