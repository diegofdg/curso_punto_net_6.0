const btn_lanzar_bolilla = document.getElementById("btn-lanzar-bolilla");
const span_ultima_bolilla = document.getElementById("ultima-bolilla");
const span_carton_ganador = document.getElementById("carton-ganador");

let bolillero = [];
let carton1 = guardarCarton(0, 27);
let carton2 = guardarCarton(27, 54);
let carton3 = guardarCarton(54, 81);
let carton4 = guardarCarton(81, 108);
let cartones = [...carton1, ...carton2, ...carton3, ...carton4];
let ganadores = [];

span_carton_ganador.textContent = "";
btn_lanzar_bolilla.addEventListener("click", lanzarBolilla, true);

async function lanzarBolilla() {
    const numero = generarNumero();

    revisarCartones(numero, cartones);

    await guardarNumero(numero);

    if (revisarGanadores()) {
        btn_lanzar_bolilla.removeEventListener("click", lanzarBolilla, true);
        btn_lanzar_bolilla.disabled = true;
        guardarDatosEnServidor();
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
        ganadores.push("1");
    }

    if (carton2.length == 12) {
        ganadores.push("2");
    }

    if (carton3.length == 12) {
        ganadores.push("3");
    }

    if (carton4.length == 12) {
        ganadores.push("4");
    }

    if (ganadores.length > 0) {
        span_carton_ganador.textContent = ganadores.toString();
        return true;
    } else {
        return false;
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

function guardarDatosEnServidor() {
    console.log("Enviando los datos al servidor");
}

function guardarNumero(numero) {
    let historialBolillero = {};
    historialBolillero.Numero = numero;

    let request;
    if (window.XMLHttpRequest) {
        //New browsers.
        request = new XMLHttpRequest();
    }
    else if (window.ActiveXObject) {
        //Old IE Browsers.
        request = new ActiveXObject("Microsoft.XMLHTTP");
    }
    if (request != null) {
        var url = "/Home/HistorialBolillero";
        request.open("POST", url, false);
        request.setRequestHeader("Content-Type", "application/json");
        request.onreadystatechange = function () {
            if (request.readyState == 4 && request.status == 200) {
                var response = JSON.parse(request.responseText);
                console.log(response);
                if (response !== 'ok') {
                    alert(response);
                }                
            }
        };
        request.send(JSON.stringify(historialBolillero));        
    }
}