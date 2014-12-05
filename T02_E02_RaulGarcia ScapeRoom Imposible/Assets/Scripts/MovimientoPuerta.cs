using UnityEngine;
using System.Collections;

public class MovimientoPuerta : MonoBehaviour {

	[SerializeField]
	public GameObject Puerta;
	public Animation animationP;
	public bool abierta = false;

	// Use this for initialization
	// Cuando se inicie, añade la animacion.
	void Start () {
		animationP = Puerta.GetComponent<Animation> ();
	}

	// Cuando nuestro personaje entre en contacto con el collider, solo y solo si tiene la llave, se inicia la animacion de abrir puerta.
	void OnTriggerEnter (Collider collider){
		if (collider.gameObject.GetComponent<Inventario> ().llave && collider.name == "Player") {
			abierta = true;
			animationP.Play ("abrirPuerta");
		} 
	}

	// Despues de ejecutarse la animacion de abrir, cuando nuestro player deja de estar en contacto con el collider, se inicia la animacion de cerrar puerta.
	void OnTriggerExit(Collider collider) {
		if (abierta == true) {
			abierta = false;
			animationP.Play ("cerrarPuerta");
		}
	}
}