using UnityEngine;
using TMPro;
using System.Collections;


public class affichagetextealeatoire : MonoBehaviour
{

    //=====variables globales============

    //UI
    public TMP_Text texteCouleur; //mettre le texte dans l'inspecteur pour pouvoir le modifier
   public string couleurChoisie;
    //affichage du texte dans une liste qu'on peut changer dans l'inspecteur
    public string[] textes;
    //entete son
[Header("Son")]
AudioSource audioSource;
 public AudioClip JauneSound;
    public AudioClip OrangeSound;
    public AudioClip RougeSound;
    public AudioClip VertSound;
    public AudioClip BleuSound;
    public AudioClip MauveSound;
    public AudioClip RoseSound;
    
    void Awake()
{
    audioSource = GetComponent<AudioSource>(); 
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
      //generer nombre aleatoire entre 0 et la longueur du tableau de textes (assuigner le texte aleatoire a la variable texteCouleur)
        int textealeatoire = Random.Range(0, textes.Length); 
        texteCouleur.text = textes[textealeatoire]; //afficher le texte aleatoire 
        // Debug.Log("Le texte aleatoire est : " + texteCouleur.text); //afficher le texte aleatoire dans la console pour verifier que ca marche 
     
     if(texteCouleur.text == "Rouge"){
       
        texteCouleur.color = Color.red; //changer la couleur du texte en rouge
         audioSource.PlayOneShot(RougeSound);
     }
     else if(texteCouleur.text == "Bleu"){
        Debug.Log("Le texte est bleu");
        texteCouleur.color = Color.blue; //changer la couleur du texte en bleu
         audioSource.PlayOneShot(BleuSound);
     }
     else if(texteCouleur.text == "Vert"){
        Debug.Log("Le texte est vert");
        texteCouleur.color = Color.green; //changer la couleur du texte en vert
         audioSource.PlayOneShot(VertSound);
     }
     else if(texteCouleur.text == "Jaune"){
        Debug.Log("Le texte est jaune");
        texteCouleur.color = Color.yellow; //changer la couleur du texte en jaune
         audioSource.PlayOneShot(JauneSound);
     }
      couleurChoisie = texteCouleur.text;
    }

    public void  Redmarrer(){
        //après avoir choisi le bon poisson correspondant à la couleur du texte, on redemarre la couleur du texte
     int textealeatoire = Random.Range(0, textes.Length); 
        texteCouleur.text = textes[textealeatoire]; //afficher le texte aleatoire 
        
     
    if (texteCouleur.text == "Rouge") {
    texteCouleur.color = Color.red;
    audioSource.PlayOneShot(RougeSound);
}
else if (texteCouleur.text == "Bleu") {
    texteCouleur.color = Color.blue;
    audioSource.PlayOneShot(BleuSound);
}
else if (texteCouleur.text == "Vert") {
    texteCouleur.color = Color.green;
    audioSource.PlayOneShot(VertSound);
}
else if (texteCouleur.text == "Jaune") {
    texteCouleur.color = Color.yellow;
    audioSource.PlayOneShot(JauneSound);
}
else if (texteCouleur.text == "Orange") {
    texteCouleur.color = new Color(1f, 0.5f, 0f); // orange
    audioSource.PlayOneShot(OrangeSound);
}
else if (texteCouleur.text == "Mauve") {
    texteCouleur.color = new Color(0.5f, 0f, 0.5f); // mauve
    audioSource.PlayOneShot(MauveSound);
}
else if (texteCouleur.text == "Rose") {
    texteCouleur.color = new Color(1f, 0.4f, 0.7f); // rose
    audioSource.PlayOneShot(RoseSound);
}
      couleurChoisie = texteCouleur.text;
    
    }
}
