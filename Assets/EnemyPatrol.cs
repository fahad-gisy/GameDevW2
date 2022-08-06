
using UnityEngine;


public class EnemyPatrol : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private bool detected = false; // can i see the player?
    [SerializeField] private float speed; // enemy's speed

    [SerializeField] private Transform ourPlayer;
    void Start()
    {
        player = GameObject.FindWithTag("Player"); // help the enemy to find our player
        
    }

    // Update is called once per frame
    void Update()
    {    //the distance between the enemy n the player on X  //A-player pos      //B-enemy pos
        float playerDistance = Vector3.Distance(player.transform.position, transform.position);

        if (playerDistance <= 10 && detected == false) // if the player get closer to the enemy !! enemy detected him
        {
            detected = true; //Detected
            if (detected == true)
            {     //if the player to the left of the enemy in world space
                if (player.transform.position.x < transform.position.x)
                {
                    transform.Translate(Vector3.right * -speed * Time.deltaTime); 
                    transform.Translate(Vector3.back * -speed * Time.deltaTime); 
                }
                else
                {
                    // We use "-speed" to move left and "speed" to move right. Add a - symbol to speed automatically turns that set value negative.
                    transform.Translate(Vector3.right * speed * Time.deltaTime);
                    transform.Translate(Vector3.back * speed * Time.deltaTime); 
                    detected = false; // setting detected to false so it can triggered again 
                }

            }
        }


    }
}


