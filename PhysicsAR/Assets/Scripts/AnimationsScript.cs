using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnimationsScript : MonoBehaviour
{
    public void OnNazadInStroenieAtomaAnimation(){
        SceneManager.LoadScene(1);
    }
    public void OnNazadInDiffusiaAnimation(){
        SceneManager.LoadScene(3);
    }
    public void OnNazadInMolekularkaAnimation(){
        SceneManager.LoadScene(5);
    }
    public void OnNazadInVlajnostAnimation(){
        SceneManager.LoadScene(7);
    }
    public void OnNazadInAlphaRaspadAnimation(){
        SceneManager.LoadScene(9);
    }
    public void OnNazadInBetaRaspadAnimation(){
        SceneManager.LoadScene(11);
    }
}
