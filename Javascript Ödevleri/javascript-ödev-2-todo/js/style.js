const todotext = document.getElementById("task");
const livetoastbnt = document.getElementById("liveToastBtn");
const container = document.getElementsByClassName("container");
const list = document.getElementById("list");

list.addEventListener("click", completedTodo);

this.addEventListener("click", deleteTodo);

livetoastbnt.addEventListener("click", todoinsert);
document.addEventListener("DOMContentLoaded", loadUI);

function loadUI() {
    let todos = getTodosFromStorage();

    todos.forEach(function(todo) {
        addtodo(todo);
    })
}


function deleteTodo(e) {
    if (e.target.id == "cross") {
        e.target.parentElement.parentElement.remove();
        deleteTodoFromStorage(e.target.parentElement.parentElement.textContent);
        alert("primary", "kayıt Silindi");
    }


}

function addTodoToStorage(newTodo) {
    let todos = getTodosFromStorage();

    todos.push(newTodo);

    localStorage.setItem("todos", JSON.stringify(todos));



}



function getTodosFromStorage() {
    let todos;

    if (localStorage.getItem("todos") === null) {
        todos = [];
    } else {
        todos = JSON.parse(localStorage.getItem("todos"));

    }
    return todos;
}


function todoinsert() {
    if (todotext.value == "") {
        alert("danger", "boşluk içermektedir");
    } else {
        alert("primary", "kayıt başarılı");
        addtodo(todotext.value);
        addTodoToStorage(todotext.value);
    }
}

function deleteTodoFromStorage(deletetodo) {
    let todos = getTodosFromStorage();
    todos.forEach(function(todo, index) {
        if (todo = deletetodo) {
            todos.splice(index, 1);
        }
    });
    localStorage.setItem("todos", JSON.stringify(todos));
}


function completedTodo(e) {
    if (e.target.className == "checked") {
        e.target.classList.remove("checked");
    } else {
        e.target.className = "checked";
    }

}

function alert(alertrole, message) {
    const div = document.createElement("div");
    div.className = `alert alert-${alertrole} text-center fixed-top`;
    div.textContent = `${message}`;
    document.body.prepend(div);
    setTimeout(function() {
        document.body.firstElementChild.remove();
    }, 1500)


}

function addtodo(todoValue) {
    const li = document.createElement("li");
    li.className = " item d-flex justify-content-between "
    li.innerHTML = `${todoValue} <span class="close"><i id="cross" class="fas fa-times"></i></span>`
    list.appendChild(li);

}