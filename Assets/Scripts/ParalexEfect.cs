using UnityEngine;

public class ParalexEfect : MonoBehaviour
{
    public Transform camara;
    public float velocidadParallax;
    public float posicionInicial;
    public float anchoSprite;


    
    void Start()
    {
        posicionInicial = transform.position.x;
            anchoSprite = CalcularAncho();
    }
   
    void Update()
    {
        float distancia = camara.position.x * velocidadParallax;
        float tiempo = (camara.position.x * velocidadParallax);

        transform.position = new Vector3(posicionInicial + distancia, transform.position.y, transform.position.z);

        if (tiempo > posicionInicial + anchoSprite) posicionInicial += anchoSprite;
        else if (tiempo < posicionInicial - anchoSprite) {posicionInicial -= anchoSprite;}

    }

    float CalcularAncho(){
        float ancho = 0f;
        foreach (Transform child in transform){
            SpriteRenderer sr = child.GetComponent<SpriteRenderer>();
            if (sr !=null){
                ancho+=sr.bounds.size.x;
            }
        }
        return ancho;
    }
}
