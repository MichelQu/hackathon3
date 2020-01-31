using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ray_tracing : MonoBehaviour
{
   // Texte à afficher en dessous de la planète
   public Text nameText;

   // Le tuyau visé par la souris
   protected GameObject selected;

   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {
     // Génère un rayon sous la souris
     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     RaycastHit hit;

     if (Physics.Raycast(ray, out hit))
     {
       // On stocke le GameObject visé par la souris
       selected = hit.transform.gameObject;
       Debug.Log(selected.name);

       // On affiche le nom de la planette
       nameText.text = selected.name;

       // On fait clignoter
       // Highlighter hl = selected.GetComponent<Highlighter>();
       // if (hl != null) {
       //   hl.highlight = true;
       // }
       selected.GetComponent<Renderer>().material.SetFloat("_FirstOutlineWidth", 0.2f);

     }
     else {

       // On arrête d'afficher du texte
       nameText.text = "";
       // Highlighter hl = selected.GetComponent<Highlighter>();
       // if (hl != null) {
       //   hl.highlight = false;
       // }
       selected.GetComponent<Renderer>().material.SetFloat("_FirstOutlineWidth", 0.0f);
     }
   }
}
