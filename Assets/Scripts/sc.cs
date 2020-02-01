using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sc : MonoBehaviour
{
    public float init;
    // Start is called before the first frame update
    void Start()
    {
        init = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if( Time.time - init > 3){
            this.GetComponent<Text>().text = "The End?";
        }
    }
}
