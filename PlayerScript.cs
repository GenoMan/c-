using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
    
    public int theScore = 0;

	void Update () {
        //These two lines are all there is to the actual movement..
        float moveInput = Input.GetAxis("Horizontal") * Time.deltaTime * 3; 
        transform.position += new Vector3(moveInput, 0, 0);

		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("caught"); 
		var position = transform.position; 
		// Iterate through them and find the closest one
		foreach (GameObject go in gos)  { 
			go.transform.position=position+new Vector3(0.4f,0,0);
			position+=new Vector3(0.4f,0,0);
		} 



        //Restrict movement between two values
        if (transform.position.x <= -2.5f || transform.position.x >= 2.5f)
        {
            float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f); //Clamp between min -2.5 and max 2.5
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
	}

    //OnGUI is called multiple times per frame. Use this for GUI stuff only!
    void OnGUI()
    {
        //We display the game GUI from the playerscript
        //It would be nicer to have a seperate script dedicated to the GUI though...
        GUILayout.Label("Score: " + theScore);
    }    
}
