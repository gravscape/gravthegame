using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour {
	public int maxRange = 20;
	public int objectAmount = 5;
	public GameObject prefab;
	public Transform parentTransform;
	public GameObject[] generatedCubes;
	private Random random = new Random();

	// Use this for initialization
	void Start () {
		generatedCubes = new GameObject[objectAmount];
		for (int i = 0; i < objectAmount; i++) {
			generatedCubes [i] = Instantiate (prefab, parentTransform);
		}
		for (int i = 0; i < objectAmount; i++) {
			if (i == 0) {
				generatedCubes [i].transform.position = new Vector3 (0, -3, 0);
			} else {
				generatedCubes [i].transform.position = new Vector3 (Random.Range (-1.0f, 1.0f) * maxRange, Random.Range (-1.0f, 1.0f) * maxRange, 0);
				generatedCubes [i].transform.rotation = Quaternion.AngleAxis (Random.Range (0.0f, 1.0f) * 90, Vector3.back);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
