using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SferasKontrole : MonoBehaviour
{
    public Text winText;
   

    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
 
 void Update () {
    
}
    private void OnTriggerEnter(Collider other) {
        // ja tags ar ko ir sadursem ir "Collectable items"
        if(other.gameObject.CompareTag("Collectable Items")){
            // disable-ot to (padarīt neredzamu)
            other.gameObject.SetActive(false);
            winText.text = "Tu uzvarēji!";
        }
    }
}
