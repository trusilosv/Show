using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

  [SerializeField] ParticleSystem finishEffect;
  private void OnTriggerEnter2D(Collider2D other) {
    if(other.CompareTag("Player")) {
      finishEffect.Play();
      SceneManager.LoadScene(0);
      Invoke(nameof(RestartScene), 100f);
    }
  }
  private void RestartScene(){ 
    SceneManager.LoadScene(0);
  }
}
