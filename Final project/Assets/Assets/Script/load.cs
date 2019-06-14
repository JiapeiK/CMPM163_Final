using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            SceneManager.LoadScene("Daylight");
       }
        if (Input.GetKeyUp(KeyCode.S))
        {
            SceneManager.LoadScene("rain");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            SceneManager.LoadScene("Starlight");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            SceneManager.LoadScene("Shooting star");
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            SceneManager.LoadScene("Firework");
        }
    }
}
