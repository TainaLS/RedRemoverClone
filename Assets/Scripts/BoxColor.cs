using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BoxColor : MonoBehaviour {

    public enum BColor { Red, RedLight, RedWhite, Green, GreenWhite, Purple, PurpleWhite };
    public BColor color = BColor.Red;

    // Use this for initialization
    void Start () {
        SetColor(color);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SetColor(BoxColor.BColor color) {

        Color colorToBeApplied = Color.white;

        switch (color)
        {
            case BoxColor.BColor.Red:
                colorToBeApplied = Color.red;
                break;
            case BoxColor.BColor.Green:
                colorToBeApplied = Color.green;
                break;
            case BoxColor.BColor.Purple:
                colorToBeApplied = Color.blue;
                break;
        }

        gameObject.GetComponent<Renderer>().sharedMaterial.color = colorToBeApplied;

    }

}
