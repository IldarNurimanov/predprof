using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TextsScript : MonoBehaviour
{
    public void OnNazad(){
        SceneManager.LoadScene(0);
    }
    public void OnStroenieAtomaAnimation(){
        SceneManager.LoadScene(2);
    }
    public void OnDiffusiaAnimation(){
        SceneManager.LoadScene(4);
    }
    public void OnMolekularkaAnimation(){
        SceneManager.LoadScene(6);
    }
    public void OnVlajnostAnimation(){
        SceneManager.LoadScene(8);
    }
    public void OnAlphaRaspadAnimation(){
        SceneManager.LoadScene(10);
    }
    public void OnBetaRaspadAnimation(){
        SceneManager.LoadScene(12);
    }
}
