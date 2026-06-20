using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CounterSceneLoader : MonoBehaviour
{
    public TMP_Text counterText;
    private int counter = 0;

    void Awake()  //here i added awake because it loads the first frame of counterscene even if it is 10 in counter. so it first checks if counter is 10 and goes to congratulations scene.
    {
        counter = PlayerPrefs.GetInt("Counter", 0);

        if (counter >= 10)
        {
            SceneManager.LoadScene("CongratulationsScene");
            return;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        counter = PlayerPrefs.GetInt("Counter", 0);

        UpdateCounterText();

    }

    public void IncrementCounter()
    {
        counter++;
        PlayerPrefs.SetInt("Counter", counter);

        Checkforten();
        UpdateCounterText();
    }
    public void DecrementCounter()
    {
        counter--;
        if (counter < 0)
        { 
            counter = 0;
        }
        PlayerPrefs.SetInt("Counter", counter);
        UpdateCounterText();
    }
    
    void Checkforten()
    {
        if (counter >= 10)
        {
            SceneManager.LoadScene("CongratulationsScene");
        }
    }
    void UpdateCounterText()
    {
        counterText.text = "Counter: " + counter;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
