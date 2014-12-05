using UnityEngine;
using System.Collections;

public class Teletransporte : MonoBehaviour {

	[SerializeField]
	public GameObject posicArriba;
	public GameObject posicAbajo;
	public Vector3 CoordenTeleport;

	// Use this for initialization
	// Cuando se inicie, añade la animacion.
	void Start () {
		CoordenTeleport = posicAbajo.transform.position;
	}

	// Cuando nuestro player entre en el collider de teletransporte, cambiara sus coordenadas a donde le hayamos indicado con el gameObject.
	void OnTriggerEnter(Collider collider){
		posicArriba.transform.position = CoordenTeleport;
	}
}