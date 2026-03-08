const input = document.getElementById('taskInput');
const addTaskButton = document.getElementById('addTaskButton');
const taskList = document.getElementById('taskList');

function createTaskItem(taskText) {
    const li = document.createElement('li');
    li.className = 'list-group-item d-flex justify-content-between align-items-center';

    const textSpan = document.createElement('span');
    textSpan.textContent = taskText;

    const deleteButton = document.createElement('button');
    deleteButton.textContent = 'Delete';
    deleteButton.className = 'btn btn-danger btn-sm delete-task-button';
    deleteButton.addEventListener('click', function () {
        li.remove();
    });

    li.appendChild(textSpan);
    li.appendChild(deleteButton);
    return li;
}

function addTask() {
    const taskText = input.value.trim();
    if (!taskText) {
        return;
    }

    const taskItem = createTaskItem(taskText);
    taskList.appendChild(taskItem);
    input.value = '';
    input.focus();
}

addTaskButton.addEventListener('click', addTask);

input.addEventListener('keydown', function (event) {
    if (event.key === 'Enter') {
        addTask();
    }
});

Array.from(taskList.querySelectorAll('li')).forEach(function (existingItem) {
    const taskText = existingItem.textContent.trim();
    const taskItem = createTaskItem(taskText);
    existingItem.replaceWith(taskItem);
});