using UnityEngine;
using System.Collections;

public class SettingManager : MonoBehaviour
{

	// Singleton
	public static SettingManager Instance;


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
