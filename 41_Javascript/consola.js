// console.log("Hola Mundo");

const lista = ["Joaquin", "Carlos", "Ruben", "Eugenio", "Ezequiel"];

/*
for(let index in lista){
    console.log(lista[index]);
}

for(let item of lista){
    console.log(item);
}

lista.map((item)=>{
    console.log(item);
});

lista.forEach((item)=>{
    console.log(item);
});

for(let i = 0; i < lista.length; i++){
    console.log(lista[i]);
}

let index = 0;
while(index < lista.length) {
    console.log(lista[index]);
    index++;
}

let contador = 0;
const maximo = 10;
while (true) {
  console.log(contador);
  contador++;
  if (contador === maximo) {
    break;
  }
}

console.log(1 == "1"); // true
console.log(1 === "1"); // false

let loca = 1 + "1"; // concatena
console.log(loca);

loca = loca - 1; // operación matemática
console.log(loca);

loca = loca + 1; // operación matemática
console.log(loca);

loca = loca + "1"; // concatena
console.log(loca);

*/

function test (){
    fetch("http://168.181.184.237:8080/api/usuario/getall", { method: "GET"})
    .then(response => response.json())
    .then((data) => {
        console.log(data);
        const listado = data.objeto;
        listado.map(item => {
            document.getElementById("h1Id").innerHTML += item.nombre + "<hr>";
        });
    })
    .catch((error) => {
        console.log(error);
    });
}