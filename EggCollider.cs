using UnityEngine;
using System.Collections;

public class EggCollider : MonoBehaviour {

    PlayerScript myPlayerScript;

    //Automatically run when a scene starts
    void Awake()
    {
        myPlayerScript = transform.parent.GetComponent<PlayerScript>();
    }

    //Triggered by Unity's Physics
	void OnTriggerEnter(Collider theCollision)
    {
	
        GameObject collisionGO = theCollision.gameObject;
        //Destroy(collisionGO);
		collisionGO.tag="caught";

        myPlayerScript.theScore++;
    }
}
