using UnityEngine;

public class Gestiongrenouille : MonoBehaviour
{
    //ce script permet de faire disparaitre le poisson pour 2 secondes après l'avoir attrapé, puis de le faire réapparaître pour pouvoir le réattraper à nouveau (code utilisé dans le script de l'hameçon)
    public void DesactiverGrenouille(){
        this.gameObject.SetActive(false);
        Invoke("ReafficherGrenouille", 2f); // réapparaît après 3 secondes
    }

    public void ReafficherGrenouille(){
        this.gameObject.SetActive(true);
    }   

}
