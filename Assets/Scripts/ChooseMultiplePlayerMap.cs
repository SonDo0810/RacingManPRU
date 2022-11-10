using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMultiplePlayerMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectFirstMap()
    {
        SceneManager.LoadScene("LocalMultiplayer1");
    }
    public void SelectSecondMap()
    {
        SceneManager.LoadScene("LocalMultiplayer2");
    }
    public void SelectThirdMap()
    {
        SceneManager.LoadScene("LocalMultiplayer3");
    }
}
