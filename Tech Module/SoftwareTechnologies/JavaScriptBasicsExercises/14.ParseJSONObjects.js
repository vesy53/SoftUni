function solve (input) {
    let students = input.map(JSON.parse);

    for (let student of students) {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Date: ${student.date}`);
    }
}