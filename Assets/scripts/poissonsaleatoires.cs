using UnityEngine;
using System.Collections.Generic;

public class poissonsaleatoires : MonoBehaviour
{
    //***VOLET_3 :on fait apparaitre et déplacer aléatoirement les poissons
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject poissonjaune;  // Préfabriqué du poisson à faire apparaître
    public List<GameObject> poissons; // Liste des poissons à faire apparaître
    void Start()
    {
        InvokeRepeating("CreerPoisson", 0f, 2f); // Appelle la méthode CreerPoisson toutes les 2 secondes
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void CreerPoisson()
{
    int positionAleatoire = Random.Range(0, poissons.Count - 1);
    GameObject elementAleatoire = poissons[positionAleatoire];

   
    GameObject clone = Instantiate(elementAleatoire, transform.position, transform.rotation);
    clone.GetComponent<DeplacementPoisson>().vitesse = 2f;
    clone.GetComponent<DeplacementPoisson>().direction = new Vector2(-1f, 0);
}
}
