using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayer : MonoBehaviour
{
    [SerializeField] int carpmaSayisi = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null && collision.gameObject.tag!="Plane") carpmaSayisi++;
    }
}
