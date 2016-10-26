using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Decay : MonoBehaviour {

    //make everything public. Easier to edit, test and trouble shoot in editor.
    [Header("Edit Settings")] //you can use this to add your own header in your unity script component
    [Space(10)] //adds space between public variables, makes things easier to read.
    public float decaySeconds = 1f;
    public Image uiImage;

    [Header("Set Scale Multiplier to Zero for no Scaling")] //you can use this to add your own header in your unity script component
    [Space(10)] //adds space between public variables, makes things easier to read.
    public float scaleMultiplier = 2;

    [Header("Edit Settings")] //you can use this to add your own header in your unity script component
    [Space(10)] //adds space between public variables, makes things easier to read.

    [Header("Fade To Input Screen")] //you can use this to add your own header in your unity script component
    [Space(10)] //adds space between public variables, makes things easier to read.
    public bool isSceneTransition;


    /// <summary>
    /// Turn Fade off and one here.
    /// </summary>
    public bool isFading = true;

    [Header("Dont Mess With / For Testing")]//you can use this to add your own header in your unity script component
    [Space(10)] //adds space between public variables, makes things easier to read.
    public float scale; //this can be private if you want it to.
    public float elapsedSeconds = 0; //this can be private if you want it to.

    
	// Use this for initialization
	void Start () {
        //Get the Image component and attach it to this game object
        uiImage = GetComponent<Image>();
        //Destroy this game object, only after the decaySeconds variable.
        Destroy(this.gameObject, decaySeconds);
	}
	
	// Update is called once per frame
	void Update () {


        if (isFading)
            {
                //fade
                uiImage.color = new Color(uiImage.color.r,
                uiImage.color.g,
                uiImage.color.b,
                (decaySeconds - elapsedSeconds) / decaySeconds);
            }

  
        scale = 1 + (elapsedSeconds * scaleMultiplier);
          
        uiImage.gameObject.transform.localScale =
            new Vector3(scale, scale, scale);

        elapsedSeconds += Time.deltaTime;

        if (isSceneTransition)
        {
            //load Input Screen
        
        }

    }
}
