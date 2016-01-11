using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{

	#region PUBLIC VARIABLES

	public Vector2 PinPosition {
		get {
			return pinPosition;
		}
		set {
			pinPosition = value;
		}
	}

	public enum pinType
	{
		Regular,
		Special,
		CrazyGuy
	}

	public int indexRow;
	public int indexCol;

	#endregion


	#region PRIVATE VARIABLES

	private Vector2 pinPosition;
	private Color32 pinColor;
	private Image pinImage;
	private Animator pinAnimatorController;
	private AudioSource pinAudioSource;
	private AudioClip pinBeat;

	#endregion


	#region MONO METHODS

	void Awake ()
	{
		pinImage = GetComponent<Image> ();
		pinAnimatorController = GetComponent <Animator> ();
		pinAudioSource = GetComponent<AudioSource> ();
		pinBeat = pinAudioSource.clip;
	}

	void Start ()
	{
	
	}

	void Update ()
	{
	
	}

	#endregion

	#region PUBLIC METHODS

	public void animateCorrectTouch ()
	{
		
	}

	public void animateWrongTouch ()
	{
		
	}

	public void animateFadeIn ()
	{
		
	}

	public void animateFadeOut ()
	{
		
	}

	public void animateAward ()
	{
		
	}

	#endregion

	#region PRIVATE METHODS

	private void drawLine ()
	{
		
	}

	private void ApplyPinStyleFromManager (int index)
	{
		pinImage = PinStyleManager.Instance.PinStyles [index].PinImage;
		pinAnimatorController.runtimeAnimatorController = PinStyleManager.Instance.PinStyles [index].PinAnimator;
		pinAudioSource.clip = PinStyleManager.Instance.PinStyles [index].PinBeat;
	}

	#endregion
}
