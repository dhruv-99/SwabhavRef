function printDetails(employee) {
    for (var _i = 0, employee_1 = employee; _i < employee_1.length; _i++) {
        var e = employee_1[_i];
        console.log(e.id);
        console.log(e.name);
        console.log(e.designation);
        console.log(e.salary);
    }
}
printDetails([{
        id: 101,
        name: "Dhruv",
        designation: "Manager",
        salary: 5000
    },
    {
        id: 102,
        name: "Sanal",
        designation: "Manager",
        salary: 6000
    }]);
