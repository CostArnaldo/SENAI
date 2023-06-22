let dataAtual = new Date(2022,8,15);
let dataEvento = new Date(2022,9,10);
let listaParticipantes = ["Eduarda", "Beatriz", "Chico", "Fernando", "Manuela", "Yasmin", "Carla"];
let idadeParticipante = 30

    if(dataEvento > dataAtual) {
        console.log("Agendar Evento")
    } else {console.log("data invalida")}

    console.log("------------------")
     if(idadeParticipante >= 18) {
        console.log("entrada Permitida")
     } else {
        console.log("idade invalida")
     }  
     console.log(idadeParticipante)
     numeroParticipantes = listaParticipantes.length

     if(numeroParticipantes < 100) {
        console.log("permitir cadastro")
     } else {
        console.log("cadastro excedido")
     }