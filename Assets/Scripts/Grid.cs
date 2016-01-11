using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour
{
	#region PUBLIC VARIABLES

	public float GridWidth {
		get {
			return gridWidth;
		}
		set {
			gridWidth = value;
		}
	}

	public float GridHeight {
		get {
			return gridHeight;
		}
		set {
			gridHeight = value;
		}
	}

	public List<Pin> PinsInGrid;
	public List<Pin> PinsInPath;

	public enum GridMoveDirection
	{
		Left,
		Right,
		Up,
		Down
	}

	#endregion

	#region PRIVATE VARIABLES

	private float gridWidth;
	private float gridHeight;

	#endregion

	#region MONO METHODS

	void Start ()
	{
	
	}

	void Update ()
	{
	
	}

	#endregion

	#region PUBLIC METHODS

	public void animateFadeIn ()
	{
		
	}

	public void animateFadeOut ()
	{
			
	}

	public void generateGrid ()
	{
		
	}

	#endregion
}
