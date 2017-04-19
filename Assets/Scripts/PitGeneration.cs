using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitGeneration : MonoBehaviour {

	public GameObject[] prefabPieces;
	public Transform parent;
	public Transform player;

	private List<GameObject> generatedPieces = new List<GameObject>();
	private int location = 1;

	// Use this for initialization
	void Start () {
		generatedPieces.Add(Instantiate (prefabPieces [0], parent));
		generatedPieces[0].transform.position = new Vector3 (0, 10, 0);
		generatedPieces.Add(Instantiate (prefabPieces [1], parent));
		generatedPieces [1].transform.position = Vector3.zero;
		for(int i = 0; i < 3; i++){
			generatedPieces [1].transform.GetChild (i).localScale += new Vector3(0,10,0);
		}
	}

	// Update is called once per frame
	void Update () {
		if (player.position.y < -generatedPieces [location].transform.GetChild(0).localScale.y / 2) {
			location++;
			GameObject temp = Instantiate (prefabPieces [1], parent);
			generatedPieces.Add(temp);
			for(int i = 0; i < temp.transform.childCount; i++){
				temp.transform.position = new Vector3 (0, -7.5f, 0);
				temp.transform.GetChild(i).localScale += new Vector3(0, 10, 0);
			}
        }
		Debug.Log (location);

    
	}
}
