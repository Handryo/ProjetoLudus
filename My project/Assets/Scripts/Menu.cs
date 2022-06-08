using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene(1)");
    }
    
    public void QuitGame()
    {
        //Jogo compilado ---> Application.Quit();
        //Editor Unity
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
