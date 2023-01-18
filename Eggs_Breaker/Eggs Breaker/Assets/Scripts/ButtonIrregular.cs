using UnityEngine;
using UnityEngine.UI;


public class ButtonIrregular : MonoBehaviour
{
    public float Invisible = 0.1f;

    private void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = Invisible; 
    }

}
