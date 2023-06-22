const listaDePecas = ["Lanterna", "Roda", "Parabrisa"];

console.log("Inicio do processamento")

let pesoPeca = 90;

if (pesoPeca > 100) { console.log("peso ok") }
else { console.log("peça recusada") }

let qtdePeca = 11
if (qtdePeca > 10) { console.log("ultrapasssou limite da caixa") }
else { console.log("caixa ok") }

console.log("fim do processamento")

for (let i = 0; i < listaDePecas.length; i++) {
    const nomePeca = listaDePecas[i];
    if (nomePeca.length < 3) { console.log("erro no nome") }
    else { console.log("nome ok") }
}


