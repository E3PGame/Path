using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class PinStyle
{
	public Color32 PinColor;
	public Image PinImage;
	public RuntimeAnimatorController PinAnimator;
	public AudioClip PinBeat;
}

public class PinStyleManager : MonoBehaviour
{

	// Singleton
	public static PinStyleManager Instance;

	public PinStyle[] PinStyles;

	#region MONO METHODS

	void Awake ()
	{
		Instance = this;
	}

	void Start ()
	{
	
	}

	#endregion
}
