using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseSinglePlayerMap : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChooseFirstMap()
    {
        SceneManager.LoadScene("Map1");
    }

    // Update is called once per frame
    public void ChooseSecondMap()
    {
        SceneManager.LoadScene("Map2");
    }

    // Update is called once per frame
    public void ChooseThirdMap()
    {
        SceneManager.LoadScene("Map3");
    }
}
