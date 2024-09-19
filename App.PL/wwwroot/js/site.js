let Departments = document.getElementsByClassName("Department");

for (let i = 0; i < Departments.length; i++) {
    Departments[i].addEventListener("click", () => {
        window.location.href = `/Employee/Index?DepartmentID=${+Departments[i].getAttribute("data-id") }`;
    });
}