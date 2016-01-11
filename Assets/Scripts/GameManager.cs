using UnityEngine;
using System.Collections;

public enum GameState
{
	Playing,
	GameOver,
	DrawingPath,
	Other
}

public class GameManager : MonoBehaviour
{
	#region PUBLIC VARIABLES

	// Singleton
	public static GameManager Instance;

	public GameObject pinPrefab;
	public GameState State;

	#endregion

	#region PRIVATE VARIABLES


	#endregion

	#region MONO METHODS

	void Awake ()
	{
		Instance = this;
	}

	void Start ()
	{
	
	}

	void Update ()
	{
	
	}

	#endregion

}
