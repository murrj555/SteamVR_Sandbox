using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

//[RequireComponent(typeof(AudioSource))]
public class PauseGame2D : MonoBehaviour {
	public Transform canvas;
	//public Transform Player;
    public AudioSource audio;
    public AudioSource exitPauseMenu;
    public AudioClip impact;
    public Camera main;

    //init
    void Start()
    {
        audio = GetComponent<AudioSource>();
        //exitPauseMenu = GetComponent<AudioSource>(A_Beep_Short_Off);
    }

    //Update is called once per frame
    void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
            audio.PlayOneShot(impact, 1F);

            Debug.Log("Pressed Escape, Paused Game.");
            if (audio.mute)
                audio.mute = false;
            else
                audio.mute = true;
        }
    }

   

	public void Pause(){

        if (canvas.gameObject.activeInHierarchy == false)
			{
				canvas.gameObject.SetActive(true);
				Time.timeScale = 0;
				//Player.GetComponent<FirstPersonController>().enabled = false;
                //Cursor.visible = true;


        } 
				else
				{
					canvas.gameObject.SetActive(false);
					Time.timeScale = 1;
					//Player.GetComponent<FirstPersonController>().enabled = true;
                    //Cursor.visible = false;

        }

    }

	}