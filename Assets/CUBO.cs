using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CUBO : MonoBehaviour
{
    public int puntos;
    public Text textoPuntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void OnTriggerEnter(Collider c){
    Debug.Log("choque tipo trigger"+ c.gameObject.name);
    if (c.gameObject.tag == "Player")
    {puntos++;
    textoPuntos.text = puntos.ToString();
    }
}
}
