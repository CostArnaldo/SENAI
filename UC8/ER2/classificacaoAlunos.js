let listaAlunos = ["Eduarda", "Beatriz", "Chico", "Fernando", "Manuela", "Yasmin", "Carla"];

for (let i = 0; i < listaAlunos.length; i++) {
    //const element = array[i];
    console.log(i)
    if (i == 0) {
        console.log("zero localizado: " + listaAlunos[i])
    }
    if (i % 2 != 0) {
        console.log("número ímpar localizado: " + listaAlunos[i])
    }
    else {
        console.log("número par localizado: " + listaAlunos[i])
    }

}