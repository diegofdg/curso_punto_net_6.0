console.log("Aplicación Iniciada");

const btn_lanzar_bolilla = document.getElementById("btn-lanzar-bolilla");
const span_ultima_bolilla = document.getElementById("ultima-bolilla");
const span_carton_ganador = document.getElementById("carton-ganador");
btn_lanzar_bolilla.addEventListener("click", lanzarBolilla);

let bolillero = [];

function lanzarBolilla() {
    let numero = 0;
    let encontreUnoNuevo = false;

    while (!encontreUnoNuevo) {
        numero = Math.floor(Math.random() * (91 - 1) + 1);
        encontreUnoNuevo = true;
        if (bolillero.includes(numero)) {
            if (bolillero.length == 90) {
                console.log("No hay mas números");
            } else {
                encontreUnoNuevo = false;
                continue;
            }
        } else {
            bolillero.push(numero);
            span_ultima_bolilla.textContent = numero;
            console.log(numero);
        }                
    }  
}

let carton1 = guardarCarton(0, 27);
let carton2 = guardarCarton(27, 54);
let carton3 = guardarCarton(54, 81);
let carton4 = guardarCarton(81, 108);

function guardarCarton(desde, hasta) {        
    const carton = [];
    for (let i = desde; i < hasta; i++) {
        const numero = document.querySelector(`[data-id="${i}"]`).textContent;
        if (numero !== "") {
            carton.push(numero);
        }
    }
    return carton;
}

//carton1.forEach(item => console.log(item));
//carton2.forEach(item => console.log(item));
//carton3.forEach(item => console.log(item));
//carton4.forEach(item => console.log(item));