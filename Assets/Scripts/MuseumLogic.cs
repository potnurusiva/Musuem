using UnityEngine; using System.Collections;

public class MuseumLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject welcomeUI, startUI, secondUI, thirdUI, fourthUI, restartUI;
	public GameObject welcomePoint, startPoint, playPoint, thirdPoint, fourthPoint, restartPoint;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	public void goPuzzle() { 
		welcomeUI.SetActive (false);
		//startPoint.GetComponent<GvrAudioSource> ().Stop ();
		iTween.MoveTo (player, startPoint.transform.position, 5f);
		startUI.SetActive (true);
		startPoint.GetComponent<GvrAudioSource> ().Play ();
	}

	public void startPuzzle() { 
		startUI.SetActive (false);
		startPoint.GetComponent<GvrAudioSource> ().Stop ();
		iTween.MoveTo (player, playPoint.transform.position, 5f);
		secondUI.SetActive (true);
		playPoint.GetComponent<GvrAudioSource> ().Play ();
	}
	public void secondPuzzle() { 
		secondUI.SetActive (false);
		playPoint.GetComponent<GvrAudioSource> ().Stop ();
		iTween.MoveTo (player, thirdPoint.transform.position, 5f);
		thirdUI.SetActive (true);
		thirdPoint.GetComponent<GvrAudioSource> ().Play ();
	}
	public void thirdPuzzle() { 
		thirdUI.SetActive (false);
		thirdPoint.GetComponent<GvrAudioSource> ().Stop ();
		iTween.MoveTo (player, fourthPoint.transform.position, 5f);
		fourthUI.SetActive (true);
		fourthPoint.GetComponent<GvrAudioSource> ().Play ();
	}
	public void fourthPuzzle() { 
		fourthUI.SetActive (false);
		fourthPoint.GetComponent<GvrAudioSource> ().Stop ();
		iTween.MoveTo (player, restartPoint.transform.position, 5f);
		restartUI.SetActive (true);
		restartPoint.GetComponent<GvrAudioSource> ().Play ();
	}
	public void resetPuzzle() { 
		restartUI.SetActive (false);
		restartPoint.GetComponent<GvrAudioSource> ().Stop ();
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", welcomePoint.transform.position, 
				"time", 3, 
				"easetype", "linear",
				"oncompletetarget", this.gameObject
			)
		);


		welcomeUI.SetActive (true);
		//startPoint.GetComponent<GvrAudioSource> ().Play ();
	}

}
