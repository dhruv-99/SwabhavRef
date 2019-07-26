import { Component } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './student.component.html',
    // styleUrls: ['./student.component.css']
})




export class StudentComponent {

    student: IStudent = {
        roll_number: 12,
        name: "Dhruv",
        cgpa: 7.8
    }

    students: IStudent[];
    student1: IStudent[];
    constructor() {
        this.student1 = [{
            roll_number: 18,
            name: "Dhruv",
            cgpa: 7.8
        }, {
            roll_number: 9,
            name: "Akash",
            cgpa: 7.8
        }
        ]
    }
    loadStudData($event) {
        console.log($event);
        this.students = this.student1;
    }

}

interface IStudent {
    roll_number: number,
    name: string,
    cgpa: number
}

