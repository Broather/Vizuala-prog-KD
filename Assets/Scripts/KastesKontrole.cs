using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    private float horRot;
    private float verRot;

    private void FixedUpdate() {
        horRot = Input.GetAxis("Horizontal");
        verRot = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(verRot, 0.0f, -horRot),Space.Self);
    }
}
