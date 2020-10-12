using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private void onMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
