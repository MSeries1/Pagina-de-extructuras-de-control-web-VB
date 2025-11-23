// FUNCIÓN CON SWITCH
function calcular(operacion) {
  // Obtener los valores
  let num1 = parseFloat(document.getElementById("num1").value);
  let num2 = parseFloat(document.getElementById("num2").value);
  let resultado;

  // Validar que sean números
  if (isNaN(num1) || isNaN(num2)) {
    mostrarResultado(" Por favor ingresa ambos números");
    return;
  }

  // ESTRUCTURA SWITCH
  switch (operacion) {
    case "+":
      resultado = num1 + num2;
      mostrarResultado(`${num1} + ${num2} = ${resultado}`);
      break;

    case "-":
      resultado = num1 - num2;
      mostrarResultado(`${num1} - ${num2} = ${resultado}`);
      break;

    case "*":
      resultado = num1 * num2;
      mostrarResultado(`${num1} × ${num2} = ${resultado}`);
      break;

    case "/":
      if (num2 === 0) {
        mostrarResultado(" No se puede dividir entre cero");
      } else {
        resultado = num1 / num2;
        mostrarResultado(`${num1} ÷ ${num2} = ${resultado.toFixed(2)}`);
      }
      break;

    default:
      mostrarResultado(" Operación no válida");
  }
}

function mostrarResultado(texto) {
  let divResultado = document.getElementById("resultado");
  divResultado.textContent = texto;
  divResultado.classList.add("mostrar");
}
