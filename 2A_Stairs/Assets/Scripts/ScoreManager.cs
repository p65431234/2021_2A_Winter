using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    // 스코어를 저장

    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score = " + score;
        // 스코어를 주기적으로 갱신
    }
}
