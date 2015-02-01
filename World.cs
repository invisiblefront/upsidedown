using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

    public float hSliderValue = 0.0F;
    public float sliderPositionY=10f;

	void Start () {

        Debug.Log(Screen.orientation);
	}
	
	void Update () {





	}



    void OnGUI()
    {
    
        hSliderValue = GUI.HorizontalSlider(new Rect(0, sliderPositionY, Screen.width, 100), hSliderValue, -180f, 180f);

        Vector3 temp = transform.localEulerAngles;
        temp.z = hSliderValue;
        transform.localEulerAngles = temp;
         
    }
}
