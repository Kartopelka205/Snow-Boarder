using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Wingame : MonoBehaviour
{
    [SerializeField] float delay = 2f;
    [SerializeField] ParticleSystem finishEffect;
  private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            finishEffect.Play();
            Invoke("ReloadScene" , delay);
    }
}
void ReloadScene (){
        SceneManager.LoadScene(0);
    }
}
