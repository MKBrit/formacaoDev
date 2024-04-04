const todolist = [{
        name:'make dinner',
        duedate: '2024-04-03',
    },{
        name:'make dinner',
        duedate: '2022-12-22'
    }
];
rendertodolist();
function rendertodolist() {
    let todolistHTML = '';

    for (let i = 0; i < todolist.length; i++) {
        const todoObject = todolist[i];
        const {name, duedate} = todoObject;
        const html = `
            <div>${name}</div>
            <div>${duedate}</div>
            <button class="delete-todo-button" onclick="
                todolist.splice(${i},1);
                rendertodolist();
            ">Delete </button>
            `;
        todolistHTML += html;
    }
    document.querySelector('.js-todo-list')
        .innerHTML = todolistHTML;
}

function addTodo() {
    const inputElement = document.querySelector('.js-name-input');
    const name = inputElement.value;
    const dateInputElement = document.querySelector('.js-due-date-input');
    const duedate = dateInputElement.value;
    todolist.push(
        {name,
        duedate}
    );
    inputElement.value = ''; // Clear the name input field
    dateInputElement.value = ''; // Clear the due date input field
    rendertodolist();
}


