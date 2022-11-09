using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseSinglePlayerMap : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChooseFirstMap()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    public void ChooseSecondMap()
    {
        SceneManager.LoadScene("LocalMultiplayer");
    }

    // Update is called once per frame
    public void ChooseThirdMap()
    {
        SceneManager.LoadScene("LocalMultiplayer");
    }
}
