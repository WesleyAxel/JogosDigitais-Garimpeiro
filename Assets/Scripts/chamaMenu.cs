using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class chamaMenu : MonoBehaviour

{
    // Start is called before the first frame update



    public void AbrirGame()
    {
        SceneManager.LoadScene("GarimpeiroGameplay");
    }

    public void AbrirCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void sairJogo()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
