function solve (input) {
    let students = [];

    for (let line of input) {
        let tokens = line.split(' -> ');

        let name = tokens[0];
        let age = Number(tokens[1]);
        let grade = Number(tokens[2]);

        let student = {};
        student.name = name;
        student.age = age;
        student.grade = grade;

        students.push(student);
    }

    for (let student of students) {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade.toFixed(2)}`);
    }
}