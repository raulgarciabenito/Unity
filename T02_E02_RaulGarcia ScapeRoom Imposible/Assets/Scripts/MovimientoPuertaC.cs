using UnityEngine;
using System.Collections;

public class MovimientoPuertaC : MonoBehaviour {
	
	[SerializeField]
	public GameObject GOPuertaC;
	public Animation animationP;
	public bool abierta = false;
	
	// Use this for initialization
	// Cuando se inicie, añade la animacion.
	void Start () {
		animationP = GOPuertaC.GetComponent<Animation> ();
	}

	// Cuando nuestro personaje entre en contacto con el collider, se inicia la animacion de abrir puerta.
	void OnTriggerEnter (Collider collider){
		abierta = true;
		animationP.Play ("abrirPuertaC");
	}

	// Despues de ejecutarse la animacion de abrir, cuando nuestro player deja de estar en contacto con el collider, se inicia la animacion de cerrar puerta.
	void OnTriggerExit(Collider collider) {
		if (abierta == true) {
			abierta = false;
			animationP.Play ("cerrarPuertaC");
		}
	}
}