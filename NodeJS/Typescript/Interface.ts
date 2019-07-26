interface IEmployee{
    id:number,
    salary:number,
    designation:string,
    name:string
}

function printDetails(employee : IEmployee[]){
    for(let e of employee){
        console.log(e.id);
        console.log(e.name);
        console.log(e.designation);
        console.log(e.salary);
    }
}

printDetails([{
    id:101,
    name:"Dhruv",
    designation:"Manager",
    salary:5000
},
{
    id:102,
    name:"Sanal",
    designation:"Manager",
    salary:6000
}])