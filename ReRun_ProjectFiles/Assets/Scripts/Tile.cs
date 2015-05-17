using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {
		
	//Types 1 : Straight, 2 : Right, 3 : Left, 4 Straight Right, 5 Straight Left, 6 Left Right, 7 All
	public int Turns;
	
	public int GetTurns () {
		return Turns;
	}
}
