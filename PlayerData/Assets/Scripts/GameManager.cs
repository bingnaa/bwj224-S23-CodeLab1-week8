using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerDataScriptableObject p1;
    public PlayerDataScriptableObject p2;
    public Text t1;
    public Text t2;
    
    // Start is called before the first frame update
    void Start()
    {
        t1.GetComponent<Transform>().position = p1.currentPosition;
        t2.GetComponent<Transform>().position = p2.currentPosition;
        t1.text = p1.health + "";
        t2.text = p2.health + "";
    }
}
