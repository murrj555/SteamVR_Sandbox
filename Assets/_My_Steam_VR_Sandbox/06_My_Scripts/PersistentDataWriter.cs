using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersistentDataWriter : MonoBehaviour {

	public static PersistentDataWriter PDWriter;

	
	public int playerNumber;
	public bool isVRVersion;
	//public float timer;

	//Timer Variables
	public Text timerText;
	private float startTime;
	private bool isFinished = false;

	// Use this before initialization
	// this script might be better with the UI Button Click Test. Also you should change the name
	// of button click test script to UI Manager
	void Awake () {


		Debug.Log("On Awake PersistentDataWriter");

		//If the PersistentDataWriter exsists dont destroy it.
		if(PDWriter == null)
		{
			DontDestroyOnLoad(gameObject);
			PDWriter = this;
		}
		//If the PersistentDataWriter has data dont destroy the object!
		else if (PDWriter != this)
		{
			Destroy(gameObject);
		}
		
	
	}
	
	// Use this fore initialization
	// Start things, like Timer
	void Start () {

		//trace this
		Debug.Log("On Start. Timer");

        //start counting the time
        startTime = Time.time;
	}

	// Update is called once per frame
	void Update (){
        if (isFinished)
        {
            return;
        }

		//time counter logic
		float t = Time.time - startTime;

        //create mins
        string minutes = ((int)t / 60).ToString();
		//create secs
		string seconds = (t % 60).ToString("f2");

		//display text as mins first, then secs
		timerText.text = minutes + ":" + seconds;
	}

	public void Finished(){

		//you finished the game
		isFinished = true;
		//timer text color
		timerText.color = Color.yellow;
	}

}
