let cadastro = {
    handleSubmit: (event) => {
        event.preventDefault();
        let send = true;

        let inputs = form.querySelectorAll("input");

        cadastro.clearError();

        for (let i=0; i<inputs.length; i++) {
            let input = inputs[i];
            let check = cadastro.checkInput(input);
            if (check !== true) {
                send = false;
                cadastro.mostrarErro(input, check);

            }
        }

        
        if (send) {
            form.submit();
        }
},
    checkInput: (input)=> {
        let regras = input.getAttribute("data-rules");
        
        if (regras !== null) {
            regras = regras.split("|");
            
            for(let r in regras) {
                let detalhesRegra = regras[r].split("=");
                

                switch (detalhesRegra[0]) {
            
                    case "name": 
                    if(input.value == "") {
                        return "Esse campo precisa ser preenchido!";
                    }
                        break;
                case "age":
                    if(input.value < 18) {
                        return "Idade mínima não atingida."
                    };
                        break;
                case "email":
                if(input.value != "") { 
                    let emailRegex = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/gi;
                    if (!emailRegex.test(input.value.toLowerCase ())) {
                        return "esse email não é válido!"

                    }
                    }
                    break;

                case "cpf":
                    if(input.value.length !== 11 ) {
                        return "CPF inválido! Favor digitar apenas números."
                    };
                        break;
                
                case "senha":
                    if(input.value.length < 3) {
                        return "Mínimo de 4 caracteres."
                    };

                    break;
               
            }
        }

    }
    
return true;

},
    mostrarErro: (input,error) => {
        let errorElement = document.createElement ("div");
        errorElement.classList.add ("error");
        errorElement.innerHTML = error;

     
        input.parentElement.insertBefore(errorElement, input);

    },
    clearError : () => {
        let errorElement = document.querySelectorAll(".error");
        for (let i=0; i<errorElement.length; i++) {
            errorElement[i].remove();
        }
        
    }
};

let form = document.querySelector(".cadastro");
form.addEventListener("submit", cadastro.handleSubmit);
   
        

    
   
        

    

