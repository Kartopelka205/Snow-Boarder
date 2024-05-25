using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Losegame : MonoBehaviour
{
    [SerializeField] float Delay = 1f;
    [SerializeField] ParticleSystem deathEffect;
    bool lostGame = false;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground" && !lostGame){
            lostGame = true;
            FindObjectOfType<PlayerController>().DisableControls();
            deathEffect.Play();
            Invoke("ReloadScene" , Delay);
        }
    }
    void ReloadScene (){
        SceneManager.LoadScene(0);
    }
}
