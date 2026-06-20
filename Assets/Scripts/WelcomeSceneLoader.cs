using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class WelcomeSceneLoader : MonoBehaviour
{
    public TMP_InputField nameField;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            SceneManager.LoadScene("CounterScene");
        }    

        
    }

    public void PressContinue()
    {
        string NamedPlayer = nameField.text;
        Debug.Log(nameField.text);
        if (NamedPlayer.Trim() == "")
        {
            return;

        }
        PlayerPrefs.SetString("PlayerName", NamedPlayer);
        SceneManager.LoadScene("CounterScene");
        Debug.Log("Button Pressed");




   
    }
    // Update is called once per frame
    void Update()
    {

    }
}
