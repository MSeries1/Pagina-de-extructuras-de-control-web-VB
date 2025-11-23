// Variables globales
let currentSection = "intro";
let examAnswers = [null, null, null, null, null];
let examCorrect = [0, 0, 0, 0, 0]; // 0 = incorrecta, 1 = correcta

// Códigos por defecto para cada editor
const uniDefaultCode = `// Crea un arreglo de frutas
let frutas = ["Manzana", "Pera", "Banana"];

// Accede al primer elemento (posición 0)
console.log(frutas[0]);

// Modifica el segundo elemento
frutas[1] = "Uva";
console.log("Después del cambio:", frutas);

// Añade un nuevo elemento al final
frutas.push("Naranja");
console.log("Después de añadir:", frutas);`;

const bidDefaultCode = `// Crear una matriz bidimensional (tabla 2x3)
let matriz = [
    [8, 9, 7],
    [10, 6, 9]
];

// Acceder al elemento en la fila 1, columna 2
console.log("Elemento en [1][2]:", matriz[1][2]);

// Modificar un elemento
matriz[0][1] = 15;
console.log("Después de modificar [0][1]:", matriz);

// Recorrer toda la matriz
console.log("Recorriendo la matriz:");
for (let fila = 0; fila < matriz.length; fila++) {
    for (let col = 0; col < matriz[fila].length; col++) {
        console.log(\`[\${fila}][\${col}] = \${matriz[fila][col]}\`);
    }
}`;

const triDefaultCode = `// Crear un arreglo tridimensional (como un cubo)
let cubo = [
    [   // Capa 0 (Z=0)
        [1, 2],  // Fila 0, Columnas 0 y 1
        [3, 4]   // Fila 1, Columnas 0 y 1
    ],
    [   // Capa 1 (Z=1)
        [5, 6],  // Fila 0, Columnas 0 y 1
        [7, 8]   // Fila 1, Columnas 0 y 1
    ]
];

// Acceder a diferentes elementos
console.log("Elemento en [0,0,0]:", cubo[0][0][0]);
console.log("Elemento en [1,1,1]:", cubo[1][1][1]);

// Modificar un elemento
cubo[0][1][0] = 9;
console.log("Después de modificar [0,1,0]:", cubo);

// Recorrer todo el cubo
console.log("Recorriendo el cubo:");
for (let z = 0; z < cubo.length; z++) {
    console.log(\`Capa \${z}:\`);
    for (let y = 0; y < cubo[z].length; y++) {
        for (let x = 0; x < cubo[z][y].length; x++) {
            console.log(\`  [\${z},\${y},\${x}] = \${cubo[z][y][x]}\`);
        }
    }
}`;

// Inicializar editores con código por defecto
document.addEventListener("DOMContentLoaded", function () {
  document.getElementById("codeUni").textContent = uniDefaultCode;
  document.getElementById("codeBid").textContent = bidDefaultCode;
  document.getElementById("codeTri").textContent = triDefaultCode;
  showSection("intro");
});

// Mostrar sección específica
function showSection(sectionId) {
  document.querySelectorAll(".section").forEach((section) => {
    section.style.display = "none";
  });

  document.getElementById(sectionId).style.display = "block";
  currentSection = sectionId;

  // Actualizar barra de progreso
  updateProgress(sectionId);
}

// Actualizar barra de progreso
function updateProgress(sectionId) {
  const sections = [
    "intro",
    "explicacionesUni",
    "unidimensional",
    "quiz1",
    "explicacionesBid",
    "bidimensional",
    "quiz2",
    "explicacionesTri",
    "tridimensional",
    "finalExam",
  ];
  const index = sections.indexOf(sectionId);
  const progress = ((index + 1) / sections.length) * 100;

  document.getElementById("progressBar").style.width = `${progress}%`;
  document.getElementById("progressIndicator").textContent = `Paso ${
    index + 1
  } de ${sections.length}`;
}

// Ejecutar código desde el editor
function ejecutarCodigo(editorId, consoleId) {
  const codigo = document.getElementById(editorId).textContent;
  const consoleElement = document.getElementById(consoleId);

  // Limpiar consola
  consoleElement.innerHTML = "";

  try {
    // Capturar console.log
    const logMessages = [];
    const originalConsoleLog = console.log;
    console.log = function (...args) {
      logMessages.push(args.join(" "));
    };

    // Ejecutar código
    eval(codigo);

    // Restaurar console.log
    console.log = originalConsoleLog;

    // Mostrar mensajes en la consola
    logMessages.forEach((msg) => {
      const line = document.createElement("div");
      line.className = "console-line";
      line.textContent = msg;
      consoleElement.appendChild(line);
    });

    // Si no hay mensajes, mostrar un mensaje por defecto
    if (logMessages.length === 0) {
      const line = document.createElement("div");
      line.className = "console-line";
      line.textContent =
        "El código se ejecutó correctamente, pero no generó salida.";
      consoleElement.appendChild(line);
    }
  } catch (error) {
    // Mostrar error en la consola
    const line = document.createElement("div");
    line.className = "console-line";
    line.style.color = "red";
    line.textContent = `Error: ${error.message}`;
    consoleElement.appendChild(line);

    // Mostrar alerta
    alert(`Error en el código: ${error.message}`);
  }
}

