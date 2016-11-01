using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdjustPersistentDataWriter : MonoBehaviour {

    public static AdjustPersistentDataWriter ADWriter;

    void Awake()
    {


        Debug.Log("On Awake AdjustPersistentDataWriter");

        //If the PersistentDataWriter exsists dont destroy it.
        if (ADWriter == null)
        {
            DontDestroyOnLoad(gameObject);
            ADWriter = this;
        }
        //If the PersistentDataWriter has data dont destroy the object!
        else if (ADWriter != this)
        {
            Destroy(gameObject);
        }


    }

    public void IncreaseHealth()
    {

        Debug.Log("Clicked Button!");
        PersistentDataWriter.PDWriter.health += 10;

        //Write to string using this statement
        //health.ToString();
        //PersistentDataWriter.PDWriter.health += 10;

    }

    public void DecreaseHealth()
    {

        Debug.Log("Clicked Button!");
        PersistentDataWriter.PDWriter.health -= 10;

    }

    public void IncreaseExperience()
    {

        Debug.Log("Clicked Button!");
        PersistentDataWriter.PDWriter.experience += 10;

    }

    public void DecreaseExperience()
    {

        Debug.Log("Clicked Button!");
        PersistentDataWriter.PDWriter.experience -= 10;

    }

    public void VRButton()
    {
        PersistentDataWriter.PDWriter.version = "VR Version!";
    }



}