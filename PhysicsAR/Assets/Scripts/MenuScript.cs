using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void OnStroenieAtoma(){
        SceneManager.LoadScene(1);
    }
    public void OnDiffusia(){
        SceneManager.LoadScene(3);
    }
    public void OnMolekularka(){
        SceneManager.LoadScene(5);
    }   
    public void OnVlajnost(){
        SceneManager.LoadScene(7);
    }  
    public void OnAlphaRaspad(){
        SceneManager.LoadScene(9);
    }
    public void OnBetaRaspad(){
        SceneManager.LoadScene(11);
    }
}
