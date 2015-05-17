using UnityEngine;
using System.Collections;

public class LevelGeneration : MonoBehaviour {

	public GameObject[] TileMotifs_Objects = new GameObject[21];
	
	void Start() {
		for (int i = 0; i < TileMotifs_Objects.Length; i ++) {
			print (TileMotifs_Objects[i].name + ", " + TileMotifs_Objects[i].GetComponent<Tile>().GetTurns());
		}
	}
}
