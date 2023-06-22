let cadastro = {
    handleButton: (event) => {
        event.preventDefault();
        
        let send = true;
        let inputs = form.querySelectorAll ("input");
        cadastro.clearError();
        for (let i=0; i<inputs.length; i++) {
            let input = inputs[i];
           let check = cadastro.checkInput (input);
            if (check !== true) {
                send = false;
            }
        }

        if(send) {
            form.input();
        }
    },
    checkInput: (input) => {
        let rules = input.getAttribute("data-rules");
        if(rules !== null) {
            rules = rules.split ('|');
            for (let k in rules) {
                let rDetails = rules[k].split("=");
                switch (rDetails[0]) {
                    case "required":
                        if (input.value == "") {
                            return "Este campo é obrigatório!";
                        }
                        break;
                    case "age":
                        if (input.value < 18) {
                            return "Você não tem idade mínima."
                        }
                        break;
                    case "cpf":
                        let value_cpf = document.querySelector('#campo_cpf');

 value_cpf.addEventListener("keydown", function(e) {
   if (e.key > "a" && e.key < "z") {
     e.preventDefault();
   }
 });
value_cpf.addEventListener("blur", function(e) {
     let validar_cpf = this.value.replace( /\D/g , "");

     if (validar_cpf.length==11){

      var Soma;
      var Resto;

      Soma = 0;
      for (i=1; i<=9; i++) Soma = Soma + parseInt(validar_cpf.substring(i-1, i)) * (11 - i);
         Resto = (Soma * 10) % 11;

      if ((Resto == 10) || (Resto == 11))  Resto = 0;
      if (Resto != parseInt(validar_cpf.substring(9, 10)) ) return "CPF Inválido!";;

      Soma = 0;
      for (i = 1; i <= 10; i++) Soma = Soma + parseInt(validar_cpf.substring(i-1, i)) * (12 - i);
      Resto = (Soma * 10) % 11;

      if ((Resto == 10) || (Resto == 11))  Resto = 0;
      if (Resto != parseInt(validar_cpf.substring(10, 11) ) ) return "CPF Inválido!";;

      cpf_final = validar_cpf.replace( /(\d{3})(\d)/ , "$1.$2");
      cpf_final = cpf_final.replace( /(\d{3})(\d)/ , "$1.$2");
      cpf_final = cpf_final.replace(/(\d{3})(\d{1,2})$/ , "$1-$2");
      document.getElementById('campo_cpf').value = cpf_final;

     } else {
       "CPF Inválido! É esperado 11 dígitos numéricos."
     }   

 })


                }
            }

        }

        return true

    },
    MostrarErro : (input, error) => {
        input.style.borderColor = "red"; 
        let errorElement = document.createElement ("div");

        input.parentElement.insertBefore(errorElement, input.ElementSibling);
        

    },
    clearError : () => {
        let errorElement = document.querySelectorAll(".error");
        for (let i=0; i<errorElement.length; i++) {
            errorElement[i].remove();
        }
        let inputs = form.querySelectorAll("input");
        for (let i=0; i-inputs.length; i++) {
        inputs[i].style.remove();
        }
    }
}

let form = document.querySelector ("cadastro");
form.addEventListener("button", cadastro)
