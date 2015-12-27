using UnityEngine;
using System.Collections;

public class test : MonoBehaviour 
{
	// The items in the box.
	// You assign these items to valid prefabs in the editor.
	// E.g. LettucePreb, BeerPrefab, etc.
	public GameObject[] items = new GameObject[3];

	// Update is called once per frame
void OnCollisionEnter2D(Collision2D _colInfo)
	{
		Player _player = _colInfo.collider.GetComponent<Player>();
		if (_player != null) {
			Vector3 position = transform.position;
			// Clone the objects that are "in" the box.
			foreach (GameObject item in items) {
				if (item != null) {
					// Add code here to change the position slightly
					// so the items are scattered a little bit.
					Instantiate (item, position, Quaternion.identity);
				}
			}
			// Get rid of the box.
			Destroy (gameObject);
		}
	}/*
	void OnCollisionEnter2D(Collision2D _colInfo)
	{
		Player _player = _colInfo.collider.GetComponent<Player>();
		if (_player != null)
		{
			Debug.Log ("WOW");
		}
	}*/

}

