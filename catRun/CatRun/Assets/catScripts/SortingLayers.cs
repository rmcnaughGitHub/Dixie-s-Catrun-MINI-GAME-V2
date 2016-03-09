using UnityEngine;
using System.Collections;

public class SortingLayers : MonoBehaviour {

	public string SortingLayerName = "Default";
	public int SortingOrder = 0;

	void Awake () {
		if (gameObject.GetComponent<SpriteRenderer> () ) {

			gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = SortingLayerName;
			gameObject.GetComponent<SpriteRenderer> ().sortingOrder = SortingOrder;

		}else if ( gameObject.GetComponent<MeshRenderer> () ) {
			gameObject.GetComponent<MeshRenderer> ().sortingLayerName = SortingLayerName;
			gameObject.GetComponent<MeshRenderer> ().sortingOrder = SortingOrder;
			
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
