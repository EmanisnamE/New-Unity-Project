using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Loadlevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
