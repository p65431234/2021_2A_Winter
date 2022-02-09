using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharaButton : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button1;
    public GameObject Button2;

    public static int CharaNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CharaButton_Click()
    {
        Panel.SetActive(true);
        Button1.SetActive(false);
        Button2.SetActive(false);
    }

    public void PlayButton_Click()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void ExitButton_Click()
    {
        Panel.SetActive(false);
        Button1.SetActive(true);
        Button2.SetActive(true);
    }
    
    public void Chara1Button()
    {
        CharaNumber = 1;
        Panel.SetActive(false);
        Button1.SetActive(true);
        Button2.SetActive(true);
    }

    public void Chara2Button()
    {
        CharaNumber = 2;
        Panel.SetActive(false);
        Button1.SetActive(true);
        Button2.SetActive(true);
    }

}
