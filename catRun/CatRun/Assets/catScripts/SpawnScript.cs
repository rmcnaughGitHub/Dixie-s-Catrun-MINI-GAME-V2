using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public float speed = 0.5f;


	// Use this for initialization
	void Start () {
		Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i<obj.Length; i++){
			obj[i].transform.Translate (speed * Time.deltaTime, 0f, 0f);
			Debug.Log("SPEED ");
		}
	}

	void Spawn(){
		Instantiate( obj[Random.Range (0, obj.GetLength(0) )], transform.position, Quaternion.identity);
		Invoke("Spawn",Random.Range (spawnMin, spawnMax));
	}
}
