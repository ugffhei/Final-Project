using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject game;
    public GameObject canvas;
    public void StartGame() {
        game.SetActive(true);canvas.SetActive(false);
    }
    public void Replay()
    {
        var s = SceneManager.GetActiveScene();
        SceneManager.LoadScene(s.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
