using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

	// Singleton
	public static LevelManager Instance;

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
