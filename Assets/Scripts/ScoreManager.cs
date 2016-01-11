using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{

	#region PUBLIC VARIABLES

	// Singleton
	public static ScoreManager Instance;

	public int Score {
		get {
			return score;
		}
		set {
			score = value;
			if (PlayerPrefs.GetInt ("HIghScore") < score)
				PlayerPrefs.SetInt ("HighScore", score);
		}
	}

	public int HighScore {
		get {
			return highScore;
		}
		set {
			highScore = value;
		}
	}

	#endregion

	#region PRIVATE VARIABLES

	private int score;
	private int highScore;

	#endregion

	#region MONO METHODS

	void Awake ()
	{
		Instance = this;

		if (!PlayerPrefs.HasKey ("Score"))
			PlayerPrefs.SetInt ("Score", 0);

		if (!PlayerPrefs.HasKey ("HighScore"))
			PlayerPrefs.SetInt ("HighScore", 0);
	}

	void Start ()
	{
	
	}

	void Update ()
	{
	
	}

	#endregion

	#region PUBLIC METHODS

	public void resetScore ()
	{
		PlayerPrefs.SetInt ("HighScore", 0);
	}

	#endregion
}
