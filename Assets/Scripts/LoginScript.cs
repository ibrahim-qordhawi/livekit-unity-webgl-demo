using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginScript : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_InputField portField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        Debug.Log("Input value: " + inputField.text);
        Constants.Token = inputField.text;
        Debug.Log("Port value: " + portField.text);
        Constants.ServerPort = portField.text;
        SceneManager.LoadScene("Playground");
    }
}
