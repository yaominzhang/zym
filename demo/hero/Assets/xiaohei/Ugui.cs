using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ugui : MonoBehaviour
{
    public GameObject InitSubPanel;     //开始界面的初始面板
    public GameObject StartSubPanel;    //点击“开始”按钮后的面板
    public GameObject OptionSubPanel;	//点击“选项”按钮后的面板
    public InputField usernameInputFieid;
    public Toggle soundToggle;
    public void StartGame()
    {
        PlayerPrefs.SetString("Username", usernameInputFieid.text);
        SceneManager.LoadScene("GamePlay");
    }
    public void SwitchSound()
    {
        if (soundToggle.isOn) PlayerPrefs.SetInt("SoundOff", 0);
        else PlayerPrefs.SetInt("SoundOdd", 1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ActiveInitPanel()
    {
        InitSubPanel.SetActive(true);
        StartSubPanel.SetActive(false);
        OptionSubPanel.SetActive(false);
    }
    public void ActiveStartPanel()
    {
        InitSubPanel.SetActive(false);
        StartSubPanel.SetActive(true);
        OptionSubPanel.SetActive(false);

    }
    public void activeOptionPanel()
    {
        InitSubPanel.SetActive(false);
        StartSubPanel.SetActive(false);
        OptionSubPanel.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        ActiveInitPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
