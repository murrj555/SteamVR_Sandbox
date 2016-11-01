using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersistentDataWriter : MonoBehaviour {

	public static PersistentDataWriter PDWriter;

    /// <summary>
    /// This is where I will keep all data that I will be tracking.
    /// </summary>
    
        // isFinishd boolean, Did the player win the game or lose?
        private bool isFinished = false;

        //Player Number, what player played this game?
        public int playerNumber;

        //VR Version Boolean, Did the player play the VR Version of the game or the 3D Version?
	    public string version;

        //Timer Variables, What time did this game start?
        private float startTime;
        
        //Health Variable, What is my health?
        public float health;

        //Experience Variable, What is my experience?
        public float experience;

        //Level Variable, What level am I on?
        public float level;


    /// <summary>
    /// This is where I will keep all of the text UI references
    /// </summary>

        //put all your public text references here to display all of the data that is changing and being updated dynamically.
        public Text txtRefVersion;

        // timer text reference
        public Text timerText;

        //  UI Text Reference for the Health Variable
        public Text txtRefHealth;

        //  UI Text Reference for the Experience Variable
        public Text txtRefExperience;

        //  UI Text Reference for the Level Variable
        public Text txtRefLevel;




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
