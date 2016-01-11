using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{

	// Singleton
	public static InputManager Instance;

	#region PRIVATE VARIABLES

	private GameManager gm;

	private bool isSwipe = false;
	private float fingerStartTime = 0.0f;
	private Vector2 fingerStartPosition = Vector2.zero;

	#endregion

	#region MONO METHODS

	void Awake ()
	{
		Instance = this;
		gm = GameObject.FindObjectOfType<GameManager> ();
	}

	void Update ()
	{
		if (gm.State == GameState.Playing && Input.touchCount > 0) {

			foreach (Touch touch in Input.touches) {
				switch (touch.phase) {
				case TouchPhase.Began:
					/* this is a new touch */
					isSwipe = true;
					fingerStartTime = Time.time;
					fingerStartPosition = touch.position;
					break;

				case TouchPhase.Canceled:
					/* The touch is being canceled */
					isSwipe = false;
					Debug.Log ("TOUCH CANCELED");
					break;

				case TouchPhase.Moved:
					/* we are swiping on the screen */
					Vector2 direction = touch.position - fingerStartPosition;
					Vector2 swipeType = Vector2.zero;
					if (Mathf.Abs (direction.x) > Mathf.Abs (direction.y)) {
						// the swipe is horizontal:
						swipeType = Vector2.right * Mathf.Sign (direction.x);
					} else {
						// the swipe is vertical:
						swipeType = Vector2.up * Mathf.Sign (direction.y);
					}
					if (swipeType.x != 0.0f) { // Horizontal Slide
						if (swipeType.x > 0.0f) {
							// SLIDE RIGHT
						} else {
							// SLIDE LEFT
						}
					}

					if (swipeType.y != 0.0f) { // Vertical Slide
						if (swipeType.y > 0.0f) {
							// SLIDE UP
						} else {
							// SLIDE DOWN
						}
					}

					break;

				case TouchPhase.Ended:

//					float gestureTime = Time.time - fingerStartTime;
//					float gestureDist = (touch.position - fingerStartPosition).magnitude;

//					if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist) {
					if (isSwipe) {
						{
							direction = touch.position - fingerStartPosition;
							swipeType = Vector2.zero;

							if (Mathf.Abs (direction.x) > Mathf.Abs (direction.y)) {
								// the swipe is horizontal:
								swipeType = Vector2.right * Mathf.Sign (direction.x);
							} else {
								// the swipe is vertical:
								swipeType = Vector2.up * Mathf.Sign (direction.y);
							}

							if (swipeType.x != 0.0f) {
								if (swipeType.x > 0.0f) {
									// MOVE RIGHT
								} else {
									// MOVE LEFT
								}
							}

							if (swipeType.y != 0.0f) {
								if (swipeType.y > 0.0f) {
									// MOVE UP
								} else {
									// MOVE DOWN
								}
							}
						}

						break;
					}

					break;
				
				}
			}
		}
	}

	#endregion

}