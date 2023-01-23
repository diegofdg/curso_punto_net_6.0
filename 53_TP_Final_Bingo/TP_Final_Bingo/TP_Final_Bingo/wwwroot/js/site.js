const btn_lanzar_bolilla = document.getElementById("btn-lanzar-bolilla");
const span_ultima_bolilla = document.getElementById("ultima-bolilla");
const span_carton_ganador = document.getElementById("carton-ganador");

let bolillero = [];
let carton1 = guardarCarton(0, 27);
let carton2 = guardarCarton(27, 54);
let carton3 = guardarCarton(54, 81);
let carton4 = guardarCarton(81, 108);
let cartones = [...carton1, ...carton2, ...carton3, ...carton4];
let ganadores = [0, 0, 0, 0];
let finDelJuego = false;

span_carton_ganador.textContent = "aún no hay ganadores.";
btn_lanzar_bolilla.addEventListener("click", lanzarBolilla, true);

async function lanzarBolilla() {
    const numero = generarNumero();

    revisarCartones(numero, cartones);

    await guardarHistorialBolillero(numero);

    if (revisarGanadores()) {
        btn_lanzar_bolilla.removeEventListener("click", lanzarBolilla, true);
        btn_lanzar_bolilla.disabled = true;
        guardarHistorialCartones();
    };
}

function generarNumero() {
    let numero = 0;
    let encontreUnoNuevo = false;

    while (!encontreUnoNuevo) {
        numero = Math.floor(Math.random() * (91 - 1) + 1);
        encontreUnoNuevo = true;

        if (bolillero.includes(numero)) {            
            encontreUnoNuevo = false;
        } else {
            bolillero.push(numero);
            span_ultima_bolilla.textContent = numero;
        }
    }
    return numero;
}

function revisarCartones(numero, carton) {
    carton.forEach((value, index) => {
        if (value == numero) {
            const encontrado = document.querySelector(`[data-id="${index}"]`);
            encontrado.classList.add("encontrado");
            
            if (index < 27) {
                carton1 = carton1.filter((item) => item !== numero);
            }
            if (index >= 27 && index < 54) {
                carton2 = carton2.filter((item) => item !== numero);
            }
            if (index >= 54 && index < 81) {
                carton3 = carton3.filter((item) => item !== numero);
            }
            if (index >= 81 && index < 108) {
                carton4 = carton4.filter((item) => item !== numero);
            }
        }
    });
}

function revisarGanadores() {
    if (carton1.length == 12) {
        ganadores[0] = 1;
        finDelJuego = true;
    }

    if (carton2.length == 12) {
        ganadores[1] = 2;
        finDelJuego = true;
    }

    if (carton3.length == 12) {
        ganadores[2] = 3;
        finDelJuego = true;
    }

    if (carton4.length == 12) {
        ganadores[3] = 4;
        finDelJuego = true;
    }

    if (finDelJuego) {
        let resultadoFinal = ganadores.filter(numero => numero > 0);
        span_carton_ganador.textContent = resultadoFinal.toString();
        return finDelJuego;
    } else {
        return finDelJuego;
    }
};

function guardarCarton(desde, hasta) {        
    const carton = [];
    for (let i=desde; i<hasta; i++) {
        const numero = Number(document.querySelector(`[data-id="${i}"]`).textContent);
        if (numero == "") {
            carton.push(0);
        } else {
            carton.push(numero);
        }
    }
    return carton;
}

function guardarHistorialCartones() {
    let historialCartones = {};    
    historialCartones.carton1 = ganadores[0];
    historialCartones.carton2 = ganadores[1];
    historialCartones.carton3 = ganadores[2];
    historialCartones.carton4 = ganadores[3];

    let request;

    if (window.XMLHttpRequest) {
        // New browsers.
        request = new XMLHttpRequest();
    }
    else if (window.ActiveXObject) {
        // Old IE Browsers.
        request = new ActiveXObject("Microsoft.XMLHTTP");
    }

    if (request != null) {
        let url = "/Home/HistorialCartones";
        request.open("POST", url, false);
        request.setRequestHeader("Content-Type", "application/json");
        request.onreadystatechange = function () {
            if (request.readyState == 4 && request.status == 200) {
                let response = JSON.parse(request.responseText);
                if (response !== 'ok') {
                    alert(response);
                }
            }
        };
        request.send(JSON.stringify(historialCartones));
    }
}

function guardarHistorialBolillero(numero) {
    let historialBolillero = {};
    historialBolillero.Numero = numero;

    let request;

    if (window.XMLHttpRequest) {
        // New browsers.
        request = new XMLHttpRequest();
    }
    else if (window.ActiveXObject) {
        // Old IE Browsers.
        request = new ActiveXObject("Microsoft.XMLHTTP");
    }

    if (request != null) {
        let url = "/Home/HistorialBolillero";
        request.open("POST", url, false);
        request.setRequestHeader("Content-Type", "application/json");
        request.onreadystatechange = function () {
            if (request.readyState == 4 && request.status == 200) {
                let response = JSON.parse(request.responseText);
                if (response !== 'ok') {
                    alert(response);
                }                
            }
        };
        request.send(JSON.stringify(historialBolillero));        
    }
}