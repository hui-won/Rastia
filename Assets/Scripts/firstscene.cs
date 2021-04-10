using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameScene()
    {
        SceneManager.LoadScene("game_first");
    }
    public void checkScene()
    {
        SceneManager.LoadScene("check_first");
    }
}
