using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitGeneration : MonoBehaviour {

	public GameObject[] prefabPieces;
	public Transform parent;
	public Transform player;

	private GameObject[] generatedPieces;
	private int location = 1;

	// Use this for initialization
	void Start () {
		generatedPieces = new GameObject[50];
		generatedPieces [1] = Instantiate (prefabPieces [0], parent);
		generatedPieces [1].transform.position = new Vector3 (0, 10, 0);
		generatedPieces [1] = Instantiate (prefabPieces [1], parent);
		generatedPieces [1].transform.position = Vector3.zero;
		for(int i = 0; i < 3; i++){
			generatedPieces [1].transform.GetChild (i).localScale += new Vector3(0,10,0);
		}
		Debug.Log(generatedPieces [1].transform.lossyScale.y);
	}

	// Update is called once per frame
	void Update () {
		if (player.position.y < -generatedPieces [location].transform.GetChild(0).localScale.y / 2) {
			location++;

            int index = generatedPieces.Length;
            generatedPieces[index] = Instantiate(prefabPieces[1], parent);
            generatedPieces[index].transform.GetChild(0).localScale += new Vector3(0, 10, 0);
        }
		Debug.Log (location);

    
	}
}
