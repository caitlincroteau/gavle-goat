using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mischief : MonoBehaviour

{

    public GameObject nextMischief;

    private void OnTriggerEnter2D(Collider2D other) {
       if(other.gameObject.tag == "Player"){

            Debug.Log("Collide");
            PlayerScript player = other.gameObject.GetComponent<PlayerScript>();

            if(this.gameObject.tag == "Rubbish Bin") {
                transform.Rotate(0,0,-90);
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                //add script for creating old lady
                // Instantiate(nextMischief, transform.position, transform.rotation);      
            } else if (this.gameObject.tag == "Old Lady") {
                transform.Rotate(0,0,-90);
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                Destroy(this.gameObject.GetComponent<OldLady>());
                player.setPaintCan(true);

            } else if (this.gameObject.tag == "Town Hall") {   
                if(player.hasPaintCan()){
                    GameObject graffiti = this.gameObject.transform.GetChild(0).gameObject;
                    graffiti.SetActive(true);
                    Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                }
            }

        }
    }


}