using UnityEngine;

public class Gestiontortues : MonoBehaviour
{
     //permet de faire disparaitre la tortue
    public void DesactiverTortue(){
        this.gameObject.SetActive(false);
        Invoke("ReafficherTortue", 2f); // réapparaît après 2 secondes
    }

  
}
