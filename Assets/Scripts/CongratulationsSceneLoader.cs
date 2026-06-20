using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CongratulationsSceneLoader : MonoBehaviour
{

    public TMP_Text congo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        congo.text = "Congratulations, " + playerName + "! You reached 10!";
    }
    public void ResetCounter()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        SceneManager.LoadScene("WelcomeScene");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
