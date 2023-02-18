using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apparisseur : MonoBehaviour
{
    [SerializeField] private GameObject[] objetsQuiApparaissent;

    public void FaireApparaitreLesObjets() {
        foreach (GameObject objet in objetsQuiApparaissent) {
            objet.SetActive(true);
        }
    }

    public void FaireDisparaitreLesObjets() {
        foreach (GameObject objet in objetsQuiApparaissent) {
            objet.SetActive(false);
        }
    }
}
