using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _EnemySpike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
             SceneManager.LoadScene("level1");
             Debug.Log("YOU LOSE");
        }
    }

}