// Restablecer código al valor por defecto
function restablecerCodigo(editorId, defaultCode) {
  document.getElementById(editorId).textContent = defaultCode;
}

// Verificar respuesta en los quizzes
function checkAnswer(element, isCorrect, nextSection) {
  // Remover clases de otros elementos
  element.parentElement.querySelectorAll(".option-card").forEach((card) => {
    card.classList.remove("correct", "incorrect");
  });

  // Añadir clase según si es correcta o no
  if (isCorrect === 0) {
    element.classList.add("correct");

    // Mostrar feedback positivo
    const feedbackId = element
      .closest(".section")
      .querySelector(".feedback").id;
    document.getElementById(feedbackId).innerHTML =
      '<div class="alert alert-success mt-3">¡Correcto! Muy bien hecho.</div>';

    // Avanzar a la siguiente sección después de un breve delay
    setTimeout(() => {
      showSection(nextSection);
    }, 1500);
  } else {
    element.classList.add("incorrect");

    // Mostrar feedback con explicación
    const feedbackId = element
      .closest(".section")
      .querySelector(".feedback").id;
    let message = "";

    switch (feedbackId) {
      case "feedback1":
        message =
          'Incorrecto. Recuerda que los índices empiezan desde 0, por lo que "verde" está en la posición 1.';
        break;
      case "feedback2":
        message =
          'Incorrecto. En una matriz, el primer índice es la fila y el segundo la columna. "c" está en la fila 1, columna 0.';
        break;
      default:
        message = "Incorrecto. Revisa la explicación e intenta de nuevo.";
    }

    document.getElementById(
      feedbackId
    ).innerHTML = `<div class="alert alert-danger mt-3">${message}</div>`;
  }
}

// Seleccionar respuesta en el examen final
function selectAnswer(element, isCorrect, questionNumber) {
  // Remover selección de otras opciones en la misma pregunta
  const parent = element.parentElement;
  parent.querySelectorAll(".exam-option").forEach((option) => {
    option.classList.remove("correct", "incorrect");
  });

  // Marcar la respuesta seleccionada
  examAnswers[questionNumber - 1] = isCorrect;

  // Añadir clase visual según si es correcta o no
  if (isCorrect === 0) {
    element.classList.add("correct");
  } else {
    element.classList.add("incorrect");
  }
}

// Calificar examen final
function calificarExamen() {
  // Verificar que todas las preguntas han sido respondidas
  if (examAnswers.includes(null)) {
    alert("Por favor, responde todas las preguntas antes de calificar.");
    return;
  }

  // Calcular puntuación
  let score = 0;
  examAnswers.forEach((answer, index) => {
    if (answer === 0) {
      // 0 significa correcta
      score++;
      examCorrect[index] = 1;
    }
  });

  // Mostrar resultado
  const resultadoDiv = document.getElementById("resultadoExamen");
  let resultadoHTML = `
                <div class="final-score ${
                  score === 5 ? "score-animation" : ""
                }">
                    Resultado: ${score}/5
                </div>
            `;

  if (score === 5) {
    resultadoHTML += `
                    <div class="alert alert-success">
                        <h5>¡Excelente! 🎉</h5>
                        <p>Has dominado los conceptos básicos de arreglos. ¡Eres un guerrero del código!</p>
                    </div>
                `;
  } else if (score >= 3) {
    resultadoHTML += `
                    <div class="alert alert-warning">
                        <h5>¡Muy bien! 👍</h5>
                        <p>Has comprendido la mayoría de los conceptos, pero aún puedes mejorar un poco.</p>
                    </div>
                `;
  } else {
    resultadoHTML += `
                    <div class="alert alert-danger">
                        <h5>¡Sigue practicando! 📚</h5>
                        <p>Te recomendamos repasar los conceptos y volver a intentarlo.</p>
                    </div>
                `;
  }

  // Añadir botón para reiniciar
  resultadoHTML += `
                <button class="btn btn-primary mt-3" onclick="reiniciarCurso()">Volver al Inicio</button>
            `;

  resultadoDiv.innerHTML = resultadoHTML;
}

// Reiniciar curso
function reiniciarCurso() {
  // Resetear variables
  examAnswers = [null, null, null, null, null];
  examCorrect = [0, 0, 0, 0, 0];

  // Remover selecciones del examen
  document.querySelectorAll(".exam-option").forEach((option) => {
    option.classList.remove("correct", "incorrect");
  });

  // Restablecer editores de código
  document.getElementById("codeUni").textContent = uniDefaultCode;
  document.getElementById("codeBid").textContent = bidDefaultCode;
  document.getElementById("codeTri").textContent = triDefaultCode;

  // Limpiar consolas
  document.querySelectorAll(".console").forEach((console) => {
    console.innerHTML = "";
  });

  // Volver a la introducción
  showSection("intro");
}
