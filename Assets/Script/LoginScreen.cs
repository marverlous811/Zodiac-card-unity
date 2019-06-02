using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginScreen : MonoBehaviour
{
    public InputField nameField;
    public InputField roomField;
    public InputField serverEndPoint;
    public Button loginButton;

    private Rect windowRect = new Rect(0,0,Screen.width, Screen.height); 

    void Start()
    {
        //Subscribe to onClick event
        loginButton.onClick.AddListener(adminDetails);
    }

    public void adminDetails()
    {
        string name = nameField.text;
        string room = roomField.text;
        string server = serverEndPoint.text;

        SceneManager.LoadScene("GameScene");

        Debug.Log("user: "+ name + " connect to " + server + " room " + room);
    }

    private void OnGUI() {
        
    }
}
