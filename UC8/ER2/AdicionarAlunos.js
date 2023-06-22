let listaDeEstudantes = ["Eduarda", "Beatriz", "Chico", "Fernando", "Manuela", "Yasmin", "Carla"];
let quantidadeDeEstudantes = listaDeEstudantes.length;

if (quantidadeDeEstudantes < 5) {
    listaDeEstudantes.push("João");
    console.log(listaDeEstudantes);
} else {
    console.log("Não é possível inserir mais alunos nessa turma")
}