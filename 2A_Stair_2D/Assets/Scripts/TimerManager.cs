using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text Timetext;
    private float time;

    private void Awake()
    {
        time = 60f;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        Timetext.text = Mathf.Ceil(time).ToString();
    }
}
