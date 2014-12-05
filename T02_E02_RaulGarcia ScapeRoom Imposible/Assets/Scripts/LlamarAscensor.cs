using UnityEngine;
using System.Collections;

public class LlamarAscensor : MonoBehaviour {
	
	[SerializeField]
	public GameObject GOInterruptor;

	[SerializeField]
	public GameObject GOAscensor;
	public Animation animacionPulsar;
	public Animation bajadaAscensor;
		
	// Cuando se inicie, añade las animaciones.
	void Start () {
		animacionPulsar = GOInterruptor.GetComponent<Animation> ();
		bajadaAscensor = GOAscensor.GetComponent<Animation> ();
		
	}
	// Se inicia la animacion de subir el ascensor.
	void funcionAscensor () {
		bajadaAscensor.Play ("subirAscensor");
	}

	// Cuando nuestro player entra en contacto con el collider del interruptor, lo pulsa y esto hace que baje el ascensor.
	void OnTriggerEnter(Collider collider)
	{
		if (collider.name == "Player") {
			animacionPulsar.Play ("pulsarInterruptor");
			bajadaAscensor.Play ("bajarAscensor");
		}
	}
	/*
	 * Cuando nuestro player pulsa el boton, se inicia una cuenta atras, y el boton va retrocediendo lentamente a su posicion inicial.
	 * Este es el tiempo que tenemos para coger el ascensor, si el boton vuelve a como estaba antes y no hemos llegado,
	 * el ascensor subira y no podremos cogerlo.
	 */
	void OnTriggerExit(Collider collider)
	{
		if (collider.name == "Player") {
			animacionPulsar.Play ("soltarInterruptor");
		}
	}		
} 