using UnityEngine;
using System.Collections;

public class Llave : MonoBehaviour {

	[SerializeField]
	public GameObject llave;

	// Cuando nuestro personaje entra en el collider de la llave, la coje y la destruye para que no se siga viendo.
	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.name == "Player") {
			collider.gameObject.GetComponent<Inventario>().llave = true;
			Destroy (llave);	
		}
	}
}