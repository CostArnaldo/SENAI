import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import ImagemClasses from "./assets/Classes.png"
import ImagemAtributos from "./assets/Atributos.png"
import ImagemOperações from "./assets/Operações.png"
import ImagemHerança from "./assets/Herança.png"

function App() {
  

  return (
    <div className="App">
      <h1 style={{ color: '#daa520'}}>Classes:</h1><p>No sistema de cadastro, as classes representam os objetos que serão manipulados pela aplicação. 
      As classes podem incluir, por exemplo, a classe "Pessoa", que teria atributos como "nome", "endereço", "telefone", "e-mail", etc. 
      Outras classes poderiam ser criadas para representar informações adicionais, 
      como a classe "PessoaFisica", que poderia incluir atributos como "CPF","data de nascimento", "gênero", etc.</p>
      <img src={ImagemClasses}/>

<h1 style={{ color: '#daa520'}}>Atributos:</h1> <p>Os atributos são as características dos objetos que estão sendo modelados. 
  Cada classe pode ter vários atributos que representam informações relevantes para o sistema. No caso do sistema de cadastro, 
  como mencionado anteriormente, a classe "Pessoa" poderia ter atributos como "nome", "endereço", "telefone", "e-mail", etc.</p>
  <img src={ImagemAtributos}/>

<h1 style={{color: '#daa520'}}>Operações:</h1> <p>As operações são os métodos ou funções que a aplicação pode executar em um objeto. 
  Cada classe pode ter várias operações que permitem que a aplicação realize ações nos objetos representados pela classe. 
  No caso do sistema de cadastro, uma operação poderia ser "calcular imposto de pessoa física" ou "calcular imposto de pessoa jurídica", 
  que permitiria que uma nova pessoa fosse adicionado à base de dados.</p>
  <img src={ImagemOperações}/>

<h1 style={{color: '#daa520'}}>Herança:</h1> <p>A herança é um conceito em que uma classe pode ser derivada de outra classe, de modo que a classe derivada (filha) herde os atributos e operações da classe pai. 
  Isso pode ser útil para evitar a repetição de código e para criar hierarquias de classes. 
  No caso do sistema de cadastro, poderíamos ter uma classe "Pessoa" como classe pai, 
  com as classes "PessoaFisica" e "PessoaJurídica" sendo classes filhas, herdando os atributos e operações da classe "Pessoa".</p>
  <img src={ImagemHerança}/>

<h1 style={{color: '#daa520'}}>Associação:</h1><p>Associação é uma relação em que uma classe tem um relacionamento com outra classe, 
  mas não há uma dependência forte entre elas. No exemplo citado, "Pessoa física" e "Pessoa jurídica" estão associadas à classe "Pessoa", 
  pois ambas são subclasses dela..</p>
  

<h1 style={{color: '#daa520'}}>Agregação:</h1><p>Agregação é uma relação em que uma classe é composta por outras classes,
   mas essas outras classes não são exclusivas dessa classe. Ou seja, essas classes podem existir sem a classe principal. 
   No exemplo citado, a classe "Pessoa" é a classe principal e "Endereço" é uma classe agregada,  pois pode existir independentemente da existência da classe "Pessoa".</p>
  

<h1 style={{color: '#daa520'}}>Composição:</h1><p>Composição é uma relação em que uma classe é composta por outras classes,
   mas essas outras classes são exclusivas dessa classe. Ou seja, essas classes não podem existir sem a classe principal. 
   No exemplo citado, "Pessoa física" e "Pessoa jurídica" são classes compostas da classe "Pessoa", pois ambas dependem da existência da classe "Pessoa" para existir. 
   Além disso, os atributos "CPF" e "data de nascimento" pertencem exclusivamente à classe "Pessoa física" e os atributos "CNPJ" e "razão social" pertencem exclusivamente à classe "Pessoa jurídica".</p>
   
    </div>
  )
}

export default App
